using System;

namespace Algorytm16
{
    public class Program
    {
        static int LengthMod { get; set; }
        static void Main(string[] args)
        {

            string word = "ddodod";
            string wordBeginning = AddAtTheBeginning(word);
            LengthMod = wordBeginning.Length;
            string wordEnd = AddAtTheEnd(word);
            if(wordBeginning.Length > wordEnd.Length)
            {
                Console.WriteLine(wordBeginning);
            }
            else if(wordEnd.Length == wordBeginning.Length)
            {
                Console.WriteLine(string.Compare(wordBeginning, wordEnd) < 0 ? wordBeginning : wordEnd);
            }
            else
            {
                Console.WriteLine(wordEnd);
            }
            
            
            Console.WriteLine("Hello World!");
        }

        static string AddAtTheBeginning(string word)
        {
            int lenght = word.Length - 1;
            for (int i = lenght, counter = lenght; i > 0 && counter > 0; i--, counter--)
            {
                if(word[lenght - counter] != word[i])
                {
                    int a = lenght - counter;
                    word = word[..a] + word[i] + word[a..];
                    i++;
                }
            }
            return word;
        }

        static string AddAtTheEnd(string word)
        {
            int lenght = word.Length - 1;
            int lenghtMod = lenght;
            int w = 1;
            for (int i = 0, counter = 0; i < lenght && counter < lenght; i++, counter++)
            {
                if (LengthMod < lenghtMod) return "";
                if (word[lenght - counter] != word[i])
                {
                    lenghtMod++;
                    int a = lenghtMod - i;
                    word = word[..a] + word[i] + word[a..];
                    counter--;
                }
            }
            return word;
        }
    }
}
