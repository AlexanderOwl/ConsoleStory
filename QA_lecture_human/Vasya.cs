using System;
using System.Collections.Generic;
using System.Text;

namespace QA_lecture_human
{
    public class Vasya : Human
    {
        public Vasya()
        {
            this.Name = "Vasya";

            this.Apples = 3;
            this.Water = 4;

            this.EatApples = 3;
            this.DrinkWater = 2;

            this.Thirst = 1;
            this.Hunger = 2;

            this.Money = 100;
        }
    }
}
