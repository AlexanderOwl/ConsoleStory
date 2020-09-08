using System;
using System.Collections.Generic;
using System.IO;
using System.Reflection;
using System.Text;
using System.Threading;

namespace QA_lecture_human
{
    class Program
    {

        static void Main(string[] args)
        {

            Console.OutputEncoding = Encoding.UTF8;
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
            Console.WriteLine("Buzova - Malo polovin dlia Peti!");
            buzova.MaloPolovin(petro);
            ConsoleSpinner spinner = new ConsoleSpinner();
            spinner.Delay = 300;
            bool exit = false;
            while (!exit)
            {
                for (int i = 0; i < 150; i++)
                {
                    spinner.Turn(displayMsg: "Playing ", sequenceCode: 5);
                }
                Console.WriteLine("Stop this shit? y/n");
                char key = Console.ReadKey(true).KeyChar;
                if (key == 'y')
                {
                    exit = true;
                    buzova.player.controls.stop();
                    Console.WriteLine("OH GOD THANKS...");
                }
                else if (key == 'n')
                {
                    
                    Console.WriteLine("Bol`noi ubludok(");
                }
                else
                {
                    Console.WriteLine("Next time razzui glaza!");
                }
            }

            ShowAll(humens);
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
    public class ConsoleSpinner
    {
        static string[,] sequence = null;

        public int Delay { get; set; } = 200;

        int totalSequences = 0;
        int counter;

        public ConsoleSpinner()
        {
            counter = 0;
            sequence = new string[,] {{"     ", "♪    ", "♪ ♪  ","♪ ♪ ♪","♪ ♪  ", "♪    ", "♫    ", "♫ ♫  ", "♫ ♫ ♫", "♫ ♫  ", "♫    "},
              // ADD YOUR OWN CREATIVE SEQUENCE HERE IF YOU LIKE
           };

            totalSequences = sequence.GetLength(0);
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="sequenceCode"> 0 | 1 | 2 |3 | 4 | 5 </param>
        public void Turn(string displayMsg = "", int sequenceCode = 0)
        {
            counter++;

            Thread.Sleep(Delay);

            sequenceCode = sequenceCode > totalSequences - 1 ? 0 : sequenceCode;

            int counterValue = counter % 10;

            string fullMessage = displayMsg + sequence[sequenceCode, counterValue];
            int msglength = fullMessage.Length;

            Console.Write(fullMessage);

            Console.SetCursorPosition(Console.CursorLeft - msglength, Console.CursorTop);
        }
    }
}
