using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RTS_game
{
    public class gameEngine
    {
        Map map;
        private int round;
        Random r = new Random();
        GroupBox grpMap;

        public int Round
        {
            get { return round; }
        }

        public gameEngine(int numUnits, TextBox txtInfo, GroupBox gMap)
        {
            grpMap = gMap;
            map = new Map(numUnits, txtInfo);
            map.Generate();
            map.Display(grpMap);

            round = 1;
        }

        public void Update()
        {
            for (int i = 0; i < map.Units.Count; i++)
            {
                if (map.Units[i] is MeleeUnit)
                {
                    MeleeUnit mu = (MeleeUnit)map.Units[i];
                    if (mu.Health <= mu.MaxHealth * 0.25) // Running Away
                    {
                        mu.Move(r.Next(0, 4));
                    }
                    else
                    {
                        (UNIT closest, int distanceTo) = mu.Closest(map.Units);

                        //Check In Range
                        if (distanceTo <= mu.AttackRange)
                        {
                            mu.IsAttacking = true;
                            mu.Combat(closest);
                        }
                        else //Move Towards
                        {
                            if (closest is MeleeUnit)
                            {
                                MeleeUnit closestMu = (MeleeUnit)closest;
                                if (mu.Xpos > closestMu.Xpos) //North
                                {
                                    mu.Move(0);
                                }
                                else if (mu.Xpos < closestMu.Xpos) //South
                                {
                                    mu.Move(2);
                                }
                                else if (mu.Ypos > closestMu.Ypos) //West
                                {
                                    mu.Move(3);
                                }
                                else if (mu.Ypos < closestMu.Ypos) //East
                                {
                                    mu.Move(1);
                                }
                            }
                            else if (closest is RangedUnit)
                            {
                                RangedUnit closestRu = (RangedUnit)closest;
                                if (mu.Xpos > closestRu.Xpos) //North
                                {
                                    mu.Move(0);
                                }
                                else if (mu.Xpos < closestRu.Xpos) //South
                                {
                                    mu.Move(2);                             ///change order
                                }
                                else if (mu.Ypos > closestRu.Ypos) //West
                                {
                                    mu.Move(3);
                                }
                                else if (mu.Ypos < closestRu.Ypos) //East
                                {
                                    mu.Move(1);
                                }
                            }
                        }

                    }
                }
                else if (map.Units[i] is RangedUnit)
                {
                    RangedUnit ru = (RangedUnit)map.Units[i];
                    /* if (ru.Health <= ru.MaxHealth * 0.25) // Running Away is commented out to make for a more interesting battle - and some insta-deaths
                     {
                         ru.Move(r.Next(0, 4));
                     }
                     else
                     {*/
                    (UNIT closest, int distanceTo) = ru.Closest(map.Units);

                    //Check In Range
                    if (distanceTo <= ru.AttackRange)
                    {
                        ru.IsAttacking = true;
                        ru.Combat(closest);
                    }
                    else //Move Towards
                    {
                        if (closest is MeleeUnit)
                        {
                            MeleeUnit closestMu = (MeleeUnit)closest;
                            if (ru.Xpos > closestMu.Xpos) //North
                            {
                                ru.Move(0);
                            }
                            else if (ru.Xpos < closestMu.Xpos) //South
                            {
                                ru.Move(2);
                            }
                            else if (ru.Ypos > closestMu.Ypos) //West
                            {
                                ru.Move(3);
                            }
                            else if (ru.Ypos < closestMu.Ypos) //East
                            {
                                ru.Move(1);
                            }
                        }

                        


                        else if (closest is RangedUnit)
                        {
                            RangedUnit closestRu = (RangedUnit)closest;
                            if (ru.Xpos > closestRu.Xpos) //North
                            {
                                ru.Move(0);
                            }
                            else if (ru.Xpos < closestRu.Xpos) //South
                            {
                                ru.Move(2);
                            }
                            else if (ru.Ypos > closestRu.Ypos) //West
                            {
                                ru.Move(3);
                            }
                            else if (ru.Ypos < closestRu.Ypos) //East
                            {
                                ru.Move(1);
                            }
                        }
                    }

                    //  }

                }
            }
            map.Display(grpMap);
            round++;
        }

        

    }
}

