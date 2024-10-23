using System;
using System.Collections.Generic;

namespace Utils
{
    static class FieldUtils
    {
        static readonly Dictionary<string, string> InputType = new Dictionary<string, string>{
        {"String","string"}
        };
        public static string getBaseName(string fullName)
        {
            bool begin = false;
            string baseName = "";
            foreach (char caracter in fullName)
            {
                if (caracter == '>')
                    break;
                if (begin)
                    baseName += caracter;
                if (caracter == '<')
                    begin = true;
            }
            if (begin)
                return baseName;
            else
                return fullName;
        }
        public static dynamic DefaultValue(Type fieldType, string fieldName)
        {
            //TODO Limpiar este parche
            dynamic value = null;
            if (fieldType == typeof(int))
                value = default(int);

            if (fieldType == typeof(long))
                value = default(long);

            if (fieldType == typeof(string))
                value = fieldName;

            return value;
        }
    }

}