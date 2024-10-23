using System;
using System.Collections.Generic;
using System.Linq;
using Cards;
using CardsGenerator;
// using CardsGenerator;

namespace Config
{
    class CardsGenerationConfig
    {
        public static readonly string namespace_ = "Cards";

    }
    static class CardGeneration
    {
        private static readonly Dictionary<string, Type> CardTypes = new Dictionary<string, Type>
        {
            {"monster",typeof(Monster)}
        };

        public static string CurrentTypeView = "monster";
        public static Dictionary<string, DynamicGenerator> Cards = InitializeCards();
        public static DynamicGenerator Card = Cards[CurrentTypeView];

        public static Dictionary<string, DynamicGenerator> InitializeCards()
        {
            Dictionary<string, DynamicGenerator> cards = new Dictionary<string, DynamicGenerator>();
            foreach (string key in CardTypes.Keys)
            {
                cards[key] = new DynamicGenerator(CardTypes[key], $"{key}Child");
            }
            return cards;
        }
        public static string[] AvailableTypes
        {
            get { return CardTypes.Keys.ToArray(); }
        }

        private static void newCard(string baseType, string name = "className")
        {
            Cards["monster"] = new DynamicGenerator(type: CardTypes[baseType], name);
        }
        public static void CreateCard(string cardType)
        {
            // Hacer que solo funcione si no hay errores
            Cards[cardType].WriteFile();
            newCard(cardType);
        }

    }
}