using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleCLIGame
{
    public class Levels
    {
        int coin = 100;
        int healthPotion = 0;
        string horse = "";
        int key = 0;
        int health = 100;

        public void start()
        {
            level1();
        }

        public void level1()
        {
            Console.WriteLine("Welcome to level 1...");
            Console.WriteLine("You enter an area full of trees and paths to follow,\nThere are three paths... East, West, North...\n" +
                "You have to select one of the paths\n");
            string input = Console.ReadLine().Substring(0, 1).ToLower();

            switch (input)
            {
                case "e":
                case "w":
                    Console.WriteLine("This path ends... and you turn around and go to the path that goes north..\n");
                    break;
                case "n":
                    Console.WriteLine("You follow the path and get to a river.\n");
                    break;
            }

            Console.WriteLine("You are stopped by an orc before you cross the bridge.. \n" +
                "Do you Attack, Run, Talk?\n");
            string input1 = Console.ReadLine().Substring(0, 1).ToLower();

            switch (input1)
            {
                case "a":
                    Console.WriteLine("You try to attack the orc, but he strikes you to the floor before taking 5 coin out of your pocket.\n" +
                        "and loosing 20 health");
                    coin -= 5;
                    health -= 20;
                    break;
                case "r":
                    Console.WriteLine("You quickly run past the orc and cross the bridge.\n");
                    break;
                case "t":
                    Console.WriteLine("You talk to the ORC, he gives you a health potion and tells you where the nearest village is.\n");
                    healthPotion += 1;
                    break;
            }

            Console.WriteLine("Once you cross the bridge and follow the road to the nearest town, \n" +
                "you are approached by a common street begger.\nShe begs you for coin. Do you give her?\nYes? No?\n");
            string input2 = Console.ReadLine().Substring(0, 1).ToLower();

            switch (input2)
            {
                case "y":
                    Console.WriteLine("She thanks you kindly and reveals that she is not a begger, but a witch.\n" +
                        "She decides to perform a magic spell to double your coin\nand wishes you well.\n");
                    coin *= 2;
                    health += 20;
                    break;
                case "n":
                    Console.WriteLine("She runs up to you and holds you at knife point, before stabbing you.\nYou lose 10 coin and 30 health.\n");
                    coin -= 10;
                    health -= 30;
                    break;
            }

            Console.WriteLine("After your encounter, you find the nearest bar and enter.\n" +
                "You walk straight up to the counter and look at whats to order..." +
                "\nVodka : 5 coin\nBeer : 2 coin\nWater : 1 coin\n");
            string input3 = Console.ReadLine().Substring(0, 1).ToLower();

            switch (input3)
            {
                case "v":
                    Console.WriteLine("You have a strong drink and feel a little light headed.\n" +
                        "The bartender chases you out.\n");
                    coin -= 5;
                    health -= 5;
                    break;
                case "b":
                    Console.WriteLine("You enjoy your ice cold beer and decide to leave.\n");
                    coin -= 2;
                    health -= 2;
                    break;
                case "w":
                    Console.WriteLine("You take the healthy route and decide to have water before leaving.\n");
                    coin -= 1;
                    health += 10;
                    break;
            }


            Console.WriteLine("Once you leave the bar you get stopped by a stranger.. \n" +
                "He asks for your help with directions. \nDo you help him? Yes? No?\n");
            string input4 = Console.ReadLine().Substring(0, 1).ToLower();

            switch (input4)
            {
                case "y":
                    Console.WriteLine("He robs you of 20 coin and punches you in the face then runs away before you can do anything.\n");
                    coin -= 20;
                    health -= 10;
                    break;
                case "n":
                    Console.WriteLine("You ignore his request and continue on the path... \n" +
                        "As you walk you see a shiny glisten on the ground and pick up a bag containing 20 coin.\n");
                    coin += 20;
                    break;
            }


            Console.WriteLine("You look through town for a horse,\n" +
                "and finally find a stable where you are able to purchase one.\n" +
                "They have only the following in stock:\n" +
                "Purebreed : 30 coin\nCommonbreed : 10 coin\n");
            string input5 = Console.ReadLine().Substring(0, 1).ToLower();

            switch (input5)
            {
                case "p":
                    Console.WriteLine("Good choice, this horse runs fast and needs little water and food.\n");
                    horse = "Purebreed";
                    coin -= 30;
                    break;
                case "c":
                    Console.WriteLine("Hmmmm, this horse needs lots of food and water. \n" +
                        "You will need to stop often to attend to your horses needs.\n");
                    horse = "Commonbreed";
                    coin -= 10;
                    break;
            }


            Console.WriteLine("You mount your horse and ride out of town. \nYou are being chased the moment you leave town.\nDo you flee or confront?\n");
            string input6 = Console.ReadLine().Substring(0, 1).ToLower();

            switch (input6)
            {
                case "f":
                    Console.WriteLine("You quickly lose the tail and make your way down the road and stop to feed your horse\n" +
                        "When you are feeding your horse you notice a bag and search it. \nYou find 20 coin.\n");
                    coin += 20;
                    break;
                case "c":
                    Console.WriteLine("You stop your horse and confront the person following you.\n" +
                        "He draws a sword, stabs you and robs you of 15 coin and your horse.\n");
                    coin -= 15;
                    health -= 50;
                    horse = "Stolen";
                    break;
            }


            Console.WriteLine("You ride your horse into a small abandoned village..\n" +
                "There is nothing but fog and the burning remains of what was once a prime area.\n" +
                "Do you climb off your horse and decide to search?\nOr you choose to ride out this town onto the next level?\n" +
                "Search? Ride?\n");
            string input7 = Console.ReadLine().Substring(0,1).ToLower();

            switch (input7)
            {
                case "s":
                    Console.WriteLine("From an abandoned building, there comes a group of thieves.\n" +
                        "One by one they appear from the building and attack you.\nThey kill you and your horse.\n");
                    coin = 0;
                    health = 0;
                    horse = "Killed";
                    break;
                case "r":
                    Console.WriteLine("You climb back onto your horse and ride onto into the sunset to the next level.\n\n");
                    Console.WriteLine("You completed level 1 with... \n{0} Coin\n{1} Health Potion\n{2} Horse\n\n\n\n", coin, healthPotion, horse);
                    break;
            }

            if (coin == 0 || health == 0 || horse == "Killed")
            {
                Console.WriteLine("You lose!\n");
                Console.WriteLine("----------------------------------------------------------------------------------------\n" +
                    "\t\t\t\tDeath From Poverty or Killed Horse....... :(\n\n");
                Console.WriteLine("{0} Health\n{1} Coin\n{2} Health Potion\n{3} Horse\n\n\n\n", health, coin, healthPotion, horse);
                Console.WriteLine("Start Over?\nYes? No?\n");
                string input8 = Console.ReadLine().Substring(0, 1).ToLower();

                switch (input8)
                {
                    case "y":
                        start();
                        break;
                    case "n":
                        Console.WriteLine("Thank you for playing.");
                        break;
                }
            }
            else
            {
                level2();
            }
        }

        public void level2()
        {
            Console.WriteLine("Welcome to level 2...");
            Console.WriteLine("You find yourself in a cave. There is a door but no windows. What do you do?\n" +
                "Open door? Search room?");
            string input = Console.ReadLine().Substring(0, 1).ToLower();

            if (key == 0)
            {
                switch (input)
                {
                    case "o":
                        Console.WriteLine("The door is locked\n");
                        level2();
                        break;
                    case "s":
                        Console.WriteLine("You find a key\n");
                        key += 1;
                        break;
                }
            }
            else
            {
                Console.WriteLine("You use the key to open the door.\n");
            }


            Console.WriteLine("You run out the cave entrance and get stopped by a peasant who was trying to break into the cave.\n" +
                "Do you stop to ask him what he is looking for? or do you continue to run?\n" +
                "Stop? Run?");
            string input1 = Console.ReadLine().Substring(0, 1).ToLower();

            switch (input1)
            {
                case "r":
                    Console.WriteLine("You run past him and he trips you. You fall and drop 5 coin then get up and run away.\n");
                    coin -= 5;
                    break;
                case "s":
                    Console.WriteLine("You stop to talk to him, he tells you he saw the people who put you in the cave and says\n" +
                        "he was trying to break through the door to let you out. He then gives you 10 coin and wishes you well.\n");
                    coin += 10;
                    break;
            }

            // TODO: Add more story line here



            if (coin == 0 || health == 0 || horse == "Killed")
            {
                Console.WriteLine("You lose!\n");
                Console.WriteLine("----------------------------------------------------------------------------------------\n" +
                    "\t\t\t\tDeath From Poverty or Killed Horse....... :(\n\n");
                Console.WriteLine("{0} Health\n{1} Coin\n{2} Health Potion\n{3} Horse\n\n\n\n", health, coin, healthPotion, horse);
                Console.WriteLine("Start Over?\nYes? No?\n");
                string input8 = Console.ReadLine().Substring(0, 1).ToLower();

                switch (input8)
                {
                    case "y":
                        start();
                        break;
                    case "n":
                        Console.WriteLine("Thank you for playing.");
                        break;
                }
            }
            else
            {
                level3();
            }
        }

        public void level3()
        {
            // TODO: Add more story line here
        }
    }
}
