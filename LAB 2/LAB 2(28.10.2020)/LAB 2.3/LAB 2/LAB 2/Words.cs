using System.Collections.Generic;

namespace LAB_2
{
    public class Words
    { 
        string characters = "";
       char Punktuation = ' ';

       public Words(string stringWord)  //progr6amming
       {
           //characters = new List<char>();
           foreach (char c in stringWord)
           {
               if (c >= 65 && c <= 90)
               {
                   characters += c;
               }
               else
               {
                   if (c >= 97 && c <= 122)
                   {
                       characters += c;
                   }
                   else
                   {
                       Punktuation = c;
                   }
               }
           }
       }

       public void DelWordLength(int length)
       {
           if (characters.Length == length)
           {
               characters = " ";
           }
       }
       
       public char GetChar(int index)
       {
           return characters[index];
       }
       public char GetPunktuation()
       {
           return Punktuation;
       }

       public bool IsConsonant(char c)
       {
           string consonant = "qwrtpsdfghjklzxcvbnmQWRTPSDFGHJKLZXCVBNM";
           foreach (var character in consonant)
           {
               if (c == character)
               {
                   return true;
               }
           }

           return false;
       }

       public override string ToString()
       {
           string s = "";
           foreach (var c in characters)
           {
               s += c;
           }
           return s;
       }
       
       public string GetWord()
       {
           string s = "";
           foreach (var c in characters)
           {
               s += c;
           }

           if (Punktuation != ' ')
           {
               s += Punktuation;
           }
           return s;
       }
       /*private bool IsFirstConsonant()
       {
           string consonant = "qwrtypsdfghjklzxcvbnmQWRTYPSDFGHJKLZXCVBNM";
           foreach (var c in consonant)
           {
               if (characters[0] == c)
               {
                   return true;
               }
           }
           return false;
       }*/
    }
}