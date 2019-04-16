using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace Tutor_UI
{
    public static class Global
    {
        public const string URI = "http://localhost:61494/";

        public const string AdministratorRoute = "api/Administrator";
        public const string SpolRoute = "api/Spol";
        public const string GradRoute = "api/Grad";
        public const string TipStudentaRoute = "api/TipStudenta";
        public const string PredmetiRoute = " api/Podkategorija";
        public const string TutorTitulaRoute = "api/TutorTitula";
        public const string RadnoStanjeRoute = "api/RadnoStanje";
        public const string TutorRoute = "api/Tutor";
        public const string OblastRoute = "api/Oblast";
        public const string ZahtjevRoute = "api/Zahtjev";
        public const string UcionicaRoute = "api/Ucionica";
        public const string OcjenaTutorRoute = "api/OcjenaTutor";
        public const string BanStudentRoute = "api/BanPrijavaStudent"; 
        public const string BanTutorRoute = "api/BanPrijavaTutors";


        public static Tuple<bool, string> TextInputProvjera(string inputText,string regex="")
        {
            var provjera = IsEmpty(inputText);
            if (!provjera.Item1)
            {
                return provjera;
            }
            else
            {
                
                if (!String.IsNullOrEmpty(regex)&&!Regex.Match(inputText, regex).Success)
                {
                    return new Tuple<bool, string>(false,Messeges.Error_Format);
                }
            }

            return new Tuple<bool, string>(true, "");
        }

        public static Tuple<bool, string> IsEmpty(string inputText) {

            if (String.IsNullOrEmpty(inputText) || String.IsNullOrWhiteSpace(inputText))
            {
                return new Tuple<bool, string>(false,Messeges.Error_Empty);
            }

            return new Tuple<bool, string>(true, "");
        }

        public static string ErrorFinder(string errorName)
        {
            var errorMessage = errorName;

            int startIndex = errorMessage.IndexOf(":") + 1;
            int endIndex = errorMessage.IndexOf("\"}", startIndex + 1);

            if (startIndex > 0 && endIndex > 0)
            {

                string errorResult = errorMessage.Substring(startIndex + 1, endIndex - startIndex - 1);
                errorMessage = errorResult;
            }

            return errorMessage;
        }

       
    }
}

