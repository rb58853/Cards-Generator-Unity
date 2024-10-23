using System;
using System.Collections.Generic;
using System.Linq;
using Cards;
// using CardsGenerator;

namespace Config
{
    class CardsGenerationConfig
    {
        public static readonly string namespace_ = "Cards";

    }
    // static class CardGeneration
    // {
    //     private static readonly Dictionary<string, Type> CardTypes = new Dictionary<string, Type>
    //     {
    //         {"monster",typeof(Monster)}
    //     };
    //     public static DynamicGenerator card;

    //     public static void newCard(string baseType, string name = "className")
    //     {
    //         card = new DynamicGenerator(type: CardTypes[baseType], name);
    //     }

    //     public static string[] AvailableTypes
    //     {
    //         get { return CardTypes.Keys.ToArray(); }
    //     }
    // }
}