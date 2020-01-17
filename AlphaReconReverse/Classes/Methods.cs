using AlphaReconReverse.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;

namespace AlphaReconReverse
{
    public class Methods : IMethods
    {
        public string ReverseString(string words)
        {
            char[] palabraChar = words.ToCharArray();

            StringBuilder sb = new StringBuilder();

            for (int i = palabraChar.Length-1; i > -1; i--)
            {
                sb.Append(palabraChar[i]);
            }
            return sb.ToString();
        }
    }
}
