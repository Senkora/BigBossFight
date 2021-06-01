using System;

namespace BigBossFight.UnitsAndStaf
{
	class Actions
	{

		public static void DamageHealth(Unit target, int damage)
		{
			Anonser.SayDamage(damage - (target.Armor *  damage/ 100), target);
			target.Helth -= (damage - (target.Armor * damage / 100));
			
			if (new Random().Next(0,4) == 1)
            {
				CausBleed(target);

			}

		}
		public static void DamageArmor(Unit unit)
		{
			//доделать
		}

		public static void CausBleed(Unit target) 
		{
			
			target.AddBleed(5);
		}

		public static void Heal(Unit target)
		{
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
			if (target.IsBleed) 
			{
				target.BleadCounter--;
			}

		}

		public void IncomeArmorRepare(Unit target)
		{   //доделать и подружить с анонсером
			target.Armor += 10;
		}
	}
}
