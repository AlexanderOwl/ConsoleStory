using System;
using System.Collections.Generic;

namespace QA_lecture_human
{
    class Program
    {

        static void Main(string[] args)
        {
           

            List<Human> humens = new List<Human>();


            Vasya vasya = new Vasya();
            Petro petro = new Petro();
            Alex alex = new Alex();
            Maria maria = new Maria();
            Buzova buzova = new Buzova();
            humens.Add(vasya);
            humens.Add(petro);
            humens.Add(alex);
            humens.Add(maria);
            humens.Add(buzova);

            Console.WriteLine("CONSOLE STORY");
            Console.WriteLine("Hello! V istorii est` ");
            ShowAll(humens);
            Console.WriteLine("Buzova - Malo polovin!");
            buzova.MaloPolovin();
            Console.ReadKey();
            //Console.WriteLine("Standard parameters\n");
            //alex.ShowParams();
            //maria.ShowParams();
            //petro.ShowParams();
            //vasya.ShowParams();

            //Console.WriteLine("Parameters after sell/by\n");
            //petro.BuyItem("Apple", 2, alex);
            //petro.ShowParams();
            //alex.ShowParams();

            //maria.SellItem("Water", 3, vasya);
            //maria.ShowParams();
            //vasya.ShowParams();
        }
        static void ShowAll(List<Human> humen)
        {
            Console.WriteLine();
            foreach (var item in humen)
            {
               
                Console.Write($"{item.Name}'s params");                
                Console.Write("\t");
            }
            Console.WriteLine();
            foreach (var item in humen)
            {
                Console.Write($"Apples: {item.Apples}");
                Console.Write("\t");
            }
            Console.WriteLine();
            foreach (var item in humen)
            {
                Console.Write($"Hunger: {item.Hunger}");
                Console.Write("\t");
            }
            Console.WriteLine();
            foreach (var item in humen)
            {
                Console.Write($"Water: {item.Water}");
                Console.Write("\t");
            }
            Console.WriteLine();
            foreach (var item in humen)
            {
                Console.Write($"Thirst: {item.Thirst}");
                Console.Write("\t");
            }
            Console.WriteLine();
            foreach (var item in humen)
            {
                Console.Write($"Money: {item.Money}");
                Console.Write("\t");
            }
            Console.WriteLine();
        }
    }
}
