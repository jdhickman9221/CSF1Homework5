using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSF1Homework5
{
    class MadLib
    {
       
            static void Main(string[] args)
            {
                Console.WriteLine("MadLib"); ;
                Console.Title = "MadLib";

                Console.WriteLine("Hi! Welcome to coding MadLib! For each prompt enter a word specified!");
                Console.ReadLine();
                Console.Clear();
                string prompt = "Enter a/an ";
                Console.WriteLine($"{prompt} Noun.\n" +
                    $"a word (other than a pronoun) used to identify any of a class of people, places,\n " +
                    $"or things ( common noun ), or to name a particular one of these ( proper noun ). This should also be present tense. ");
                string noun = Console.ReadLine();
                Console.Clear();
                Console.WriteLine($"{prompt} Verb.\n" +
                    $"a word used to describe an action, state, or occurrence, and forming the main part of the predicate of a sentence, such as hear,\n" +
                    $" become, happen. (i.e swim, run.)");
                string verb = Console.ReadLine();
                Console.Clear();
                Console.WriteLine($"{prompt} Adjective.\n" +
                    $"a word or phrase naming an attribute, added to or grammatically related to a noun to modify or describe it.");
                string adjective = Console.ReadLine();
                Console.Clear();
                Console.WriteLine($"{prompt} Noun.\n" +
                      $"a word (other than a pronoun) used to identify any of a class of people, places,\n " +
                      $"or things ( common noun ), or to name a particular one of these ( proper noun ). This should also be present tense");
                string noun2 = Console.ReadLine();
                Console.Clear();
                Console.WriteLine($"{prompt} Verb.\n" +
                    $"a word used to describe an action, state, or occurrence, and forming the main part of the predicate of a sentence, such as hear,\n" +
                    $" become, happen.\n" +
                    $" NOTE: This time ending in '-ing'");
                string verb2 = Console.ReadLine();
                Console.Clear();
                Console.WriteLine($"{prompt} Adjective.\n" +
                   $"a word or phrase naming an attribute, added to or grammatically related to a noun to modify or describe it.");
                string adjective2 = Console.ReadLine();
                Console.Clear();
                Console.WriteLine($"{prompt} Adverb.\n" +
                    $"a word or phrase that modifies or qualifies an adjective, verb, or other adverb or a word group,\n" +
                    $" expressing a relation of place, time, circumstance, manner, cause, degree, etc. (e.g., gently, quite, then, there.");
                string adverb = Console.ReadLine();
                Console.Clear();
                Console.WriteLine($"{prompt} Exclaimation.\n" +
                   "A two or three word phrase with an '!'.");
                string exclaimation = Console.ReadLine();
                Console.Clear();
                Console.WriteLine($"{prompt} City Name.\n" +
                   "Think of a City in the world or in your own country.");
                string cityName = Console.ReadLine();
                Console.Clear();
                Console.WriteLine($"{prompt} A Time of Day.\n" +
                   "(i.e. midnight, 6 a.m., Rush Hour, etc.");
                string timeOfDay = Console.ReadLine();
                Console.Clear();
                Console.WriteLine("Generating your very own Mad Lib!");
                Console.Clear();
                Console.WriteLine("COMPLETE!");
                Console.Clear();
                Console.WriteLine($"One day there was a {noun} that didn't want to {verb} anymore.\n" +
                    $"And so, like any good {adjective} {noun2} the {noun} decided to go {verb2}.\n" +
                    $"But sometimes the universe a {adjective2} mistress,\n" +
                    $"and destiny {adverb} called.\n" +
                    $"After that, the {verb} exclaimed {exclaimation}, and they heard it all the way in {cityName}!\n" +
                    $"And the {verb} vowed not to return until {timeOfDay}.");




            }//End Main()
    }//End Class
}//End Namespace
