using System;

namespace BigBossFight.UnitsAndStaf
{
    class Actions
    {

        public static void DamageHealth(Unit target, int damage)
        {
            //подружить с анонсером
            Anonser.SayDamage(damage - (target.Armor *  damage/ 100), target);
            target.Helth -= (damage - (target.Armor * damage / 100));
        }
        public static void DamageArmor(Unit unit)
        {

        }

        public static void Heal(Unit target)
        {
            //подружить с анонсером

            int heal = new Random().Next(7 * (target.Helth / 100), 20 * (target.Helth / 100));
            
            if (heal + target.Helth > target.MaxHelth)
            {
                target.Helth += heal - ((target.Helth + heal) - target.MaxHelth);
                Anonser.SayHeal(( heal - ((target.Helth + heal) - target.MaxHelth)), target);
            }
            else
            {
                target.Helth += heal;
                Anonser.SayHeal(heal, target);
            }

        }

        public void IncomeArmorRepare(Unit target)
        {   //доделать и подружить с анонсером
            target.Armor += 10;
        }
    }
}
