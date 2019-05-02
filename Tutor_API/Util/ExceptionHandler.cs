using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Web;

namespace Tutor_API.Util
{
    public class ExceptionHandler
    {
        public static string DbUpdateExceptionHandler(SqlException ex)
        {
            switch (ex.Number)
            {
                case 2627:
                    return GetConstraintExceptionMessage(ex);
                default:
                    return ex.Message + " (" + ex.Number + ")";
            }

        }

        private static string GetConstraintExceptionMessage(SqlException ex)
        {
            string newMessage = ex.Message;

            int startIndex = newMessage.IndexOf("'");
            int endIndex = newMessage.IndexOf("'", startIndex + 1);

            if (startIndex > 0 && endIndex > 0)
            {
                string constraintName = newMessage.Substring(startIndex + 1, endIndex - startIndex - 1);



                if (constraintName == "CS_KorisnickoIme")
                {
                    newMessage = "UniqueUsername_Error";
                }

                else if (constraintName == "CS_Telefon")
                {
                    newMessage = "UniquePhone_Error";
                }

                else if (constraintName == "CS_Email")
                {
                    newMessage = "UniqueEmail_Error";
                }
            }

            return newMessage;
        }
    }
}