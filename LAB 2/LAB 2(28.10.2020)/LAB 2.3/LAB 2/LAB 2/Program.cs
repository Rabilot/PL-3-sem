using System;
using System.IO;

namespace LAB_2
{
    internal class Program
    {
        static Text ReadTextFromFile(string Path)
        {
            string textString = File.ReadAllText(Path);
            return Text.Parse(textString);
        }
        
        
        public static void Main(string[] args)
        {
            string Path = "C:\\Users\\rabil\\Desktop\\University\\3 sem\\PL\\TestText.txt";
            Text text = ReadTextFromFile(Path);
            
            /////////////////////////// TASK 1.1
            Console.Write("\n\n\nTASK 1.1");
            
            
            Console.WriteLine(text.GetSortedText());
            
            
            /////////////////////////// TASK 1.2
            Console.Write("\n\n\nTASK 1.2\n");
                
            
            Console.WriteLine("Введите длину: ");
            int length = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine(length);
            text.DelLength(length);
            Console.WriteLine(text);

            ////////////////////////// TASK 1.3
            Console.Write("\n\n\nTASK 1.3\n");
            
            
            Console.WriteLine("Введите длину: ");
            int length2 = Convert.ToInt32(Console.ReadLine());
            text.DelConsonantWord(length2);
            Console.WriteLine(text);
            
            /////////////////////////  TASK 1.4
            Console.Write("\n\n\nTASK 1.4\n");
            
            
            Console.WriteLine("Введите номер предложения: ");
            int SentenceNumber = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Введите длину заменяемого слова: ");
            int WordsLength = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Введите подстроку: ");
            Console.WriteLine(text);
            string str = Console.ReadLine();
            text.InsertString(SentenceNumber, WordsLength, str);
            Console.WriteLine(text);
            
            
            /////////////////////////  TASK 2.0
            Console.Write("\n\n\nTASK 2.0\n");
            
            
            Console.WriteLine(text.ToConcordance());

        }
    }
}