using System;
using System.Linq;

namespace WordCounter
{
    class Program
    {
        static void Main()
        {


            Console.WriteLine("UBS Technical Exercise – Fixed Income Developer position");
            Console.WriteLine("--------------------------------------------------------");
            Console.WriteLine("\n\nWrittten by Brayner Firth\n\n");

            
            do
            {
                Console.Write("\nInput: ");
                
                string sentence = Console.ReadLine();

                if (string.IsNullOrEmpty(sentence)) 
                {
                    break; // end if nothing is entered
                }

                // Simply Group by the words and exclude white spaces, blanks etc
                var wordSplit= from word in sentence.ToLower().Split( new []{' ', ',', ';', '.','"','\n','\r'},StringSplitOptions.RemoveEmptyEntries)
                          group word by word into w
                          select new { Word = w.Key, Count = w.Count() };

                
                Console.WriteLine("Output: ");
                foreach (var w in wordSplit)
                {
                    Console.WriteLine("{0} - {1}", w.Word, w.Count);
                }    


            } while (true);

        }

    }
}
