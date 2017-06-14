using System;
using System.Collections.Generic;

namespace refractor2_demo
{
    public class FootballPlayer40YardDashInfo
    {
        private List<FootballPlayer> _players = new List<FootballPlayer>();

        public void AddFootballPlayer(FootballPlayer player)
        {
            _players.Add(player);
        }
        public void PrintPlayerInfo()
        {
            PrintTitles();
            PrintPlayersWith40Avg();
        }

        private void PrintPlayersWith40Avg()
        {
            foreach (var player in _players)
            {
                Console.Write(player.GetName());
                double total40YdDashTimes = 0;
                double[] fourtyYardDashTimes = player.GetFourtyYardDashTimes();

                foreach (var fourtyYardDashTime in fourtyYardDashTimes)
                {
                    total40YdDashTimes += fourtyYardDashTime;
                }

                double avg40YdTime = total40YdDashTimes / player.GetFourtyYardDashTimes().Length;

                Console.Write("\t {0:N2}", avg40YdTime);
                Console.WriteLine();
            }
        }

        private static void PrintTitles()
        {
            Console.WriteLine("Name \t\t Avg 40 Time");
            PrintCharMultipleTimes('-', 30);
        }

        private static void PrintCharMultipleTimes(char charToPrint, int howManyTimes)
        {
            for (int i = 0; i < howManyTimes; i++)
            {
                Console.Write(charToPrint);
            }

            Console.WriteLine();
        }
    }
}
