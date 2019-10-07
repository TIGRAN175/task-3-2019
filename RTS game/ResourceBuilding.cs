using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Drawing;
using System.IO;
using System.Runtime.Serialization.Formatters.Binary;

namespace RTS_game
{
    [Serializable]
    public class ResourceBuilding : building
    {


        List<building> buildings = new List<building>();

        Label lblRes;
        string resourcepool;
        int Maxstock; //connected to a get set which then connects to our main display
        protected int remainingRES;
        protected int genaratedRES;
        protected String ResourceType;
        

        public ResourceBuilding(int max, Label txt2, int x, int y, int health, int team, int producePerTick, string resourcetype, int RemainingRES
            , int GenaratedRES)
        {
            int Maxstock = max;
            lblRes = txt2;

            Xpos = x;
            Ypos = y;
            Health = health;
            Team = team;
            resourcetype = ResourceType;
            genaratedRES = GenaratedRES;
            remainingRES = RemainingRES;
            SYMBOL = symbol;
            speed = producePerTick;
        }


        public override string  ToString()
        {
            return symbol + ": [" + XPos + "," + Ypos + "] " + Health + "hp " + ResourceType + genaratedRES + " per second " + remainingRES + "resources remaining" ;
        }
        
      
       


        public int CheckResorces()
        {
            String unit = "meleeUnit";

            int meleeUprice = 10;

            int RangedUprice = 20;

            remainingRES += genaratedRES;


            if (unit == "meleeUnit")
            {
                remainingRES -= meleeUprice;
            }
            else
            {
                remainingRES -= RangedUprice;
            }
            return remainingRES;
        }


        public void makeResorces()
        {


            for (int i = 0; i <= 30; i++)
            {

                remainingRES += i;

            }

            Maxstock = remainingRES;


            resourcepool = Maxstock.ToString();
            {
            }
            

        }


        public void newdisplay(Label lable)
        {
            lable.Controls.Clear();
            foreach (building b in buildings)
            {
                ResourceBuilding rb = (ResourceBuilding)b;
                rb.makeResorces();


                if (rb.Maxstock < 0)
                {
                    lblRes.Text = resourcepool.ToString();
                    lblRes.Text = rb.ToString();
                }


            }
        }



        public void displayRecorces(GroupBox groupBox)
        {

            makeResorces();



        }







        public int maxstock
        {
            get { return Maxstock; }
            set { Maxstock = value; }
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
            get { return base.speed; }
            set { base.speed = value; }
        }




        public override void BuildingDeath()
        {

            // if ()
            symbol = "X";
            //isDead = true;
        }


        public void Display(Label lable)
        {

        }



        public override void save()
        {
            BinaryFormatter bf = new BinaryFormatter();
            FileStream fs = new FileStream("resource building.dat", FileMode.Create, FileAccess.Write, FileShare.None);

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
            FileStream fs = new FileStream("resource building.dat", FileMode.Open, FileAccess.Read, FileShare.None);

            try
            {
                using (fs)
                {
                    ResourceBuilding b = (ResourceBuilding)bf.Deserialize(fs);
                    bf.Deserialize(fs);
                    Console.WriteLine("resource building saved" );
                }

            }

            catch (Exception e)
            {
                Console.WriteLine(e.Message);


            }
            Console.ReadLine();

        }

    }
}

        
