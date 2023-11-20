using System;

namespace RandomHobbyGenerator
{
    public class Program
    {
        
        static void Main(string[] args)
        {
            Random rnd= new Random();
            var randomNumber = rnd.Next(1, 6);

            Console.Write("Who would like a new hobby?");
            var name = Console.ReadLine();

            if(randomNumber == 1)
            {
                Console.WriteLine("{0}'s new hobby is saying inappropriate Dad Jokes at Funerals", name);
            } else if (randomNumber == 2)
            {
                Console.WriteLine("{0}'s new hobby is laughing at kids getting hurt IceSkating", name);
            }
            else if(randomNumber == 3)
            {
                Console.WriteLine("{0}'s newhoby is singing Nicki Minaj to Orphans", name);
            }
            else if(randomNumber == 4)
            {
                Console.WriteLine("{0}'s new hobby is baking with special ingredients", name);
            }
            else
            {
                Console.WriteLine("{0}'s new hobby is fishing in the Great Barrier Rief", name);
            }
        }

    }
}
