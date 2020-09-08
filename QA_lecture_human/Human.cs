using System;
using System.Collections.Generic;
using System.Text;

namespace QA_lecture_human
{
    public class Human
    {
        public double WaterPrice = 2;
        public double ApplePrice = 7;

        public string Name;

        public int Apples;
        public int Water;

        public int EatApples;
        public int DrinkWater;

        public double Money;

        public int Hunger;
        public int Thirst;

        public void ShowParams()
        {
            Console.WriteLine($"{Name}'s params");
            Console.WriteLine($"Apples: {Apples}");
            Console.WriteLine($"Hunger: {Hunger}");
            Console.WriteLine($"Water: {Water}");
            Console.WriteLine($"Thirst: {Thirst}");
            Console.WriteLine($"Money: {Money}\n");
        }
        public void Eat(int amount)
        {
            if (Apples > amount)
            {
                Hunger -= Apples;
                Apples -= EatApples;
            }
            else
            {
                Console.Write($"{Name}, you must buy more apples.\n");
            }
        }
        public void Drink(int amount)
        {
            if (Water > amount)
            {
                Thirst -= DrinkWater;
                Water -= DrinkWater;
            }
            else
            {
                Console.Write($"{Name}, you must buy more water.\n");
            }
        }
        public void SellItem(string item, int amount)
        {
            if (Apples < amount || Water < amount)
            {
                Console.WriteLine($"{Name} you don't have that much of a {item}");
            }
            else
            {
                if (item == "water")
                {
                    Money += WaterPrice;
                    Water += amount;
                }
                else if (item == "apple")
                {
                    Money += ApplePrice;
                    Apples += amount;
                }
                else
                {
                    Console.WriteLine("Something went wrong");
                }
            }
        }
        public void SellItem(string item, int amount, Human ToName)
        {
            if (item == "water")
            {
                if (Water > amount)
                {
                    ToName.Money -= WaterPrice;
                    ToName.Water += amount;
                    Money += WaterPrice;
                }
                else
                {
                    Console.WriteLine($"{Name} you don't have that much of a {item}");
                }
            }
            else if (item == "apple")
            {
                if (Apples > amount)
                {
                    ToName.Money -= ApplePrice;
                    ToName.Apples += amount;
                    Money += ApplePrice;
                }
                else
                {
                    Console.WriteLine($"{Name}, you don't have that much of a {item}");
                }
            }
            else
            {
                Console.WriteLine("Something went wrong");
            }
        }
        public void BuyItem(string item, int amount)
        {
            if (item == "apple")
            {
                if (ApplePrice * amount > Money)
                {
                    Console.WriteLine($"{Name}, you must go to work to earn money to buy {item}.\n");
                }
                else
                {
                    Apples += amount;
                    Money -= ApplePrice * amount;
                    Console.WriteLine("The deal is successful.\n");
                }
            }
            else if (item == "water")
            {
                if (WaterPrice * amount > Money)
                {
                    Console.WriteLine($"{Name}, you must go to work to earn money to buy {item}.\n");
                }
                else
                {
                    Water += amount;
                    Money -= WaterPrice * amount;
                    Console.WriteLine("The deal is successful.\n");
                }
            }
            else
            {
                Console.WriteLine("Something went wrong.\n");
            }
        }
        public void BuyItem(string item, int amount, Human from)
        {
            if (item == "apple")
            {
                if (from.Apples < amount)
                {
                    Console.WriteLine($"{from.Name} don't have {item}. Try buy from others.\n");
                }
                else if(Money < ApplePrice * amount)
                {
                    Console.WriteLine($"{Name}, you must go to work to earn money to buy {item}.\n");
                }
                else
                {
                    from.Money += ApplePrice * amount;
                    Money -= ApplePrice;
                    Apples += amount;
                    Console.WriteLine("The deal is successful.\n");
                }
            }
            else if (item == "water")
            {
                if (from.Water < amount)
                {
                    Console.WriteLine($"{from.Name} don't have {item}. Try buy from others.\n");
                }
                else if (Money < WaterPrice * amount)
                {
                    Console.WriteLine($"{Name}, you must go to work to earn money to buy {item}.\n");
                }
                else
                {
                    from.Money += WaterPrice * amount;
                    Money -= WaterPrice;
                    Water += amount;
                }
            }
            else
            {
                Console.WriteLine("Something went wrong");
            }
        }
    }
}
