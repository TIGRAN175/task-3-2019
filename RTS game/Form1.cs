using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Runtime.Serialization.Formatters.Binary;
using System.IO;


namespace RTS_game
{
    public partial class Form1 : Form
    {

        private int timertracker;
        gameEngine engine;
        ResourceBuilding resourceBuilding;
        FactoryBuilding facBuilding;
        Map mp;
        
 
        public Form1()
        {
            InitializeComponent();
           
        }

        

      public void lblMAP_Click(object sender, EventArgs e)
        {


        }

        private void Form1_Load(object sender, EventArgs e)
        {
            lblRes.Visible = true;
            engine = new gameEngine(20, infotxt, Mapgrp );
            resourceBuilding = new ResourceBuilding (30, lblRes, 10,10,50,2,10,"silver",30,10);
          

        }
    //creating method for display
       

        private void curROUND_TextChanged(object sender, EventArgs e)
        {

        }

        private void Mapgrp_Enter(object sender, EventArgs e)
        {
           
        }

        private  void btnSTART_Click(object sender, EventArgs e)
        {
            rounds();
           // Update(Mapgrp);

            
            
            Map map = new Map(20, infotxt);
            map.Generate();
            map.Display(Mapgrp);
           // map.displayBuildings(Mapgrp);
            
            

          

            
            

           

            




        }

        private void btnPAUSE_Click(object sender, EventArgs e)
        {
            timer1.Enabled = false;
        }
        //int seconds = 0;
       // int minutes = 0;
       // int count;
        public void timer1_Tick(object sender, EventArgs e)
        {
            lblROUND.Text = "Round: " + engine.Round.ToString();
            if (timer1.Enabled == true)
            {
                engine.Update();


                // still refuses to update each frame 
                


            }



        }


        // trying to stop timer at a certian number so rounds can stop and as a result resorce genaration stops
        // BUT IT JUST WONT
        public void rounds()
        {

            if (timer1.Enabled == true)
            {
                engine.Update();

                if (timertracker <= 10)
                {
                    timer1.Enabled = false;
                }



            }
        }

        private void SAVEGAME_Click(object sender, EventArgs e)
        {
            resourceBuilding.save();
            mp.savemap();
           

        }

        private void infotxt_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void lblResorces_Click(object sender, EventArgs e)
        {
            
           
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {
           
        }

        private void button1_Click(object sender, EventArgs e)
        {
           
        }

        private void resourcegrp_Click(object sender, EventArgs e)
        {
           

        }

        // updates text for resources lable when clicked
        private void resourcebtn_Click(object sender, EventArgs e)
        {
            ResourceBuilding rec = new ResourceBuilding(30, lblRes,10,10,50,2,10,"silver",30,10);
            rec.makeResorces();
            
            
            rec.newdisplay(lblRes);

            
            lblRes.Text = rec.maxstock.ToString();

            
            

        }

        private void lblROUND_Click(object sender, EventArgs e)
        {

        }

        private void BTNREAD_Click(object sender, EventArgs e)
        {
            resourceBuilding.readSave();
            mp.readmap();
        }
    }
                
    }
    



