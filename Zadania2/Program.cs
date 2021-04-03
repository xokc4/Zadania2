using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace Zadania2
{
    class Program
    {
        static void Main(string[] args)
        {
           

            //Ввод данных первого студента 
           Console.WriteLine("Введите имя первого студента");
            string Stud1Name = Console.ReadLine();//Имя

           Console.WriteLine("Введите возраст первого студента ");
            int Stud1Age = Convert.ToInt32(Console.ReadLine());//Возраст

            if (15 < Stud1Age && Stud1Age < 40)// Условия возраста
            {

            }
            else
            {
                Console.WriteLine("Вы ввели не правильный возраст");
            }

           Console.WriteLine("Введите рост первого студента");
            double Stud1Growth = Convert.ToDouble(Console.ReadLine());//Рост
            
                if (1 < Stud1Growth && Stud1Growth < 2.2)//Условие роста 
                {

                }
                else
                {
                    Console.WriteLine("Вы ввели не правильный рост");
                    
                }
            
            
            Console.WriteLine("Введите балл по русскому");
            double Stud1BallRuss = Convert.ToDouble(Console.ReadLine());//Ввод балла по русскому
            Console.WriteLine("Введите балл по истории");
            double Stud1BallIstoria = Convert.ToDouble(Console.ReadLine());//Ввод балла по истории
            Console.WriteLine("Введите балл по матиматике");
            double Stud1BallMat = Convert.ToDouble(Console.ReadLine());//Ввод балла по матиматике
            double Average1Score = (Stud1BallRuss + Stud1BallIstoria + Stud1BallMat) / 3;//Рассчет среднего балла
            Average1Score = Math.Round(Average1Score, 2);// Средний балл оценок , до двух цифр после запятой 

            /// <summary>
            ///  по аналогу с первым студентом происходит ввод данных 2 и 3 студента 
            /// </summary>

            //Ввод данных второго студента 
            Console.WriteLine("Введите имя второго студента");
            string Stud2Name = Console.ReadLine();
            Console.WriteLine("Введите возраст второго  студента ");
            int Stud2Age = Convert.ToInt32(Console.ReadLine());
            if (15 < Stud2Age && Stud2Age < 40)
            {

            }
            else
            {
                Console.WriteLine("Вы ввели не правильный возраст");
            }
            Console.WriteLine("Введите рост второго студента");
            double Stud2Growth = Convert.ToDouble(Console.ReadLine());

            if (1 < Stud2Growth && Stud2Growth < 2.2)
            {

            }
            else
            {
                Console.WriteLine("Вы ввели не правильный рост");

            }


            Console.WriteLine("Введите балл по русскому");
            double Stud2BallRuss = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Введите балл по истории");
            double Stud2BallIstoria = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Введите балл по матиматике");
            double Stud2BallMat = Convert.ToDouble(Console.ReadLine());

            double Average2Score = (Stud2BallRuss + Stud2BallIstoria + Stud2BallMat) / 3;


            //Ввод данных третьего студента 
            Console.WriteLine("Введите имя третьего студента");
            string Stud3Name = Console.ReadLine();
            Console.WriteLine("Введите возраст третьего  студента ");
            int Stud3Age = Convert.ToInt32(Console.ReadLine());

            if (15 < Stud3Age && Stud3Age < 40)
            {

            }
            else
            {
                Console.WriteLine("Вы ввели не правильный возраст");
            }

            Console.WriteLine("Введите рост третьего студента");
            double Stud3Growth = Convert.ToDouble(Console.ReadLine());

            if (1 < Stud3Growth && Stud3Growth < 2.2)
            {

            }
            else
            {
                Console.WriteLine("Вы ввели не правильный рост");

            }

            Console.WriteLine("Введите балл по русскому");
            double Stud3BallRuss = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Введите балл по истории");
            double Stud3BallIstoria = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Введите балл по матиматике");
            double Stud3BallMat = Convert.ToDouble(Console.ReadLine());

            double Average3Score = (Stud3BallRuss + Stud3BallIstoria + Stud3BallMat) / 3;
            Average3Score = Math.Round(Average3Score, 2);




            // обычный вывод
            Console.WriteLine( "Имя:" + Stud1Name + " Возраст: " + Stud1Age + " Рост: " + Stud1Growth + " Средний балл оценок: " + Average1Score);
            //Форматирования строк, также тут происходит изменения среднего балла до двух цифр после запятой  
            Console.WriteLine("Имя: {0}  Возраст: {1} Рост: {2} Средний балл оценок: {3: 0.00} ", Stud2Name, Stud2Age, Stud2Growth, Average2Score);
            //интерполяция строк
            Console.WriteLine($"Имя:{Stud3Name} Возраст: {Stud3Age} Рост: {Stud3Growth} Средний балл оценок: {Average3Score}");

            Console.ReadKey();
           
           

            
        }

      
       
    }
}
