using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TU_Challenge
{
    public class MyStringImplementation
    {
        public static string BazardString(string input)
        {
            string bazard = "";
            string temp = "";
            int count = 2;

            for (int i = 0; i < input.Length; i++)
            {
                if (count == 2) { bazard += input[i]; count = 0; }
                else { temp += input[i]; }
                count++;
            }
            bazard += temp;
            return bazard;
        }

        public static bool IsNullEmptyOrWhiteSpace(string input)
        {
            if (input == null) return true;

            for (int i = 0; i < input.Length; i++)
            {
                if (input[i] != ' ') return false;
            }

            return true;
        }

        public static string MixString(string a, string b)
        {
            if (IsNullEmptyOrWhiteSpace(a) || IsNullEmptyOrWhiteSpace(b)) throw new ArgumentException("string vide");
            int lena = a.Length;
            int lenb = b.Length;
            string mix = "";
            for (int i = 0; i < lena + lenb; i++)
            {
                if (i < lena) mix += a.ElementAt(i);

                if (i < lenb) mix += b.ElementAt(i);
            }
            return mix;
        }

        public static string Reverse(string a)
        {
            string reverse = "";
            for (int i = 0; i < a.Length; i++)
            {
                reverse += a.ElementAt(a.Length - 1 - i);
            }
            return reverse;
        }

        public static string ToCesarCode(string input, int offset)
        {
            throw new NotImplementedException();
        }

        public static string ToLowerCase(string a)
        {
            string lower = "";
            for (int i = 0; i < a.Length; i++)
            {
                if (a.ElementAt(i) >= 65 && a.ElementAt(i) <= 90) lower += Convert.ToChar(a.ElementAt(i) + 32);
                else if (a.ElementAt(i) == 'É') lower += 'é';
                else lower += a.ElementAt(i);
            }
            return lower;
        }

        public static string UnBazardString(string input)
        {
            int a = input.Length/2;
            string unbazard = "";
            string temp1 = "";
            string temp2 = "";
            int count = 2;
            for (int i = 0; i < input.Length; i++)
            {
                if(i<a) { temp1+= input[i]; }
                else { temp2+= input[i]; }
            }
            for (int i = 0; i < a; i++)
            {
                unbazard += temp1[i];
                unbazard += temp2[i];
                count++;
            }
            return unbazard;
        }

        public static string Voyelles(string a)
        {
            string voyelle = "";
            char l;
            a = ToLowerCase(a);
            for (int i = 0; i < a.Length; i++)
            {
                l = a.ElementAt(i);
                if (l == 'a' || l == 'e' || l == 'i' || l == 'o' || l == 'u')
                {
                    if (!voyelle.Contains(l)) voyelle += l;
                }

            }
            return voyelle;

        }
    }
}
