using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSF1Homework5
{
    class FruitLoops1
    {
        static void Main(string[] args)
        {

            Console.WriteLine("Fruit Loops 1");
            Console.Title = "Fruit Loops 1";


            //Declare and initialize an array of any six fruit names (as text). Set up a FOR loop and iterate through them (displaying each value
            //in the console.)
            string[] fruits = new string[6]; //declare
            fruits[0] = "banana";
            fruits[1] = "apple";
            fruits[2] = "orange";
            fruits[3] = "grapefruit";
            fruits[4] = "strawberry";
            fruits[5] = "blueberry";


            Console.WriteLine("Here are our fruit selections!");

            string index = "";
            foreach (string fruit in fruits)
            {

                Console.WriteLine(fruit);
                //index += ".";
            }
            //Console.WriteLine(index);

        }//End Main()
    }//End Class
}//End Namespace

