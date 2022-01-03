using System;

namespace MadLibsGame
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*
                This program is a simple MadLibs game, demonstrating string interpolation. String interpolation became a new feature in C# 6 and is the industry standard for joining multiple strings together.

                TODO:
                -Finish POC
                -Clean up comments/code
                -User Input validations; .ToLower for certain inputs, etc
                -Clean up user view using line breaks/ascii characters
                -Convert into Web App?
            */

            //Introduction
            Console.WriteLine("****************************** Welcome to MadLibs! ******************************");
            string storyTitle = "Title: 2021 in a Nutshell";
            Console.WriteLine(storyTitle);
            string intro = "When you are ready to begin, press any key to begin the prompts to fill in the missing words for the story.";
            Console.WriteLine(intro);
            Console.ReadLine();

            //User Inputs
            Console.WriteLine("Please enter a name.");
            string character = Console.ReadLine();

            Console.WriteLine("Please enter three adjectives, one after another. Hint: Adjectives are words that describe nouns, such as colors (blue), feelings (silly), or descriptions (soft, tall, sarcastic)");
            string adjectiveOne = Console.ReadLine();
            string adjectiveTwo = Console.ReadLine();
            string adjectiveThree = Console.ReadLine();

            Console.WriteLine("Please enter a type of animal. Ex) Donkey, Giraffe, Squirrel, etc.");
            string animal = Console.ReadLine();

            Console.WriteLine("Please enter the name of a country. Ex) Wakanda, U.S.A., etc.");
            string country = Console.ReadLine();

            Console.WriteLine("Please enter a type of food. Ex) Yams, Frozen Pizza, ham, etc.");
            string food = Console.ReadLine();

            Console.WriteLine("Please enter two nouns, one after another. Hint: A noun is a person (girl, Becky), place (park, Paris), or thing (blanket, hand).");
            string nounOne = Console.ReadLine();
            string nounTwo = Console.ReadLine();

            Console.WriteLine("Please enter a year using four digits. Ex) 1999, 1776, etc.");
            string year = Console.ReadLine();

            Console.WriteLine("Please enter a name of a Super Hero. Ex) Spider Man, Prometheus, etc.");
            string superHero = Console.ReadLine();

            Console.WriteLine("Please enter a type of fruit. Ex) Grapes, Lettuce, etc.");
            string fruit = Console.ReadLine();

            Console.WriteLine("Please enter a verb. Hint: A verb is a word that represents an action Ex) walk, sing, etc.");
            string verbOne = Console.ReadLine();

            Console.WriteLine("Please enter a name for a dessert. Ex) Ice cream, cake, etc.");
            string dessert = Console.ReadLine();



            //Variable holding story
            string story = $"This morning {character} woke up feeling {adjectiveOne}.'It is going to be a {adjectiveTwo} day!' Outside, a bunch of {animal}s were protesting to keep {food} in stores. They began to {verbOne} to the rhythm of the {nounOne}, which made all the {fruit}s very {adjectiveThree}. Concerned, {character} texted {superHero}, who flew {character} to {country} and dropped {character} in a puddle of frozen {dessert}. {character} woke up in the year {year}, in a world where {nounTwo}s ruled the world.";

            // Print the story:
            Console.WriteLine("Press any key to view the story!");
            Console.ReadLine();
            Console.WriteLine(story);
            Console.ReadLine();












        }
    }
}
