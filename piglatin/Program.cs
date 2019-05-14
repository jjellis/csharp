using System;

namespace piglatin
{
    class Program
    {
        static void Main(string[] args)
        {
            // your code goes here
            Console.WriteLine("Type words to translate to pig latin.");
            string input = Console.ReadLine();
            // leave this command at the end so your program does not close automatically
            string converedWord = TranslateWord(input);
            Console.WriteLine(converedWord);
        }

        public static string TranslateWord(string word)
        { 
            string input = Console.ReadLine();
            string latin = input.ToLower();
                char[] split = new char[latin.Length];
                split = latin.ToCharArray();
                char[] vowel = { 'a', 'e', 'i', 'o', 'u' };
            bool startwithvowel = false;
            bool endwithvowel = false;
                for (int i = 0; i < vowel.Length; i++)
                {
                    if (word.IndexOfAny(vowel)>=-1)
                    {
                    return (word + "ay");
                    }
                    string currentvowel = true;
                    if (split[0].Equals(vowel[i]))
                    {
                       input.StartsWith(vowel[i]);
                        string final = (latin + "yay");
                        break;  
                    } 
                    if (startwithvowel && endwithvowel){
                    return (word + "yay");
}
                   else
                    {
                     int firstvowlposition = word.IndexOfAny(vowel);
                    string firsthalf = word.Substring(0,firstvowlposition);
                    string secondhalf =word.Substring(firstvowlposition);
                    return(secondhalf + firsthalf + "ay");
                    }
                   
              Console.WriteLine;
            // your code goes here
            return word;
           
        }
    }
   }
 }
