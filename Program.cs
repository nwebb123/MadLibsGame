using System;
using System.Globalization;

namespace MadLibsGame
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*
                This program is a simple MadLibs game, demonstrating string interpolation. String interpolation became a new feature in C# 6 and is the industry standard for joining multiple strings together.

                TODO:
                -Finish POC CHECK
                -Clean up comments/code CHECK
                -User Input validations; .ToLower for certain inputs, etc.  CHECK, need to figure out .ToTitleCase method for further validation CHECK
                -Clean up user view using line breaks/ascii characters CHECK
                -Add loop to make gameplay repeatable?
                -Convert into Web App?
            */
            
            
            // Creates a TextInfo based on the "en-US" culture.
            TextInfo myTI = new CultureInfo("en-US", false).TextInfo;
            
            
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
            string characterCapitalized = myTI.ToTitleCase(character);


            Console.WriteLine("Please enter three adjectives, one after another. Hint: Adjectives are words that describe nouns, such as colors (blue), feelings (silly), or descriptions (soft, tall, sarcastic)");
            string adjectiveOne = Console.ReadLine();
            string adjectiveTwo = Console.ReadLine();
            string adjectiveThree = Console.ReadLine();

            Console.WriteLine("Please enter the name of a pet. Ex) Mr.Floofy, goldfish, etc.");
            string pet = Console.ReadLine();

            Console.WriteLine("Please enter a type of animal. Ex) Donkey, Giraffe, Squirrel, etc.");
            string animal = Console.ReadLine();

            Console.WriteLine("Please enter the name of a country. Ex) Wakanda, U.S.A., etc.");
            string country = Console.ReadLine();
            string countryCapitalized = myTI.ToTitleCase(country);

            Console.WriteLine("Please enter a type of food. Ex) Yams, Frozen Pizza, ham, etc.");
            string food = Console.ReadLine();

            Console.WriteLine("Please enter two nouns, one after another. Hint: A noun is a person (girl, Becky), place (park, Paris), or thing (blanket, hand).");
            string nounOne = Console.ReadLine();
            string nounTwo = Console.ReadLine();

            Console.WriteLine("Please enter a year using four digits. Ex) 1999, 1776, etc.");
            string year = Console.ReadLine();

            Console.WriteLine("Please enter a name of a Super Hero. Ex) Spider Man, Prometheus, etc.");
            string superHero = Console.ReadLine();
            string superHeroCapitalized = myTI.ToTitleCase(superHero);

            Console.WriteLine("Please enter a type of fruit. Ex) Grapes, Lettuce, etc.");
            string fruit = Console.ReadLine();

            Console.WriteLine("Please enter a verb. Hint: A verb is a word that represents an action Ex) walk, sing, etc.");
            string verbOne = Console.ReadLine();

            Console.WriteLine("Please enter a name for a dessert. Ex) Ice cream, cake, etc.");
            string dessert = Console.ReadLine();

           


            //Variable holding story
            string story = $"This morning {characterCapitalized} woke up feeling {adjectiveOne.ToLower()}. \"It is going to be a {adjectiveTwo.ToLower()} day!\" {characterCapitalized} said to his pet {pet}.\nOutside, a bunch of {animal.ToLower()}s were protesting to keep {food.ToLower()} in stores.\nThey began to {verbOne.ToLower()} to the rhythm of the {nounOne.ToLower()}, which made all the {fruit.ToLower()}s very {adjectiveThree.ToLower()}.\nConcerned, {characterCapitalized} texted {superHeroCapitalized}, who flew {characterCapitalized} to {countryCapitalized} and dropped {characterCapitalized} in a puddle of frozen {dessert}.\n{characterCapitalized} woke up in the year {year}, in a world where {nounTwo.ToLower()}s ruled the world.";

            // Print the story:
            Console.WriteLine("Press any key to view the story!");
            Console.ReadLine();
            Console.WriteLine(story);
            Console.ReadLine();

        }
    }
}
