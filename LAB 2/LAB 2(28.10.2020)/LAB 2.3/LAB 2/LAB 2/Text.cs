using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Text;

namespace LAB_2
{

     public interface IParser
    {
        Text Parse(string path);
    }

    public class TextParser : IParser
    {
        public Text Parse(string file)
        {
            return new Text();
        }

    }

    public class BinaryParser : IParser
    {
        public Text Parse(string file)
        {
            return new Text();
        }
    }
    
    

    public class Text
    {
        public List<Sentence> Sentences;

        public Text(IParser parser, string path)
        {
            parser.Parse(path);
        }

        public Text()
        {
        }
        public static Text Parse(string Text)
        {
            Text text = new Text();
            Text = DeleteTabs(Text);
            text.Sentences = ToSentence(Text);
            return text;
        }

        private static string DeleteTabs(string text)
        {
            int LengthText;
            int newLengthText;
            text = text.Replace("\n", "");
            do
            {
                LengthText = text.Length;
                for (int i = 0; i < LengthText; i++)
                {
                    if (i <= text.Length - 1 && text[i] == ' ' && text[i + 1] == ' ')
                    {
                        text = text.Remove(i + 1 , 1);
                    }
                }
                newLengthText = text.Length;
            } while (LengthText != newLengthText);

            return text;
        }

        private static List<Sentence> ToSentence(string Text)
        {
            List<Sentence> sentences = new List<Sentence>();
            string endSent = ".!?";
            int SentNumber = 0;
            string buffer;
            for (int i = 0; i < Text.Length; i++)
            {
                for (int j = 0; j < 3; j++)
                {
                    if (Text[i] == endSent[j])
                    {
                        buffer = Text.Substring(SentNumber, i - SentNumber + 1);
                        sentences.Add(Sentence.Parse(buffer));
                        SentNumber = i + 2;
                    }
                }
            }
            return sentences;
        }

        public override string ToString()
        {
            string s = "";
            foreach (Sentence sent in Sentences)
            {
                s += sent;
            }
            return s;
        }

        public string GetSortedText()
        {
            string result = "";
            string[] s = new string[Sentences.Count];
            string EndOfSent = ".!?";
            int count = 0;
            Console.WriteLine(s[0]);
            foreach (Sentence sent in Sentences)
            {
                s[count] += sent;
                count++;
            }

            s = Sort(s, count);

            foreach (var str in s)
            {
                result += str;
            }

            return result;
        }

        private string[] Sort(string[] s, int count)  
        {
            for (int i = 0; i < count - 1; i++)
            {
                if (Sentences[i].GetWordsCount() >= Sentences[i + 1].GetWordsCount())
                {
                    string buffer;
                    buffer = s[i];
                    s[i] = s[i + 1];
                    s[i + 1] = buffer;
                }
            }

            return s;
        }

        public void DelLength(int length)
        {
            foreach (Sentence sent in Sentences)
            {
                sent.DelIntorrogative(length);
            }
        }
        

        public void  DelConsonantWord(int length)
        {
            foreach (Sentence sent in Sentences)
            {
                sent.DelConsonant(length);
            }
        }

        public void InsertString(int SentenceNumber, int WordsLength, string str)
        {
            int index = 0;
            foreach (Sentence sent in Sentences)
            {
                if (index == SentenceNumber - 1)
                {
                    sent.Replace(WordsLength, str);
                }
                index++;
            }
        }

        public string ToConcordance()
        {
            string s = "";
            List<Concordance> wordList = new List<Concordance>();
            List<Concordance> wordListInSentence = new List<Concordance>();
            bool chek = true;
            int index = 1;
            foreach (Sentence sent in Sentences)
            {
                wordListInSentence = sent.ToConcordance();
                for (int i = 0; i < wordListInSentence.Count; i++)
                {
                    for (int j = 0; j < wordList.Count; j++)
                    {
                        if (wordListInSentence[i].word == wordList[j].word)
                        {
                            wordList[j].count++;
                            wordList[j].NumberOfSentences.Add(index);
                            chek = false;
                        }
                    }
                    if (chek)
                    {
                        wordListInSentence[i].NumberOfSentences.Add(index);
                        wordList.Add(wordListInSentence[i]);
                    }
                    chek = true;
                }
                index++;
                
            }
            
            wordList.Sort(delegate(Concordance element1, Concordance element2)
            {
                return element1.word.CompareTo(element2.word);
            });
            

            foreach (var word in wordList)
            {
                s += word + "\n";
            }
            return s;
        }
        
    }
}