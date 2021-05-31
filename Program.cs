using BigBossFight.UnitsAndStaf;
using System;


namespace BigBossFight
{
    class Program
    {
        static void Main(string[] args)
        {
            //Генерация противников
            Unit boss = new Unit();
            boss.GenerateUnitStat(12000, 600);
            boss.GenerateName();

            Unit player = new Unit();
            player.GenerateUnitStat(8000, 400);

            //приветствие
            Anonser.Intro(boss, player);

            //начало битвы
            //Console.WriteLine("обьявление контролов и здоровья противников");

            while (Globals.BothAreAlive)
            {

                // сама фаза боя, если оба учасника живи
                if (Globals.BothAreAlive)
                {

                    Console.WriteLine("Boss do someting. He has " + boss.Helth + " heals and " + boss.Armor + " armor");
                    //генерация выбора босса
                    //сделать многоходовые способности боссу


                    switch (boss.Chose(4))
                    {
                        //слабый удар
                        case 0:
                            Console.WriteLine("Discription of weak Boss atak");
                            Actions.DamageHealth(player, boss.getWeakDamage);
                            break;
                        //силный удар
                        case 1:
                            Console.WriteLine("Discription of strong Boss atak");
                            Actions.DamageHealth(player, boss.getStrondDamage);
                            break;
                        //способность
                        case 2:
                            Console.WriteLine("Boss use special ability");
                            int atackDirection = new Random().Next(1, 4);
                            Console.WriteLine("in which direction will they dodge ");
                            int dodgeDirection = Convert.ToInt32(Console.ReadLine());

                            if (atackDirection == dodgeDirection)
                            {
                                Console.WriteLine("Sucsses evaid");
                            }
                            else
                            {
                                Console.WriteLine("Boss hit you");
                                Actions.DamageHealth(player, (boss.getStrondDamage * 3));
                            }
                            break;
                        //самохил
                        case 3:
                            Console.WriteLine("Boss uses healing magic!!");
                            Actions.Heal(boss);
                            
                            break;
                        //+броня
                        case 4:
                            Console.WriteLine("босс повышает броню");
                            break;
                    }
                    Tick.IsBothAlive(boss.Helth, player.Helth);
                    if (!Globals.BothAreAlive)
                    {
                        break;
                    }

                    Console.WriteLine("ввод в ход игрока hp {0} ; armmor {1}", player.Helth, player.Armor);
/*
                    int playerChose = Convert.ToInt32(Console.ReadLine());
                    switch (playerChose)
                    {
                        //слабый удар
                        case 1:
                            break;
                        //силный удар
                        case 2:
                            break;
                        //способность шаг 1
                        case 3:
                            break;
                        //способность шаг 2
                        case 4:
                            break;
                        //самохил
                        case 5:
                            break;
                        //+броня
                        case 6:
                            break;
                        //блок на один ход
                        case 7:
                            brake;
                    }

                    Console.ReadKey();
                    */
                    Tick.IsBothAlive(boss.Helth, player.Helth);
                }
            }
        }
    }
}
