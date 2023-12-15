using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PR_13
{
    internal class Program
    {
        struct Student
        {
            public string Name; // Фамилия с инициалами
            public string GroupNumber; // Номер группы
            public int[] Grade; // Оценка по 5-ти дисциплинам
        }
        static void Main()
        {

            int x; // Ввод значения для завершения

            do
            {
                try
                {
                    Console.Clear();

                    Console.WriteLine("Добро пожаловать!");
                    Console.WriteLine("Практическая работа №13");

                    Console.Write("\nВведите кол-во студентов: ");
                    int n = Int32.Parse(Console.ReadLine());
                    Student[] StudentInfo = new Student[n];
                    for (int i = 0; i < n; i++)
                    {
                        Console.Write("\nВведите фамилию и инициалы Студента: ");
                        StudentInfo[i].Name = Console.ReadLine();
                        Console.Write("\nВведите номер группы Студента: ");
                        StudentInfo[i].GroupNumber = Console.ReadLine();
                        StudentInfo[i].Grade = new int[5];
                        for (int j = 0; j < 5; j++)
                        {
                            Console.Write("\nВведите оценку за ");
                            Console.Write(j + 1);
                            Console.Write(" дисциплину Студента: ");
                            StudentInfo[i].Grade[j] = Convert.ToInt32(Console.ReadLine());
                        }
                    }
                    Console.WriteLine();

                    bool flag = true;

                    Console.WriteLine("Студенты, имеющие 4 и 5:\n");

                    for (int i = 0; i < n; i++)
                    {
                        for (int j = 0; j < 5; j++)
                        {
                            if (StudentInfo[i].Grade[j] == 4 || StudentInfo[i].Grade[j] == 5) // если Grade = 4 и 5
                            {
                                Console.WriteLine(StudentInfo[i].Name + ' ' + StudentInfo[i].GroupNumber);
                                flag = false;
                                break;
                            }
                        }
                    }

                    if (flag)
                    {
                        Console.WriteLine("Студентов, имеющих оценки 4 и 5, не найдено.");
                    }
                }

                catch (FormatException e)
                {
                    Console.WriteLine("Возникла ошибка: " + e.Message); // вывод типа ошибки при наличии таковой
                }

                Console.WriteLine("\nНажмите 1, чтобы завершить работу, или 2, чтобы продолжить.\n");
                x = Convert.ToInt32(Console.ReadLine());

            }

            while (x == 2);
            Console.WriteLine("\nЗавершение работы. Спасибо, что использовали меня ^^.");
            Console.ReadKey(); // задержка экрана консоли

            Console.ReadKey();
        }
    }
}
