using System;
using System.Text;
using System.Collections;
using System.Collections.Generic;

namespace guessingGame
{
    class game
    {
       
      
        public void Game()
        {
            Console.WriteLine("Hello!! Welcome to the number guessing game. Please give us your name");
            string username = Console.ReadLine();
            Console.WriteLine(username + " , welcome. Type E for Easy, M for Medium, and H for Hard");
            string level = Console.ReadLine();

          
            switch (level)
            {
                case "E":
                    List<int> lives = new List<int>();

                    Console.WriteLine("You have selected the easy level. You get 6 lives left.  Now input a random number from 1 to 10");
                    int randomNum = int.Parse(Console.ReadLine());

                    int[] livesE = new int[6];

                    // generate a random number from 1 to 10
                    Random r = new Random();
                   int newR = r.Next(1, 10);

                    if(randomNum == newR)
                    {
                        Console.WriteLine("You got it right!! You win :D");
                    }
                    else
                    {
                        lives.Add(randomNum);
                        Console.WriteLine("That was wrong. :( . You chose: " + randomNum + " , "+ "Computer chose: "   + newR);
                    }
                    break;


                case "M":
                    Console.WriteLine("You have selected the medium level. You get 5 lives in this level. Now input a random number from 1 to 20");
                    int randNum = int.Parse(Console.ReadLine());

                    // generate a random number from 1 to 20
                    Random ra = new Random();
                    int newRa = ra.Next(1, 20);

                    if (randNum == newRa)
                    {
                        Console.WriteLine("You got it right!! :D");
                    }
                    else
                    {
                        Console.WriteLine("That was wrong. :( . You chose: " + randNum + " , " + "Computer chose: " + newRa);
                    }
                    break;
              

                case "H":
                    Console.WriteLine("You have selected the hard level. Now input a random number from 1 to 50");
                    int randNumb = int.Parse(Console.ReadLine());

                    // generate a random number from 1 to 50
                    Random ran = new Random();
                    int newRan = ran.Next(1, 50);

                    if (randNumb == newRan)
                    {
                        Console.WriteLine("You got it right!! :D");
                    }
                    else
                    {
                        Console.WriteLine("That was wrong. :( . You chose: " + randNumb + " , " + "Computer chose: " + newRan);
                    }
                    break;

                default:
                    Console.WriteLine("Please input a valid letter");
                    break;
            }


        }
    }
}