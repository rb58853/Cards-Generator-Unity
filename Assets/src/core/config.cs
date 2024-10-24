using System;
using System.Collections.Generic;
using System.Data.SqlTypes;
using System.IO;
using System.Linq;
using Cards;
using CardsGenerator;
using UnityEngine;

namespace Config
{
    public enum CardType
    {
        monster,
        spell,
    }
    class CardsGenerationConfig
    {
        public static readonly string namespace_ = "Cards";
        public static readonly string cardsPath = Path.Combine(Application.dataPath, "src", "Generated Cards");
    }
    static class CardGeneration
    {
        private static readonly Dictionary<CardType, Type> CardTypes = new Dictionary<CardType, Type>
        {
            {CardType.monster,typeof(Monster)},
            {CardType.spell,typeof(Spell)}
        };

        public static CardType CurrentTypeView = CardType.monster;
        public static Dictionary<CardType, DynamicGenerator> Cards = InitializeCards();
        public static DynamicGenerator Card { get { return Cards[CurrentTypeView]; } }

        public static Dictionary<CardType, DynamicGenerator> InitializeCards()
        {
            Dictionary<CardType, DynamicGenerator> cards = new Dictionary<CardType, DynamicGenerator>();
            foreach (CardType key in CardTypes.Keys)
            {
                cards[key] = new DynamicGenerator(CardTypes[key], $"{key}Child");
            }
            return cards;
        }
        public static CardType[] AvailableTypes
        {
            get { return CardTypes.Keys.ToArray(); }
        }

        private static void newCard(CardType baseType, string name = "className")
        {
            Cards[baseType] = new DynamicGenerator(type: CardTypes[baseType], name);
        }
        public static void setImage(byte[] image)
        {
            Card.setImage(image);
        }
        public static Sprite GetImage()
        {
            if (Card.image != null)
            {

                Texture2D newTexture = new Texture2D(1, 1);
                newTexture.LoadImage(Card.image);
                Sprite sprite = Sprite.Create(newTexture, new Rect(0, 0, newTexture.width, newTexture.height), new Vector2(.5f, .5f));
                return sprite;
            }
            else
                return null;
        }
        public static void CreateCard()
        {
            // Hacer que solo funcione si no hay errores

            Cards[CurrentTypeView].WriteFile();
            newCard(CurrentTypeView);
        }

    }
}