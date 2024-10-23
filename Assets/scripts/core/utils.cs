using System.Collections.Generic;

namespace Utils
{
    static class Field
    {
        static readonly Dictionary<string, string> InputType = new Dictionary<string, string>
        {
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
    }

}