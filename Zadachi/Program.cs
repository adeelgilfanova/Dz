using System;
using System.Collections;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Timers;
using System.IO;

namespace Zadachi
{
    class Program
    {
        static Hospital hospital = new Hospital("Архем");
        static void Main()
        {
            Console.WriteLine("Добрый день!\nВы попали в психиатрическую клинику «Архем»");
            hospital.Registry();
            hospital.GetPatientsForDoctors();
            Console.WriteLine("Для того, чтобы узнать больше информации о нашей поликлинике, НАЖМИТЕ: 0\nДля того, чтобы определить пациента врачу или внести в список еще пациента, НАЖМИТЕ: 0\nДля выхода,НАЖМИТЕ: 2");
            bool flag = true;
            while (flag)
            {
                int userChoice2;
                if (!int.TryParse(Console.ReadLine(), out userChoice2))
                {
                    Console.WriteLine("Ошибка");
                }
                if (userChoice2 == 0)
                {
                    hospital.Information();
                }
                else if(userChoice2 == 1)
                {
                    hospital.AddPatient();
                }
                else if(userChoice2 == 2)
                {
                    break;
                }

            }
            Console.WriteLine("Возвращайтесь!");
        }
    }
}

