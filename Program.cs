using System;

namespace BigBossFight
{
    class Program
    {
        static void Main(string[] args)
        {
            //Генерация противников
            Unit boss = new Unit();
            boss.GenerateUnitStat = 1200;
            Unit player = new Unit();
            player.GenerateUnitStat = 800;
            // Console.WriteLine("Armor --  {0}, Heath -- {1} \n", boss.GetArmor , boss.GetHelth);



            /*  while (Globals.BothAreAlive)
              {

                  Console.ForegroundColor = ConsoleColor.Yellow;
                  Console.WriteLine(boss.IncomeDamageHelth = new Random().Next(30, 200));
                  Console.ResetColor();
                  Console.WriteLine("Armor --  {0}, Heath -- {1} \n", boss.GetArmor, boss.GetHelth);
                 
              }
            */



            //приветствие
            Console.WriteLine("Hello! \n You have finally reached the end of your long journey full of adventures. \n" +
                " But in order to go to your well-deserved rest, you must pass the last test!");
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine("Battle with Fital Boss !!\n \n");
            Console.ResetColor();

           // Console.WriteLine("Remind me what your name is");
           // string name = Console.ReadLine();


            Console.WriteLine("boss interction");
            Console.WriteLine("battle interction");


            //Генерация жизней противников

            
            //начало битвы
            Console.WriteLine("обьявление контролов и здоровья противников");
            
            while (Globals.BothAreAlive)
            {
                




                // сама фаза боя, если оба учасника жыви
                if (boss.GetHelth > 0 && player.GetHelth > 0)
                {

                    Console.WriteLine("Boss do some ting. He has "+ boss.GetHelth + " heals and " + boss.GetArmor +" armor");
                    //генерация выбора босса
                    //сделать многоходовые способности боссу
                   
                    
                    switch (boss.Chose(5))
                    {
                        //слабый удар
                        case 0:
                            Console.WriteLine("Discription of weak Boss atak");
                            Console.WriteLine("Boss do "+ (player.IncomeDamageHelth = new Random().Next(30, 200)) + " damage");
                            break;
                        //силный удар
                        case 1:
                            Console.WriteLine("Discription of strong Boss atak");
                            Console.WriteLine("Boss do " + (player.IncomeDamageHelth = new Random().Next(30, 200)) + " damage");
                            break;
                        //способность
                        case 2:
                            Console.WriteLine("Boss use special ability");
                            int specialAtack = new Random().Next(50, 500);
                            int atackDirection = new Random().Next(1,4);
                            Console.WriteLine("in which direction will they dodge ");
                            int dodgeDirection = Convert.ToInt32(Console.ReadLine());

                            if (atackDirection == dodgeDirection)
                            {
                                Console.WriteLine("Sucsses evaid");
                            }
                            else
                            {
                                Console.WriteLine("Boss hit you");
                                Console.WriteLine("Boss do " + (player.IncomeDamageHelth = new Random().Next(30, specialAtack)) + " damage");
                            }
                            break;
                        //самохил
                        case 3:
                            Console.WriteLine("Boss try to heal");
                            Console.Write("Boss heal self at ");
                            boss.IncomeHeal = new Random().Next(50, 300);
                            Console.Write(" heath. And now it {0} \n",  boss.GetHelth);
                            break;
                        //+броня
                        case 4:
                            Console.WriteLine("босс повышает броню");
                            break;
                    }


                    Console.WriteLine("ввод в ход игрока hp {0} ; armmor {1}", player.GetHelth, player.GetArmor);
                    
                    /* int playerChose = Convert.ToInt32(Console.ReadLine());
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
                    Tick.IsBothAlive(boss.GetHelth, player.GetHelth);
                }
            }
        }
    }
}
