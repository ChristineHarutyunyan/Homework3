using System;
using System.Linq;

namespace ConsoleApp3
{
    class Program
    {
        static void Main()
        {
            #region РЕШЕНИЕ1
            

            Random n = new Random();
            int xnumber = n.Next(12, 121);
            int Player1=0;
            int Player2=0;

            static char Menu1(string Mesage, char[] ValidResponces)
            {
                while (true)
                {
                    Console.WriteLine(Mesage);
                    var key = Console.ReadKey();
                    if (ValidResponces.Contains(key.KeyChar))
                    {
                        Console.WriteLine();
                        return key.KeyChar;
                    }
                    else
                    {
                        Console.WriteLine("Ошибка");
                    }
                }



            }

            
            
            int a=0;
            char resp2 = Menu1("Выберите: [1]=легкий, [2]=средний, [3]=сложный", new char[] { '1', '2', '3' });

            switch (resp2)
            {
                case '1':
                     a = 13;
                    break;
                case '2':
                    a = 9; break;
                case '3':
                    a =5 ; break;
                default:
                     break;
            }






            //char resp = Menu1("Выберите: [1]=одиночная игра, [2]=игра для двух игроков", new char[] { '1', '2' });



            char resp = Menu1("Выберите: [1]=одиночная игра, [2]=игра для двух игроков", new char[] { '1', '2' });


            while (xnumber != 0)
            {
              
                Console.WriteLine("Player1");
               

                { if (resp == '1')
                    { Player1 = n.Next(1, a); Console.WriteLine(Player1); }
                else Convert.ToInt32(Console.ReadLine());
                }

                if (Player1 < 1 || Player1 > a)
                { Console.WriteLine("Error"); }
                else if ((xnumber -= Player1) <= 0) { Console.WriteLine("Win Player1"); }
                else
                {
                    xnumber -= Player1; Console.WriteLine("Player2");
                    Player2 = Convert.ToInt32(Console.ReadLine());
                    if (Player2 < 1 || Player2 > a) { Console.WriteLine("Error"); }
                    else if ((xnumber -= Player2) <= 0) { Console.WriteLine("Win Player2"); }
                    else continue;
                }
                break;
            }






            #endregion
            #region

            //while (xnumber!=0)
            //{ Console.WriteLine("Player1");
            //    Player1 = Convert.ToInt32(Console.ReadLine());
            //    if (Player1 < 1 || Player1 > 4)
            //    { Console.WriteLine("Error"); }
            //    else if ((xnumber -= Player1) <= 0) { Console.WriteLine("Win Player1"); }
            //    else { xnumber -= Player1; Console.WriteLine("Player2");
            //        Player2 = Convert.ToInt32(Console.ReadLine());
            //        if (Player2 < 1 || Player2 > 4) { Console.WriteLine("Error"); }
            //        else if ((xnumber -= Player2) <= 0 ) { Console.WriteLine("Win Player2"); }
            //        else continue;
            //    }
            //    break; }


            #endregion
        }
    }
}
