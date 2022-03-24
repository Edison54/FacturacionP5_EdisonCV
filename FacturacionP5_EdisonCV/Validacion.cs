using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

using System.Globalization;
using System.Text.RegularExpressions;
namespace FacturacionP5_EdisonCV
{
    public class Validacion
    {
        private static char g_Gen_DecimalSeparator = Convert.ToChar(System.Globalization.CultureInfo.CurrentCulture.NumberFormat.NumberDecimalSeparator.ToString());

        public static bool CaracteresTexto(System.Windows.Forms.KeyPressEventArgs c, bool Mayusculas = false, bool Minisculas = false)
        {
            bool ret = false;

            if (Mayusculas)
            { c.KeyChar = char.ToUpper(c.KeyChar); }

            if (Minisculas)
            { c.KeyChar = char.ToLower(c.KeyChar); }

            if (!(char.IsLetterOrDigit(c.KeyChar)) & !(char.IsPunctuation(c.KeyChar)) & !(c.KeyChar == Convert.ToChar(Keys.Back)) & !(c.KeyChar == Convert.ToChar(Keys.Space)) & !(c.KeyChar == Convert.ToChar(Keys.Enter)))
                ret = true;
            else
                ret = false;
            return
            ret;

        }

        public static bool CaracteresNumeros(System.Windows.Forms.KeyPressEventArgs c, bool SoloEnteros = true)
        {
            //En el caso que presione enter acepta el valor y devuelve True
            int Asc = (int)Keys.Enter;

            if (c.KeyChar == Asc)
            {
                return true;
            }
            if (SoloEnteros == false)
            {
                if (c.KeyChar.ToString() == (".") | c.KeyChar.ToString() == (","))
                {
                    c.KeyChar = g_Gen_DecimalSeparator;
                    return false;
                }
            }

            if (!(char.IsDigit(c.KeyChar)) & !(c.KeyChar == Convert.ToChar(Keys.Back)) & !(c.KeyChar == Convert.ToChar(Keys.Enter)))
            { return true; }
            else
            { return false; }

        }

        public static string DateFormat(DateTime pDate, bool ISO_Format = false)
        {
            string s = string.Empty;

            try
            {
                if (ISO_Format)
                {
                    string yyyy;
                    string mm;
                    string dd;
                    int i_mm = pDate.Month;
                    int i_dd = pDate.Day;

                    if (i_mm < 10)
                    {
                        mm = "0" + i_mm.ToString();
                    }
                    else
                    {
                        mm = i_mm.ToString();
                    }

                    if (i_dd < 10)
                    {
                        dd = "0" + i_dd.ToString();
                    }
                    else
                    {
                        dd = i_dd.ToString();
                    }

                    yyyy = pDate.Year.ToString();

                    s = yyyy + mm + dd;
                }
                else
                {
                    s = string.Format("{0:dd/MMMM/yyyy}", pDate.Date);
                }
            }
            catch (Exception e)
            {
                s = e.ToString();
            }

            return s;
        }


        public static string FormatoHora(DateTime pDate)
        {
            string h;

            h = pDate.ToLongTimeString();

            return h;
        }

        //https://docs.microsoft.com/en-us/dotnet/standard/base-types/how-to-verify-that-strings-are-in-valid-email-format
        //Documentacion .net
        public static bool IsValidEmail(string email)
        {
            if (string.IsNullOrWhiteSpace(email))
                return false;

            try
            {
                // Normalize the domain
                email = Regex.Replace(email, @"(@)(.+)$", DomainMapper,
                                      RegexOptions.None, TimeSpan.FromMilliseconds(200));

                // Examines the domain part of the email and normalizes it.
                string DomainMapper(Match match)
                {
                    // Use IdnMapping class to convert Unicode domain names.
                    var idn = new IdnMapping();

                    // Pull out and process domain name (throws ArgumentException on invalid)
                    string domainName = idn.GetAscii(match.Groups[2].Value);

                    return match.Groups[1].Value + domainName;
                }
            }
            catch (RegexMatchTimeoutException e)
            {
                return false;
            }
            catch (ArgumentException e)
            {
                return false;
            }

            try
            {
                return Regex.IsMatch(email,
                    @"^[^@\s]+@[^@\s]+\.[^@\s]+$",
                    RegexOptions.IgnoreCase, TimeSpan.FromMilliseconds(250));
            }
            catch (RegexMatchTimeoutException)
            {
                return false;
            }
        }

        //
        //https://www.c-sharpcorner.com/uploadfile/jitendra1987/password-validator-in-C-Sharp/

        public static bool ValidatePassword(string passWord)
        {
            int validConditions = 0;
            foreach (char c in passWord)
            {
                if (c >= 'a' && c <= 'z')
                {
                    validConditions++;
                    break;
                }
            }
            foreach (char c in passWord)
            {
                if (c >= 'A' && c <= 'Z')
                {
                    validConditions++;
                    break;
                }
            }
            if (validConditions == 0) return false;
            foreach (char c in passWord)
            {
                if (c >= '0' && c <= '9')
                {
                    validConditions++;
                    break;
                }
            }
            if (validConditions == 1) return false;
            if (validConditions == 2)
            {
                char[] special = { '@', '#', '$', '%', '^', '&', '+', '=' };   
                if (passWord.IndexOfAny(special) == -1) return false;
            }
            return true;
        }



    }
}

