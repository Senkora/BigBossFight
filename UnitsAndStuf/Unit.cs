using System;

namespace BigBossFight
{
    class Unit
    {
        string name;
        int helth;
        int armor;
        int maxHelth;
        //  int special = 1;
        int damage;


        public void GenerateUnitStat(int avrHelth, int setDamage)
        {
            helth = new Random().Next(avrHelth, avrHelth + 35 * (avrHelth / 100));
            armor = new Random().Next(avrHelth / 1000, 5 * (avrHelth / 1000));
            maxHelth = helth;
            damage = setDamage;
        }

        public int getWeakDamage
        {
            get
            {
                return new Random().Next(damage - 20 * (damage / 100), damage + 20 * (damage / 100));
            }
        }

        public int getStrondDamage
        {
            get
            {
                return new Random().Next((damage) - 20 * ((damage * 2) / 100), (damage * 2) + 20 * ((damage * 2) / 100));
            }
        }

        public int Chose(int maxChoseNumber)
        {
            int chose = new Random().Next(0, maxChoseNumber);
            return chose;
        }


        public int Helth
        {
            set
            {
                helth = value;
            }
            get
            {
                return helth;
            }
        }
        public int MaxHelth
        {

            get
            {
                return maxHelth;
            }
        }

        public int Armor
        {
            get
            {
                return armor;
            }
            set
            {
                armor += value;
            }
        }

        public void GenerateName()
        {

            name = $"{BossNameStorage.FirstName[new Random().Next(0, BossNameStorage.FirstName.Length)]} " +
                   $"{BossNameStorage.SecondName[new Random().Next(0, BossNameStorage.SecondName.Length)]} " +
                   $"{BossNameStorage.LastName[new Random().Next(0, BossNameStorage.LastName.Length)]}";
        }
        public string Name
        {
            set
            {
                name = value;
            }
            get
            {
                return name;
            }
        }
    }
}
