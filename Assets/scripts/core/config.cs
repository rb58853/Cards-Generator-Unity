using System;
using System.Collections.Generic;
using System.Linq;
using Cards;
using CardsGenerator;
// using CardsGenerator;

namespace Config
{
    public enum CardType
    {
        monster,
    }
    class CardsGenerationConfig
    {
        public static readonly string namespace_ = "Cards";

    }
    static class CardGeneration
    {
        private static readonly Dictionary<CardType, Type> CardTypes = new Dictionary<CardType, Type>
        {
            {CardType.monster,typeof(Monster)}
        };

        public static CardType CurrentTypeView = CardType.monster;
        public static Dictionary<CardType, DynamicGenerator> Cards = InitializeCards();
        public static DynamicGenerator Card = Cards[CurrentTypeView];

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
        public static void CreateCard(CardType cardType)
        {
            // Hacer que solo funcione si no hay errores
            Cards[cardType].WriteFile();
            newCard(cardType);
        }

    }
}