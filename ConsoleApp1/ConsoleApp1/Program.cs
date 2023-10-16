using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            //Задача 1.Определить, является или нет текущий год високосным? Год ввести с клавиатуры(Год является високосным, если он кратен 4).
            //int year;
            //Console.Write("Введите год: ");
            //year = Convert.ToInt32(Console.ReadLine());
            //if (year % 4 == 0)
            //{
            //    Console.WriteLine($"{year} год-високосный");
            //}
            //else
            //{
            //    Console.WriteLine($"{year} год-невисокосный");
            //}

            // Задача 2.Определить, входит ли цена выбранного ноутбука в диапазон от 20 до 30 тыс.р.
            //int price;
            //Console.Write("Введите цену ноутбука: ");
            //price = Convert.ToInt32(Console.ReadLine());
            //if (price >= 20000 & price <= 30000)
            //{
            //    Console.WriteLine($"{price} входит в диапазон");
            //}
            //else
            //{
            //    Console.WriteLine($"{price} не входит в диапазон");
            //}

            //Задача 3.Написать программу, которая в зависимости от заданного балла определяет оценку учащегося согласно таблице
            //byte score;
            //Console.Write("Введите балл учащегося: ");
            //score = Convert.ToByte(Console.ReadLine());
            //if (score >= 0 && score <= 59)
            //{
            //    Console.WriteLine($"Неудовлетворительно");
            //}
            //else if (score >= 60 && score <= 74)
            //{
            //    Console.WriteLine($"Удовлетворительно");
            //}
            //else if (score >= 75 && score <= 89)
            //{
            //    Console.WriteLine($"Хорошо");
            //}
            //if (score >= 90 && score <= 100)
            //{
            //    Console.WriteLine($"Отлично");
            //}


            //Задача 4.Светофор закодирован тремя состояниями: 1 – красный, 2 – желтый, 3 – зеленый.В зависимости от состояния определить цвет светофора.
            //string stoplight;
            //Console.Write("Введите состояние светофора: ");
            //stoplight = Convert.ToString(Console.ReadLine());
            //switch(stoplight)
            //{
            //    case "1":Console.WriteLine("красный");break;
            //    case "2": Console.WriteLine("желтый"); break;
            //    case "3": Console.WriteLine("синий"); break;
            //    default:Console.WriteLine("ошибка");break;
            //}


            //Задача 5.Проверка знака случайного числа и его чётности
            //int number;
            //Random run = new Random();
            //number = run.Next(-10, 10);
            //Console.WriteLine(number);
            //if (number % 2 == 0)
            //{
            //    Console.WriteLine($"Четное");
            //}
            //else
            //{
            //    Console.WriteLine($"Нечетное");
            //}

            // Задача 6.Выбор дня недели.
            //Console.Write("Введите день недели: ");
            //byte day = byte.Parse(Console.ReadLine());
            //switch(day)
            //{
            //    case 1:Console.WriteLine("понедельник");break;
            //    case 2: Console.WriteLine("вторник"); break;
            //    case 3: Console.WriteLine("среда"); break;
            //    case 4: Console.WriteLine("четверг"); break;
            //    case 5: Console.WriteLine("пятница"); break;
            //    case 6: Console.WriteLine("суббота"); break;
            //    case 7: Console.WriteLine("воскресенье"); break;
            //    default:Console.WriteLine("ошибка");break;
            //}

            // Задача 7.Проверка логина и пароля, введенных с клавиатуры.
            // string a = "Login";
            // string b = "Password";
            // Console.Write("Введите логин: ");
            // string Login = Console.ReadLine();
            // Console.Write("Введите пароль: ");
            // string Password = Console.ReadLine();
            // if (Login == a && Password == b) 
            // {
            //     Console.WriteLine("Логин и пароль верный");
            // }

            //else
            // {
            //     Console.WriteLine("Логин или пароль неверный");
            // }


            //Задача 8. Простейший калькулятор на 4 действия.
            //double number1, number2;
            //char operation;
            //Console.WriteLine("Доступные операции: +, -, *, /");
            //Console.Write("Введите первое число:");
            //number1 = Convert.ToDouble(Console.ReadLine());
            //Console.Write("Введите операцию: ");
            //operation = Convert.ToChar(Console.ReadLine());
            //Console.Write("Введите второе число:");
            //number2 = Convert.ToDouble(Console.ReadLine());
            ////double result = 0;
            //switch(operation)
            //{
            //    case '+':Console.WriteLine(number1 + number2);break;
            //    case '-': Console.WriteLine(number1 - number2); break;
            //    case '*': Console.WriteLine(number1 * number2); break;
            //    case '/': Console.WriteLine(number1 / number2); break;
            //    default:Console.WriteLine("ошибка"); break;
            //}
         

            // Задача 9.Вводится возраст человека и в консольное окно выводится возрастная группа, к которой относится человек.
            //byte age;
            //Console.Write("Введите возраст человека: ");
            //age = Convert.ToByte(Console.ReadLine());
            //if (age >= 0 && age <= 12)
            //{
            //    Console.WriteLine($"Детский возраст");
            //}
            //else if (age >= 13 && age <= 19)
            //{
            //    Console.WriteLine($"Подростковый возраст");
            //}
            //else if (age >= 20 && age <= 59)
            //{
            //    Console.WriteLine($"Взрослый возраст");
            //}
            //else if (age >= 60 && age <= 100)
            //{
            //    Console.WriteLine($"Пожилой возраст");
            //}

            Console.ReadKey();
        }
    }
}
