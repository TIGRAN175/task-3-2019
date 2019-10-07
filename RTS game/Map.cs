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
    public class Map
    {


        //Create constants in the “Map class”   (research what a constant is)

        List<UNIT> units = new List<UNIT>();
        List<FactoryBuilding> Fac = new List<FactoryBuilding>();
        Random r = new Random();
        int numUnits = 0;
        TextBox Infotxt;

        public List<UNIT> Units
        {
            get { return units; }
            set { units = value; }
        }

        public List<FactoryBuilding> fac
        {
            get { return Fac; }
            set { Fac = value; }
        }

        public Map(int n, TextBox txt)
        {
            numUnits = n;
            Infotxt = txt;
        }


        public void readmap()
        {
            BinaryFormatter bf = new BinaryFormatter();
            FileStream fs = new FileStream("map.dat", FileMode.Open, FileAccess.Read, FileShare.None);

            try
            {
                using (fs)
                {
                    ResourceBuilding b = (ResourceBuilding)bf.Deserialize(fs);
                    bf.Deserialize(fs);
                    Console.WriteLine("map saved");
                }

            }

            catch (Exception e)
            {
                Console.WriteLine(e.Message);


            }
            Console.ReadLine();

        }


        public void savemap()
        {
            BinaryFormatter bf = new BinaryFormatter();
            FileStream fs = new FileStream("map.dat", FileMode.Create, FileAccess.Write, FileShare.None);

            try
            {
                using (fs)
                {
                    bf.Serialize(fs, bf);
                    Console.WriteLine("map saved");

                }

            }

            catch (Exception c)
            {
                Console.WriteLine(c.Message);


            }
        }

        public void Generate()
        {
            for (int i = 0; i < numUnits; i++)
            {
                if (r.Next(0, 2) == 0) //Generate MeleeUnit
                {
                    MeleeUnit m = new MeleeUnit(r.Next(0, 20),
                                                r.Next(0, 20),
                                                100,
                                                50,
                                                10,
                                                10,

                                                (i % 2 == 0 ? 1 : 0),
                                                "M",
                                                  ///unit name added to constructers Uname
                                                  "knight");
                    units.Add(m);
                }
                else //Generate RangedUnit
                {
                    RangedUnit ru = new RangedUnit(r.Next(0, 20),
                                                   r.Next(0, 20),
                                                   100,
                                                   1,
                                                   20,
                                                   5,
                                                   (i % 2 == 0 ? 1 : 0),
                                                   "R",
                                                    ///unit name added to constructers Uname
                                                    "archer");
                    units.Add(ru);

                }
                FactoryBuilding fa = new FactoryBuilding(10, 10,
                                                         100,
                                                         3,
                                                         2,
                                                         3,
                                                         10,
                                                         "recource production"

                                                         );
                {
                    wizard wiz = new wizard(r.Next(20, 20),
                                              r.Next(20, 20),
                                              50, r.Next(10, 50),
                                              5,
                                              10,
                                              4,
                                              "wizard",
                                              "wiz");

                }
                // units.Add(fa); gives weird error





            }

        }



        public void displayBuildings(GroupBox groupBox)
        {
            groupBox.Controls.Clear();
            foreach (FactoryBuilding fa in fac)
            {
                Button fc = new Button();
                if (fac is FactoryBuilding)
                {
                    FactoryBuilding fact = (FactoryBuilding)fa;
                    fa.SYMBOL = "F";
                    fc.Size = new Size(20, 20);
                    fc.Location = new Point(fa.Xpos * 20, fa.Ypos * 20);
                    fc.Text = fa.SYMBOL;

                    groupBox.Controls.Add(fc);

                }
            }
        }



        public void Display(GroupBox groupBox)
        {
            groupBox.Controls.Clear();
            foreach (UNIT u in units)
            {
                Button b = new Button();
                if (u is MeleeUnit)
                {
                    MeleeUnit mu = (MeleeUnit)u;
                    mu.Symbol = "M";
                    b.Size = new Size(20, 20);
                    b.Location = new Point(mu.Xpos * 20, mu.Ypos * 20);
                    b.Text = mu.Symbol;


                    if (mu.Faction == 0)
                    {
                        b.ForeColor = Color.Red;
                    }
                    else
                    {
                        b.ForeColor = Color.Green;
                    }

                }
                else
                {
                    RangedUnit ru = (RangedUnit)u;
                    ru.Symbol = "R.";
                    b.Size = new Size(20, 20);
                    b.Location = new Point(ru.Xpos * 20, ru.Ypos * 20);
                    b.Text = ru.Symbol;

                    if (ru.Faction == 0)
                    {
                        b.ForeColor = Color.Red;
                    }
                    else
                    {
                        b.ForeColor = Color.Green;
                    }



                    {

                        b.Click += Unit_Click;
                        groupBox.Controls.Add(b);






                    }
                }

            }
        }
        public void Unit_Click(object sender, EventArgs e)
        {
            int x, y;
            Button b = (Button)sender;
            x = b.Location.X / 20;
            y = b.Location.Y / 20;
            foreach (UNIT u in units)
            {
                if (u is RangedUnit)
                {
                    RangedUnit ru = (RangedUnit)u;    // ranged unit
                    if (ru.Xpos == x && ru.Ypos == y)
                    {
                        Infotxt.Text = "R";
                        Infotxt.Text = ru.ToString();
                    }
                    else if (u is MeleeUnit)
                    {
                        MeleeUnit mu = (MeleeUnit)u;      //melee unit
                        if (mu.Xpos == x && mu.Ypos == y)
                        {
                            Infotxt.Text = "M";
                            Infotxt.Text = mu.ToString();
                        }

                    }

                    else if (u is wizard)      //wizard unit
                    {
                        wizard wiz = (wizard)u;
                        if (wiz.Xpos == x && wiz.Ypos == y)
                        {
                            Infotxt.Text = "W";
                            Infotxt.Text = wiz.ToString();
                        }
                    }


                }
            }
        }
    }
}

        
    

            
        









