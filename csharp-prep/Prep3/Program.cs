using System;

class Program
{
    static void Main(string[] args)
    {
        Random generator = new Random();
        int magicNumber = generator.Next(1, 101);

        // bool shouldContinue = true;
        // int userGuess = -1;
        // while (userGuess != -1){}

        // while (true) {if (magicNumber ==userGuess) break;}
        
        int userGuess= -1;
        
        while (userGuess != magicNumber){
            Console.WriteLine("What is your guess? ");
            userGuess = int.Parse(Console.ReadLine());

            if (magicNumber > userGuess){
                Console.WriteLine("Higer");
            }
            else if (magicNumber < userGuess){
                Console.WriteLine("Lower");
            }
            else {
                Console.WriteLine("You guessd it!");
            }
            

        }
    

        
    }
}