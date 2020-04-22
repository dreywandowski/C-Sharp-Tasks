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
            // Gets player name
            Console.WriteLine("Hello!! Welcome to the number guessing game. Please give us your name");
            string username = Console.ReadLine();

            // Level type
            Console.WriteLine(username + " , welcome. Type E for Easy, M for Medium, and H for Hard");
            string level = Console.ReadLine();
            
            // random number generator
              Random r = new Random();

           
        
          
            switch (level){
            
                case "E":
                    Console.WriteLine("You have selected the easy level.");
                     
                     int guess = 1;
                      // number of tries per level
                int[] lives = new int[7];
            int count = lives.Length;

              Console.WriteLine("You got 6 lives left.  Now input a random number from 1 to 10" + count);

                     do{
           
// generate a random number from 1 to 10
                  
                   int newR = r.Next(1, 10);

                    int randomNum = int.Parse(Console.ReadLine());

                
                    if(randomNum == newR){
                    
                        Console.WriteLine("You got it right!! You win :D");
                        break;
                     }

                    else{
                        Console.WriteLine("That was wrong. :( . You chose: " + randomNum  + " , "+ "Computer chose: "   + newR + "Try again");
                       // guess++;
                    } 
         }
                    
                   while(guess < count);

                        
                    
                    break;


                case "M":
                   Console.WriteLine("You have selected the Medium level.");
                     
                     int guessM = 1;
                      // number of tries per level
                int[] livesM = new int[5];
            int countM = livesM.Length;

              Console.WriteLine("You got 4 lives left.  Now input a random number from 1 to 20");

                     do{
           
// generate a random number from 1 to 10
                  
                   int newR = r.Next(1, 20);

                    int randomNum = int.Parse(Console.ReadLine());

                
                    if(randomNum == newR){
                    
                        Console.WriteLine("You got it right!! You win :D");
                        break;
                     }

                    else{
                        Console.WriteLine("That was wrong. :( . You chose: " + randomNum  + " , "+ "Computer chose: "   + newR + " "+ "Try again");
                        //guess++;
                    } 
         }
                    
                   while(guessM < countM);


                    break;
              

                case "H":
                    Console.WriteLine("You have selected the Hard level.");
                     
                     int guessH = 1;
                      // number of tries per level
                int[] livesH = new int[4];
            int countH = livesH.Length;

              Console.WriteLine("You got 3 lives left.  Now input a random number from 1 to 50");

                     do{
           
// generate a random number from 1 to 10
                  
                   int newR = r.Next(1, 50);

                    int randomNum = int.Parse(Console.ReadLine());

                
                    if(randomNum == newR){
                    
                        Console.WriteLine("You got it right!! You win :D");
                        break;
                     }

                    else{
                        Console.WriteLine("That was wrong. :( . You chose: " + randomNum  + " , "+ "Computer chose: "   + newR);
                        //guess++;
                    } 
         }
                    
                   while(guessH < countH);
                   break;


                default:
                    Console.WriteLine("Please input a valid letter");
                    break;
            }


        }
    }
}