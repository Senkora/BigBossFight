using System;

namespace BigBossFight
{
    class Unit
    {
        int helth;
        int armor;
        int maxHelth;
        int special = 1;



        public int GenerateUnitStat
        {
            set
            {
                helth = new Random().Next(value, value + 35 * (value / 100));
                armor = new Random().Next(value / 100, 3 * value / 100);
                maxHelth = helth;


            }

        }

        public int IncomeDamageHelth
        {
            set
            {
                helth -= value - (value * armor / 100);
                if (armor * 3 < value / 10)
                {

                    int armorLargeDestruction = new Random().Next(7, 16);
                    if (armorLargeDestruction > armor)
                    {
                        armor = 0;
                    }
                    else
                    {
                        armor -= armorLargeDestruction;
                    }

                }
                else
                {

                    int armorSmallDestruction = new Random().Next(2, 7);
                    if (armorSmallDestruction > armor)
                    {
                        armor = 0;
                    }
                    else
                    {
                        armor -= armorSmallDestruction;
                    }

                }
            }
        }
        public int IncomeHeal
        {
            set
            {
                helth += value;
            }
        }

        public int IncomeArmorRepare
        {
            set
            {
                armor += value;
            }
        }

        public int GetHelth
        {
            get
            {
                return helth;

            }
        }
        public int GetArmor
        {
            get
            {
                return armor;

            }
        }

    }
}
