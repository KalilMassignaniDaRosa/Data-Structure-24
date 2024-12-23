using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace _01_Enum
{
    public class Enumerator
    {
        public enum Language
        {
            // Por serem especificacoes de valores nao tem ;
            PTBR, EN, RU
        }

        public Language _language = Language.PTBR;

        public Enumerator(){}

        /*
        Apenas Exemplo
        public Enumerator(Enumerator Enumerator){
            _language = Enumerator;  
        }
        */

        public Language GetLanguageEnumerator(string lang)
        {
            switch (lang.ToLower())
            {
                case "portuguese":
                    return Language.PTBR;
                case "english":
                    return Language.EN;
                case "russian":
                    return Language.RU;
                default:
                    return Language.PTBR;
            }
        }
    }
}