using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RTS_game
{
     public abstract  class building
    {


        // all protected values for building 
        protected int XPos;
        protected int YPos;
        protected int Health;
        protected int MAxhealth;
        protected int TEam;
        protected string symbol;
        protected int speed;


        public abstract override string ToString();
        public abstract void save();
        public abstract void readSave();







        // primary method for death of building pass to recorce building in future
        public abstract void BuildingDeath();





       









    }
}
