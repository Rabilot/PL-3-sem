namespace LAB_2
{
using System;
using System.Collections.Generic;
using System.Linq;

public class Concordance
    {
        public string word;
        public int count;
        public List<int> NumberOfSentences;

        public Concordance()//string Word, int SentNumber
        {
            var s = word;
            NumberOfSentences = new List<int>();
            count = 1;
        }

        public override string ToString()
        {
            string result = "";
            result = word + "............................." + count + ":";
            foreach (var number in NumberOfSentences)
            {
                result += " " + number;
            }
            return result;
        }

        /*public string GetWord()
        {
            return word;
        }*/
    }
}