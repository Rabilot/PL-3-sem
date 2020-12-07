using System;
using System.Collections.Generic;

/*public enum SentType
{
    Exclamation,
    Unknown
}*/

namespace LAB_2
{
    public class Sentence
    {
        public string String;
        public List<Words> words;

        public Sentence(string s)
        {
            String = s;
        }

        /*public SentType  Type
        {
            get { return SentType.Exclamation; }
        }*/

        public static Sentence Parse(string s)
        {
            Sentence sentence = new Sentence(s);
            sentence.words = ToWords(s);
            return sentence;
        }

        private static List<Words> ToWords(string s)
        {
            List<Words> Word = new List<Words>();
            string[] buffer = s.Split(' ');
            int WordIndex = 0;
            for (int i = 0; i < buffer.Length; i++)
            {
                Word.Add(new Words(buffer[i]));
            }
            return Word;
        }

        public override string ToString()
        {
            string s = "";
            foreach (Words w in words)
            {
                s += w.GetWord();
                s += ' ';
            }

            s = DelTabs(s);
            return s;
        }

        public int GetWordsCount()  
        {
            return words.Count;
        }

        public void DelLength(int length)
        {
            for (int i = 0; i <= GetWordsCount() - 1; i++)
                {
                    if (IsRepeats(i))
                    {
                        words[i].DelWordLength(length);
                    }
                }
        }

        public void DelIntorrogative(int length)
        {
            if (words[GetWordsCount() - 1].GetPunktuation() == '?')
            {
                DelLength(length);
            }
        }

        public void DelConsonant(int length)
        {
            foreach (Words word in words)
            {
                if (word.IsConsonant(word.GetChar(0)))
                {
                    word.DelWordLength(length);
                }
            }
        }

        private bool IsRepeats(int i)
        {
            bool a = false;
            for (int j = 0; j < i; j++)
            {
                if (words[i].ToString() == words[j].ToString())
                {
                    a = true;
                }
            }
            return a;
        }

        private string DelTabs(string s)
        {
            int length;
            do
            {
                length = s.Length;
                s = s.Replace(" ,", ",");
                s = s.Replace("  ", " ");
                s = s.Replace(" .", ".");
                s = s.Replace(" !", "!");
                s = s.Replace(" ?", "?");
                s = s.Replace(" :", ":");
                s = s.Replace(" ;", ";");
            } while (length != s.Length);
            return s;
        }

        public void Add(Words word)
        {
            words.Add(word);
        }

        public void Replace(int WordsLength, string substr)
        {
            List<Words> sent = new List<Words>();
            Sentence substring = new Sentence(substr);
            substring = Parse(substr);
            Console.WriteLine(words.Count);
            for (int i = 0; i < words.Count; i++)
            {
                if (words[i].GetWord().Length == WordsLength)
                {
                    Console.WriteLine(words[i]);
                    foreach (Words word in substring.words)
                    {
                        sent.Add(word);
                    }
                }
                else
                {
                    sent.Add(words[i]);
                }
                
            }

            words = sent;
        }
        

        public List<Concordance> ToConcordance()
        {
            List<Concordance> concordance = new List<Concordance>();
            string s;
            bool chek = true;
            foreach (Words w in words)
            {
                s = w.ToString();
                s = s.ToLower();
                for (int i = 0; i < concordance.Count; i++)
                {
                    if (concordance[i].word == s)
                    {
                        concordance[i].count++;
                        chek = false;
                    }
                }

                if (chek)
                {
                    Concordance buffer = new Concordance();
                    buffer.word = s;
                    buffer.count = 1;
                    concordance.Add(buffer);
                }
            }
            return concordance;
        }
        
    }
}