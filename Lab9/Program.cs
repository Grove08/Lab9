using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab9
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Вас приветствует калькулятор!");
            try
            {
                Console.Write("Введите первое число:X=");
                double number1 = Convert.ToDouble(Console.ReadLine());
                Console.Write("Введите второе число:Y=");
                double number2 = Convert.ToDouble(Console.ReadLine());
                Console.WriteLine("Выберите операцию:");
                Console.WriteLine("1 - сложение");
                Console.WriteLine("2 - вычитание");
                Console.WriteLine("3 - произведение");
                Console.WriteLine("4 - частное");
                Console.Write("Введите код операции: ");
                int operationCode = Convert.ToInt32(Console.ReadLine());

                double result = 0;
                if (operationCode == 1)
                {
                    result = number1 + number2;
                }
                else if (operationCode == 2)
                {
                    result = number1 - number2;
                }
                else if (operationCode == 3)
                {
                    result = number1 * number2;
                }
                else if (operationCode == 4)
                {
                    if (number2 != 0)
                    {
                        result = number1 / number2;
                    }
                    else
                    {
                        Console.WriteLine("Ошибка: деление на ноль!");
                        Console.ReadKey();
                        return;
                    }
                }
                else
                {
                    Console.WriteLine("Нет операции с указанным номером");
                    Console.ReadKey();
                    return;
                }                
                Console.WriteLine("Результат операции: " + result);
            }

            catch (Exception ex)
            {
                Console.WriteLine("Ошибка: " + ex.Message);

            }

            Console.ReadKey();
        }
    }
}
