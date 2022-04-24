using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp8
{
    static class Extension
    {
        public static string Capitalize(this string text)
        {
            string newText = "";
            string result = "";
            text = text.ToLower();
            StringBuilder sb = new StringBuilder();
           
            foreach (var item in text)
            {
                newText += char.ToLower(item);
            }
            result += char.ToUpper(newText[0]);
            for (int i = 1; i < newText.Length; i++)
            {
                if (newText[i] == ' ')
                {
                    result += newText[i];
                    result += char.ToUpper(newText[i + 1]);
                    i++;
                }
                else
                {
                    result += newText[i];
                }
            }
            return result;
         }             
     }
 }

   

