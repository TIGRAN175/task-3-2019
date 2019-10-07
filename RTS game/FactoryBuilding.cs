using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Runtime.Serialization.Formatters.Binary;

namespace RTS_game
{
    [Serializable]
    public  class FactoryBuilding : building
    {


        public FactoryBuilding(int x, int y, int health, int team, int NumUnit, int producePerRound, int SpawnPoint, string symbol)
        {

            Xpos = x;
            Ypos = y;
            Health = health;
            Team = team;
            SYMBOL = symbol;
            speed = producePerRound;
        }


        public override string ToString()
        {
            return symbol + ": [" + Xpos + "," + Ypos + "] " + Health + "hp ";
        }

        public int Xpos
        {
            get { return base.XPos; }
            set { base.XPos = value; }
        }

        

        public int Ypos
        {
            get { return base.YPos; }
            set { base.YPos = value; }
        }

        public int Health
        {
            get { return base.Health; }
            set { base.Health = value; }
        }

        public int MaxHealth
        {
            get { return base.MAxhealth; }
        }

        public int Team
        {
            get { return base.TEam; }
            set { base.TEam = value; }
        }

        public string SYMBOL
        {
            get { return base.symbol; }
            set { base.symbol = value; }


        }
        

        public int Speed
        {
            get { return  base.speed; }
            set {  base.speed = value; }
        }


        public override void BuildingDeath()
        {

          
            symbol = "X";
           
        }




        public override void save()
        {
            BinaryFormatter bf = new BinaryFormatter();
            FileStream fs = new FileStream("factory building.dat", FileMode.Create, FileAccess.Write, FileShare.None);

            try
            {
                using (fs)
                {
                    bf.Serialize(fs, bf);
                    Console.WriteLine("building saved");

                }

            }

            catch (Exception c)
            {
                Console.WriteLine(c.Message);


            }
        }



        public override void readSave()
        {
            BinaryFormatter bf = new BinaryFormatter();
            FileStream fs = new FileStream("factory building.dat", FileMode.Open, FileAccess.Read, FileShare.None);

            try
            {
                using (fs)
                {
                    ResourceBuilding b = (ResourceBuilding)bf.Deserialize(fs);
                    bf.Deserialize(fs);
                    Console.WriteLine("resource building saved");
                }

            }

            catch (Exception e)
            {
                Console.WriteLine(e.Message);


            }
            Console.ReadLine();

        }

        public static explicit operator FactoryBuilding(UNIT v)
        {
            throw new NotImplementedException();
        }
    }
}
