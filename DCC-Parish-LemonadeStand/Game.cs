﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DCC_Parish_LemonadeStand
{
    class Game
    {
        private Random rand;

        private Player player = new Player();
        private List<int> numberGameDays = new List<int> { 7, 14, 30 };
        
        private string gameInstructions = "Instruction for game in beginning";
        private int numberDaysLength;
        private List<Day> gameDays = new List<Day>();
        private Weather weather;


        public Random Rand { get{ return rand; } set { rand = value ;} }

        public string GameInstructions { get { return gameInstructions; } set { gameInstructions = value; } }

        public List<int> NumberGameDays { get { return numberGameDays; } set { numberGameDays = value;} }

        public int NumberDaysLength { get { return numberDaysLength; } set{ numberDaysLength = value;} }

        public List<Day> GameDays { get { return gameDays; } set {  gameDays = value; } }


        public Player Player { get { return player; } }
        public Weather Weather { get { return weather; } }

        public Game()
        {
            rand = new Random();
            SetupGame();
            RunGame();
        }

        public void SetupGame()
        {
            UserInterface.OutputText(GameInstructions);
            player.RetrievePlayerName();
            RetrieveNumDayInput();
            weather = new Weather(NumberDaysLength,Rand);
            CreateGameDays(NumberDaysLength);
            Store.InitalizeStoreIngredients();
            
        }
        public void RunGame()
        {
            TraverseDay();
        }
        private void RetrieveNumDayInput()
        {
            UserInterface.DisplayDayNum(numberGameDays);
            NumberDaysLength = Int32.Parse(UserInterface.GetInput());
        }

        private void CreateGameDays(int numDaysLength)
        {
            for (int i = 0; i < numDaysLength; i++)
            {
                GameDays.Add(new Day(Rand,Player,Weather));
            }
        }
        public void TraverseDay()
        {
            for (int i = 0; i < GameDays.Count; i++)
            {
                GameDays[i].RunDay(i);
                //Console.WriteLine(i);
            }
        }


    }
}
