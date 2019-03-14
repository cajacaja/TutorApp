﻿using System;
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

       
    }
}
