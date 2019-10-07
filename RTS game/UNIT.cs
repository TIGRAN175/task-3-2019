using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RTS_game
{
   public abstract class UNIT


    {
        // enum for meelee and ranged unit 
        public enum unitType
        {
            meelee,
            RangedUnit,
            wizard


        }
        int wiz = (int)unitType.wizard;

        // all protected ints 
        protected int Health;

        protected int MaxHealth;

        protected int ypos;

        protected int xpos;

        protected int speed;

        protected int attack;

        protected int health;

        protected int attackRange;

        protected string unitIcon;

        protected bool isAttacking;

        protected int team;

        protected string NAME;

         

       


        public abstract void Move(int Direction);


        public abstract void Combat(UNIT attacker);
        public abstract bool IsInRange(UNIT other);
        public abstract void Death();

        public abstract override string ToString();


       
        public abstract (UNIT, int) Closest(List<UNIT> units); 
        
























    }
}
