using System;

namespace Lab1
{
    public class OddYear {
        public int userYear;
        /// <summary>
        /// конструктор класса
        /// </summary>
        public OddYear()
        {
            userYear = 0;
        }
        /// <summary>
        /// определение типа года и вывод количества дней в году
        /// </summary>
        /// <param name="year"></param>
        public void DefineYearType()
        { int a = 1;
            while(a==1)
            {
                int devider1 = 4;
                int devider2 = 100;
                int devider3 = 400;
                    try
                    {
                        Console.WriteLine("Введите год");
                        userYear = Convert.ToInt32(Console.ReadLine());
                        if ((userYear % devider1 == 0) && (userYear % devider2 != 0) || (userYear % devider3 == 0))
                        {
                        Console.WriteLine("Введенный год - високосный и имеет 366 дней ");
                        }
                        else
                        {
                         Console.WriteLine("Введенный год - невисокосный и имеет 365 дней ");
                        }
                         Console.WriteLine("Повторить проверку? Если да - нажмите 1, в случае нет -0 ");
                         a = Convert.ToInt32(Console.ReadLine());
                    }
                    catch(FormatException Fe)
                    {
                        Console.Write("Вы ввели не число !!! Повторите еще разок! \n");
                    }
            }
        }
    }
}
