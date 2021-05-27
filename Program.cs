using System;

namespace BigBossFight
{
    class Program
    {
        static void Main(string[] args)
        {
            //приветствие
            Console.WriteLine("Приветсвую! \n Вы наконец достигли конца своего долгого путишествия полного приключений.\n " +
                "Но что бы отправиться на заслуженный покой вам необходимо пройти последнее испытание!");
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine("Битва с фитальным Босом!!\n \n");
            Console.ResetColor();

            Console.WriteLine("Напомни, как тебя зовут");
            string name = Console.ReadLine();

            Console.ReadKey();


            Console.WriteLine("представление босса");
            Console.WriteLine("ввод в битву");


            //Генерация жизней противников
            Random rnd = new Random();

            int bossHelth = rnd.Next(1000, 1501);
            int maxBossHelth = bossHelth;
            int playerHelth = 800;
            int maxPlayerHelth = 800;

            //генерация брони
            int bossArmmor = 20;
            int playerArmmor = 10;

            //переменные для умний 
            bool playerSpecialAtackRedy = false;
            //начало битвы
            Console.WriteLine("обьявление контролов и здоровья противников");
            bool bothAreAlive = true;
            while (bothAreAlive)
            {

                // сама фаза боя, если оба учасника жыви
                if (bossHelth > 0 && playerHelth > 0)
                {

                    Console.WriteLine("ввод в ход босса ");
                    //генерация выбора босса
                   
                    int bossChose = rnd.Next(0, 5);
                    switch (bossChose)
                    {
                        //слабый удар
                        case 1:
                            Console.WriteLine("описание слабого удара");
                            int weakAtack = rnd.Next(50, 130);
                            Console.WriteLine("{0} damage", weakAtack);
                            playerHelth -= weakAtack - (weakAtack * playerArmmor / 100 );
                            playerArmmor -= 5 * playerArmmor / 100;
                            break;
                        //силный удар
                        case 2:
                            Console.WriteLine("описание сильного удара");
                            int strongAtack = rnd.Next(125, 300);
                            Console.WriteLine("{0} damage", strongAtack);
                            playerHelth -= strongAtack - (strongAtack * playerArmmor / 100);
                            playerArmmor -= 10 * playerArmmor / 100;
                            break;
                        //способность
                        case 3:
                            Console.WriteLine("описание способности");
                            int specialAtack = rnd.Next(50, 500);
                            int atackDirection = rnd.Next(1,4);
                            Console.WriteLine("in which direction will they dodge ");
                            int dodgeDirection = Convert.ToInt32(Console.ReadLine());

                            if (atackDirection == dodgeDirection)
                            {
                                Console.WriteLine("успешное уклонение");
                            }
                            else
                            {
                                Console.WriteLine("{0} damage", specialAtack);
                                playerHelth -= specialAtack - (specialAtack * playerArmmor / 100);
                                playerArmmor -= 10 * playerArmmor / 100;
                            }
                            break;
                        //самохил
                        case 4:
                            Console.WriteLine("босс пвтается поличится");
                            if (bossHelth < maxBossHelth)
                            {

                                int healAtempt = rnd.Next(100, 300);
                                if (bossHelth + healAtempt > maxBossHelth) 
                                {
                                    healAtempt = (bossHelth + healAtempt) - maxBossHelth;
                                    bossHelth += healAtempt;
                                    Console.WriteLine("heals add {0}. heals of boss is {1}", healAtempt, bossHelth);
                                }
                                else
                                {
                                    bossHelth += healAtempt;
                                    Console.WriteLine("heals add {0}. heals of boss is {1}", healAtempt , bossHelth);
                                }
                            }
                            else
                            {
                                Console.WriteLine("леченеи не получилось");
                            }
                            break;
                        //+броня
                        case 5:
                            Console.WriteLine("босс повышает броню");
                            int bossArmmorAdd = rnd.Next(5, 15);
                            bossArmmor += bossArmmorAdd;
                            Console.WriteLine("{0} add armor. boss armor is {1}", bossArmmorAdd, bossArmmor);
                            break;
                    }


                    Console.WriteLine("ввод в ход игрока hp {0} ; armmor {1}", playerHelth, playerArmmor);
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
                     }
 
                    Console.ReadKey();
                }

                //бос умер
                if (bossHelth <= 0 && playerHelth > 0)
                {
                    Console.WriteLine("что-то радосное ");
                    bothAreAlive = false;
                }
                //игрок умер
                if (playerHelth <= 0 && bossHelth > 0)
                {
                    Console.WriteLine("что-то грусно");
                    bothAreAlive = false;
                }
                //оба скопытились
                if (playerHelth <= 0 && bossHelth <= 0)
                {
                    Console.WriteLine("что-то не понятное ");
                    bothAreAlive = false;
                }




            }


        }
    }
}
