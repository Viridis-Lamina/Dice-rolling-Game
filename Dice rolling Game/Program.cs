using System;

namespace Dicerollinggame 
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // First thing i set up are the vairables 2 for the dice number generation and 2 for the player and enemy scoring. 
            int PlayerRandomNum;
            int EnemyRandomNum;
            int Playerpoints = 0;
            int Enemypoints = 0;

            // The code below is to establish a random number generation.
            Random random = new Random();

            // I have made an interger loop that loops 3 times to establish rounds for the game
            for (int i = 0; i < 3; i++)
            {
                Console.WriteLine("press any key to roll the dice");

                Console.ReadKey();

                // This code is establishing the value of the dice roll for the player to be between 1 and 20.
                PlayerRandomNum = random.Next(1, 21);

                Console.WriteLine("You rolled a " + PlayerRandomNum);

                // this line is used to add a slight delay and suspense to what the enemy rolls. 
                Console.WriteLine("...");
                System.Threading.Thread.Sleep(1000);

                // This code is establishing the value of the dice roll for the player to be between 1 and 20.
                EnemyRandomNum = random.Next(1, 21);

                Console.WriteLine("Enemy AI rolled a " + EnemyRandomNum);

                // Below is an if statement used to establish who one the round. The player, The Enemy or if its a draw.
                // it also establishes the values of the score vairables for the enemy so the user can keep track through the rounds.
                if (PlayerRandomNum > EnemyRandomNum)
                {
                    Playerpoints = Playerpoints + 1;
                    Console.WriteLine();
                    Console.WriteLine("The Player wins this round!");

                }

                if (EnemyRandomNum > PlayerRandomNum)
                {
                    Enemypoints = Enemypoints + 1;
                    Console.WriteLine();
                    Console.WriteLine("The Enemy wins this round!");

                }

                Console.WriteLine("Player's Score: " + Playerpoints);
                Console.WriteLine("Enemies Score :" + Enemypoints);
                Console.WriteLine();
            }

            // Below is the final If statement to establish who has one the game. It uses the scores of both enemy and player to establish which has the greater value
            // or if they are both equal it establishes that the game is a draw. The system then out puts the result for the user to see. 

            if (Playerpoints > Enemypoints)
            {
                Console.WriteLine();
                Console.WriteLine("The Player wins the game!!!!!");
            }

            else if (Enemypoints > Playerpoints)
            {
                Console.WriteLine();
                Console.WriteLine("The Enemy has won!!!");
            }
            else
            {
                Console.WriteLine();
                Console.WriteLine("The Game is a Draw!!!");
            }
            Console.ReadKey();
        }
    }
}