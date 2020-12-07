using System;
using System.Threading;

namespace LAB_1
{
    internal class Program
    {
        public enum CardType
        {
            VISA,
            AMEX,
            MCard,
            INVALID
        }

        public static bool IsNumber(string CardNumber)
        {
            for (int i = 0; i < CardNumber.Length; i++)
            {
                if (!Char.IsDigit(CardNumber[i]))
                {
                    return false;
                }
            }
            return true;
        }

        public static bool MCardCheck(string CardNumber)
        {
            long Card = Int64.Parse(CardNumber);
            if (CardNumber.Length == 16 && Card / Math.Pow(10, 14) >= 51 && Card / Math.Pow(10, 14) <= 55)
            {
                return true;
            }

            return false;
        }

        public static bool AMEXCheck(string CardNumber)
        {
            if (CardNumber.Length == 15)
            {
                if (CardNumber.StartsWith("34") || CardNumber.StartsWith("37"))
                {
                    return true; 
                }
            }
            return false;
        }
        
        public static bool VISACheck(string CardNumber)
        {
            long Card = Int64.Parse(CardNumber);
            if (CardNumber.Length == 13 || CardNumber.Length == 16)
            {
                if (CardNumber.StartsWith("4"))
                {
                    return true;
                }
            }

            return false;
        }

        public static CardType Type(string CardNumber)
        {
            if (MCardCheck(CardNumber))
            {
                return CardType.MCard;
            }

            if (AMEXCheck(CardNumber))
            {
                return CardType.AMEX;
            }

            if (VISACheck(CardNumber))
            {
                return CardType.VISA;
            }
            return CardType.INVALID;
        }

        public static bool IsValid(string CardNumber)
        {
            long Card = Int64.Parse(CardNumber);
                long multiply;
                long sum = 0;
                for (int i = 1; i <= CardNumber.Length; i++)
                {
                    if(i % 2 != 0)
                    {
                        sum += Card % 10;
                        Card = Card / 10;
                    }
                    else
                    {
                        multiply = (Card % 10) * 2;
                        if (multiply / 10 != 0)
                        {
                     
                            sum += (multiply / 10) + (multiply % 10);
                        }
                        else
                        {
                            sum += multiply;
                        }
                        Card = Card / 10;
                    }
                }
                if(sum % 10 == 0)
                {
                    return true;
                }

                return false;
        }
        
        public static void Main(string[] args)
        {
            string CardNumber = Console.ReadLine();
            CardType CType = CardType.INVALID;
            if (IsNumber(CardNumber))
            {
                CType = Type(CardNumber);
                if (!IsValid(CardNumber))
                {
                    CType = CardType.INVALID;
                }
                switch (CType)
                {
                    case CardType.MCard: Console.WriteLine("This is MasterCard"); break;
                    case CardType.AMEX: Console.WriteLine("This is American Express"); break;
                    case CardType.VISA: Console.WriteLine("This is VISA"); break;
                    default: Console.WriteLine("This is INVALID card"); break;
                }
            }
            else Console.WriteLine("INVALID card");
        }
    }
}