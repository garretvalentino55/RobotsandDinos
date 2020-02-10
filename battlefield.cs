using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace day_5
{
    class Battlefield
    {
        Fleet fleet;
        Herd herd;
        string firstBattalion;
        string secondBattalion;
        int playerOneScore;
        int playerTwoScore;
        public Battlefield()
        {
            firstBattalion = "";
            secondBattalion = "";
            fleet = new Fleet();
            herd = new Herd();
        }
        public int Diceroll(Random random)
        {
            random.Next(1, 6);
            int x = random.Next(1, 6);
            return x;
        }
        public int CompareRolls(Random shoe)
        {
            int firstBattalion = Diceroll(shoe);
            Console.WriteLine(firstBattalion);
            int secondBattalion = Diceroll(shoe);
            Console.WriteLine(secondBattalion);
            int winningPlayer = 0;
            if (firstBattalion > secondBattalion)
            {
                firstBattalion++;
            }
            if (secondBattalion > firstBattalion)
            {
                secondBattalion++;
            }
            return winningPlayer;
        }
        public void DisplayGameWinner(Random bluetang)
        {
            Console.WriteLine(firstBattalion + " to " + secondBattalion);
            if (playerOneScore > playerTwoScore)
            {
                Console.WriteLine("And the Winner is Player 1");

            }
            else if (playerOneScore < playerTwoScore)
            {
                Console.WriteLine("And the Winner is Player 2");
            }
        }
        public void RunBattle()
        {
            while (true)
            {
                Random random = new Random();
                CompareRolls(random);
                Console.ReadLine();
                DisplayGameWinner(random);
                Console.ReadLine();
            }
        }
    }
}


