using System;

namespace Dice_Game
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Choose your mode (Singleplayer, Multiplayer): ");

            string mode = Console.ReadLine().ToLower();

            if (mode == "singleplayer")
            {
                Console.Write("How many rounds?: ");

                int rounds = int.Parse(Console.ReadLine());

                SinglePlayer(rounds);
            }
            else if (mode == "multiplayer")
            {
                Console.Write("Player 1 name: ");

                string playerOne = Console.ReadLine();

                Console.Write("Player 2 name: ");

                string playerTwo = Console.ReadLine();

                Console.Write("How many rounds?: ");

                int rounds = int.Parse(Console.ReadLine());

                MultiPlayer(playerOne, playerTwo, rounds);
            }
        }

        static void SinglePlayer(int rounds)
        {
         
            int playerRandomNum;

            int enemyRandonNum;

            int playerCount = 0;

            int enemyCount = 0;

            Random randomNums = new Random();

            for (int i = 0; i < rounds; i++)
            {
                Console.WriteLine("Press ENTER to roll the dice.");

                Console.ReadKey();

                playerRandomNum = randomNums.Next(1, 7);
                Console.WriteLine($"You rolled a {playerRandomNum}.");

                enemyRandonNum = randomNums.Next(1, 7);
                Console.WriteLine($"Enemy rolled a {enemyRandonNum}.");

                if (playerRandomNum > enemyRandonNum)
                {
                    Console.WriteLine("You won!");

                    playerCount++;

                    Console.WriteLine("----------");
                }
                else if (playerRandomNum < enemyRandonNum)
                {
                    Console.WriteLine("Enemy won!");

                    enemyCount++;

                    Console.WriteLine("----------");
                }
                else if (playerRandomNum == enemyRandonNum)
                {
                    Console.WriteLine("Tie!");
                    playerCount++;
                    enemyCount++;

                    Console.WriteLine("----------");
                }
            }

            Console.WriteLine($"Final result: {playerCount}:{enemyCount} (Player:Enemy).");

            Console.ReadKey();
        }

        static void MultiPlayer(string playerOne, string playerTwo, int rounds)
        {
            
            int playerOneRandomNum;

            int playerTwoRandomNum;

            int playerOneCount = 0;

            int playerTwoCount = 0;

            Random randomNums = new Random();

            for (int i = 0; i < rounds; i++)
            {
                Console.WriteLine("Press ENTER to roll the dice.");

                Console.ReadKey();

                playerOneRandomNum = randomNums.Next(1, 7);
                Console.WriteLine($"{playerOne} rolled a {playerOneRandomNum}.");

                playerTwoRandomNum = randomNums.Next(1, 7);
                Console.WriteLine($"{playerTwo} rolled a {playerTwoRandomNum}.");

                if (playerOneRandomNum > playerTwoRandomNum)
                {
                    Console.WriteLine($"{playerOne} won!");

                    playerOneCount++;

                    Console.WriteLine("----------");
                }
                else if (playerOneRandomNum < playerTwoRandomNum)
                {
                    Console.WriteLine($"{playerTwo} won!");

                    playerTwoCount++;

                    Console.WriteLine("----------");
                }
                else if (playerOneRandomNum == playerTwoRandomNum)
                {
                    Console.WriteLine("Tie!");

                    playerOneCount++;
                    playerTwoCount++;

                    Console.WriteLine("----------");
                }
            }

            Console.WriteLine($"Final result: {playerOneCount}:{playerTwoCount} ({playerOne}:{playerTwo}).");

            Console.ReadKey();
        }
    }
}
