using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RTS_game
{
    public class MeleeUnit : UNIT
    {

        // constructor for melee unit 
        public MeleeUnit(int x, int y, int maxH, int health, int speed, int atk, int faction, string symbol, string Uname)
        {
            Xpos = x;
            Ypos = y;
            Health = health;
            base.MaxHealth = maxH;
            Speed = speed;
            Attack = atk;
            AttackRange = 1;
            base.team = faction;
            Symbol = symbol;
            IsAttacking = false;
            IsDead = false;
            name = Uname;
        }




        private bool IsDead;

        public bool isDead
        {
            get { return isDead; }
            set { isDead = value; }
        }

        public int Xpos
        {
            get { return base.xpos; }
            set { base.xpos = value; }
        }

        public int Ypos
        {
            get { return base.ypos; }
            set { base.ypos = value; }
        }

        public int Health
        {
            get { return base.health; }
            set { base.health = value; }
        }

        public int MaxHealth
        {
            get { return base.MaxHealth; }
        }

        public int Attack
        {
            get { return base.attack; }
            set { base.attack = value; }
        }

        public int AttackRange
        {
            get { return base.attackRange; }
            set { base.attackRange = value; }
        }

        public int Speed
        {
            get { return base.speed; }
            set { base.speed = value; }
        }

        public bool IsAttacking
        {
            get { return base.isAttacking; }
            set { base.isAttacking = value; }
        }

        public int Faction
        {
            get { return base.team; }
        }

        public string Symbol
        {
            get { return base.unitIcon; }
            set { base.unitIcon = value; }
        }


        public override void Death()
        {
            unitIcon = "X";
            isDead = true;
        }



        public string name
        {
            get { return base.NAME; }
            set { base.NAME = value; }
        }


        public override void Move(int Direction)
        {
            switch (Direction)
            {
                case 0: Ypos--; break; //North
                case 1: Xpos++; break; //East
                case 2: Ypos++; break; //South
                case 3: Xpos--; break; //West
                default: break;
            }
        }

        public override void Combat(UNIT attacker)
        {

            if (attacker is MeleeUnit)
            {
                Health = Health - ((MeleeUnit)attacker).Attack;
            }
            else if (attacker is RangedUnit)
            {

                RangedUnit ru = (RangedUnit)attacker;
                Health = Health - (ru.Attack - ru.AttackRange);

            }

            if (Health <= 0)
            {
                Death(); //Death!
            }



        }

        public override bool IsInRange(UNIT other)
        {
            int distance = 0;
            int otherX = 0;
            int otherY = 0;

            if (other is MeleeUnit)
            {
                otherX = ((MeleeUnit)other).Xpos;
                otherY = ((MeleeUnit)other).Ypos;
            }
            else if (other is RangedUnit)
            {

                otherX = ((RangedUnit)other).Xpos;
                otherY = ((RangedUnit)other).Ypos;

            }

            distance = Math.Abs(Xpos - otherX) + Math.Abs(Ypos - otherY);

            if (distance <= AttackRange)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        public override string ToString()
        {
            string temp = "";
            temp += "Melee: ";
            temp += "{" + Symbol + "}";
            temp += "{" + Xpos + "," + Ypos + "}";
            temp += Health + ", " + Attack + ", " + AttackRange + ", " + Speed;
            temp += (IsDead ? "Dead!" : "Alive!");
            return temp;
        }
        public override (UNIT, int) Closest(List<UNIT> units)
        {
            int shortest = 100;
            UNIT closest = this;
            //Closest Unit and Distance                    
            foreach (UNIT u in units)
            {
                if (u is MeleeUnit)
                {
                    MeleeUnit otherMu = (MeleeUnit)u;
                    int distance = Math.Abs(base.xpos - otherMu.Ypos)
                               + Math.Abs(base.ypos - otherMu.Ypos);
                    if (distance < shortest)
                    {
                        shortest = distance;
                        closest = otherMu;
                    }
                }
                else if (u is RangedUnit)
                {
                    RangedUnit otherRu = (RangedUnit)u;
                    int distance = Math.Abs(base.xpos - otherRu.Xpos)
                               + Math.Abs(base.ypos - otherRu.Ypos);
                    if (distance < shortest)
                    {
                        shortest = distance;
                        closest = otherRu;
                    }
                }
                else if (u is wizard)
                {
                    wizard otherwi = (wizard)u;
                    int distance = Math.Abs(base.xpos - otherwi.Xpos)
                        + Math.Abs(base.ypos - otherwi.Ypos);
                    if (distance < shortest)
                    {
                        shortest = distance;
                        closest = otherwi;
                    }
                }

            }
            return (closest, shortest);
        }
    }
}


    