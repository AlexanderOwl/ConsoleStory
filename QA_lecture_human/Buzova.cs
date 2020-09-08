using System;
using System.Collections.Generic;
using System.Text;
using System.IO;
using System.Media;
using WMPLib;
namespace QA_lecture_human
{
    class Buzova : Human
    {
        public WindowsMediaPlayer player;
        public Buzova()
        {
            this.Name = "Buzova";

            this.Apples = 999;
            this.Water = 999;

            this.EatApples = 5;
            this.DrinkWater = 3;

            this.Thirst = 9;
            this.Hunger = 9;

            this.Money = 100;
        }

        public void MaloPolovin(Human human)
        {
            
            player = new WindowsMediaPlayer();
            byte[] b = Properties.Resources.buzovaaaa;
            FileInfo fileInfo = new FileInfo("song.mp3");
            FileStream fs = fileInfo.OpenWrite();
            fs.Write(b, 0, b.Length);
            fs.Close();
            player.URL = fileInfo.Name;
            player.controls.play();
            human.Money -= 100;
            this.Money += 100;
        }
    }
}
