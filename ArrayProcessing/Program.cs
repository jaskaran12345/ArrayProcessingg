using System;

using System.Collections.Generic;

using System.Linq;

using System.Text;

using System.Threading.Tasks;

//

namespace Assignment5b

{

    class Program

    {

        static void Main(string[] args)

        {



            Program a = new Program();



            Console.WriteLine("the longest word is : ");



            Console.WriteLine(a.MyFunctionA("Ada Lovelace wrote the first algorithm designed for processing by an Analytical Engine."));



            Console.ReadLine();

        }



        public String MyFunctionA(string input)

        {

            string[] words = input.Split(' ');



            int wordArrayLength = words.Length;



            int[] wordsLength = new int[wordArrayLength];



            foreach (var word in words)

            {



            }



            string currentWord = words[0];



            string nextWord;



            for (int y = 0; y < words.Length - 1; y++)

            {

                currentWord = words[y];



                nextWord = words[y + 1];



            }



            return currentWord;

        }



    }

}
