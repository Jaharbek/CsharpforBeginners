using System;
using System.Text;

namespace ConsoleApp
{
    class Program
    {
        /// <summary>
        /// tests
        /// </summary>
        /// <param name="args"></param>
        static void Main(string[] args)
        {
            //int number1 = 4;
            //int number2 = 5;
            //short shortNumber = 100;
            //long longNumber = 113165446;
            //byte test = 255;

            //float floatNumber = 10.305F;
            //double doubleNumber = 10.30200;
            //decimal decimalNumber = 10.321654654M;

            //int number3 = 966;
            //byte age2 = (byte)number2;

            //bool status1 = true;
            //bool status2 = false;

            //Console.WriteLine("status1&&status2" + "=" + (status1&&status2));
            //Console.WriteLine("status1||status2" + "=" + (status1 || status2));
            //Console.WriteLine("status1^status2" + "=" + (status1 ^ status2));
            //Console.WriteLine("!status1" + "=" + (!status1));
            //Console.WriteLine("number1&&number2" + "=" + (number1 > number2));
            //Console.WriteLine("number1&&number2" + "=" + (number1 < number2));
            //Console.WriteLine("number1>=number2" + "=" + (number1 >= number2));
            //Console.WriteLine("number1&&number2" + "=" + (number1 < number2));
            //Console.WriteLine("number1<=number2" + "=" + (number1 <= number2));
            //Console.WriteLine("number1!=number2" + "=" + (number1 != number2));

            //Console.WriteLine(number1 * number2);
            //Console.WriteLine(number1 / number2);
            //Console.WriteLine(number1 % number2);
            //Console.WriteLine(number1 + number2);
            //Console.WriteLine(number1 - number2);

            //string sname = "Saydulloev";
            //int age = 25;
            //string name = "Jaharbek";

            //Console.WriteLine("Имя: {1} Возраст: {0} лет Фамилия: {2}",age, name, sname);

            //Console.Write("Введите вашу фамилию: ");
            //string sname2 = Console.ReadLine();
            //Console.Write("Введите ваше имя: ");
            //string name2 = Console.ReadLine();
            //Console.Write("Введите ваш возраст: ");
            //int age3 = Convert.ToInt32(Console.ReadLine());
            //Console.Write("Введите вашу зарплату: ");
            //decimal salary = Convert.ToDecimal(Console.ReadLine());

            //Console.WriteLine($"Фамилия: {sname2} Имя: {name2} Возраст: {age3} лет Зарплата: {salary}$");

            //int x1 = 5;
            //int x2 = ++x1;

            //Console.WriteLine($"{x1}-{x2}");

            //int y1 = 4;
            //int y2 = y1--;

            //Console.WriteLine($"{y2}-{y1}");

            //int a = 3;
            //int b = 4;
            //int c = 50;
            //int d = c-- - b * a;
            //Console.WriteLine($"a={a} b={b} c={c} d={d}");

            //int a1 = 5;
            //int a2 = 100;
            //int a3 = a1 ^ a2;
            //Console.WriteLine("Зашифрованное число: " + a3);

            //int a4 = a3 ^ a2;
            //Console.WriteLine("Расшифрованное число: " + a4);

            //int b1 = 12;
            //int b2 = ~b1;
            //b2 += 1;
            //Console.WriteLine(b2);

            //int qwe = 4;
            //Console.WriteLine(qwe<<3);

            //int a5 = 33;
            //int b5 = 600;
            //byte c5 = (byte)(a5+ b5);
            //Console.WriteLine(c5);

            Console.OutputEncoding = Encoding.UTF8;

            //byte age = 12;

            //if (age >= 18)
            //{
            //Console.WriteLine("Вам уже можно работать");
            //}
            //else if(age >= 14 && age < 18)
            //{
            //Console.WriteLine("Вам уже можно работать");
            //Console.WriteLine("Но Вам ещё лучше учиться");
            //}
            //else
            //{
            //Console.WriteLine("Вам ещё лучше учиться");
            //}

            //string ProductCategory = "alcohol";

            //switch (ProductCategory)
            //{
            //case "alcohol" when age >= 14 && age < 18:
            //Console.WriteLine("Вам ещё мало лет");
            //break;
            //case "alcohol" when age >= 18:
            //case "milk":
            //Console.WriteLine("Всего доброго");
            //break;
            //default:
            //Console.WriteLine("Не хотите ли Вы конфет");
            //break;
            //}

            //for (int i = 0; i < 5; i++)
            //{
            //    for (int j = 0; j < 5; j++)
            //    {
            //        Console.Write("[ ]");
            //    }
            //    Console.WriteLine();
            //}

            //bool IsBooled = false;
            //int timer = 0;

            //while (!IsBooled)
            //{
            //    Console.Write("[ ]");
            //    if (timer == 20)
            //    {
            //        break;
            //    }
            //    if (timer == 100)
            //    {
            //        IsBooled = true;
            //    }
            //    timer++;
            //    if (timer > 10)
            //    {
            //        Console.Write("[y]");
            //        continue;
            //    }
            //}
            //if (IsBooled)
            //{
            //    Console.WriteLine("Вода вскипела");
            //}

            //bool success = false;
            //Console.WriteLine("Введите число от 1 до 10");
            //do
            //{
            //    string answer = Console.ReadLine();
            //    success = int.TryParse(answer, out int value);
            //    if (value >= 1 && value < 10)
            //    {
            //        Console.WriteLine("Вы ввели: " + answer);
            //    }
            //    if (!success)
            //    {
            //        Console.WriteLine("Вы ввели не число");
            //    }
            //} while (!success);

            //string google = "google";
            //foreach (var item in google)
            //{
            //    Console.WriteLine(item);
            //}

            //string[] names = new string[13];
            //names[0] = "Ivan";
            //names[1] = "Maks";
            //names[2] = "Sergey";
            //names[3] = "Pavel";
            //names[4] = "Egor";
            //Console.WriteLine("Введите ваше имя: ");
            //names[5] = Console.ReadLine();
            //for (int i = 0; i < names.Length; i++)
            //{
            //    Console.WriteLine(names[i]);
            //}

            //foreach (var item in names)
            //{
            //    Console.WriteLine(item);
            //}

            //int[] numbers = new int[10];
            //Random random = new Random();

            //for (int i = 0; i < numbers.Length; i++)
            //{
            //    numbers[i] = random.Next();
            //}

            //for (int i = 0; i < numbers.Length; i++)
            //{
            //    Console.WriteLine(numbers[i]);
            //}

            //Console.WriteLine("Введите число: ");
            //double a = Convert.ToDouble(Console.ReadLine());

            //Console.WriteLine("Введите число: ");
            //double b = Convert.ToDouble(Console.ReadLine());

            //double c = a * b;

            //Console.WriteLine("Ответ: " + c);


            //byte age = 10;

            //if (age >= 10 && age < 18)
            //{
            //    Console.WriteLine("Вам ещё  мало лет!");
            //}
            //else
            //{
            //    Console.WriteLine("Всего доброго!");
            //}

            //bool success = false;
            //Console.WriteLine("Введите число: ");
            //do
            //{
            //    string answer = Console.ReadLine();
            //    success = int.TryParse(answer, out int value);
            //    if (value >= 1)
            //    {
            //        Console.WriteLine("Вы ввели" + value);
            //    }
            //    if (!success)
            //    {
            //        Console.WriteLine("Вы ввели не число!");
            //    }
            //} while (!success);

            //string str = "google";
            //foreach (var item in str)
            //{
            //    Console.WriteLine(item);
            //}

            //int[] numbers = new int[10];
            //Random random = new Random();
            //for (int i = 0; i < numbers.Length; i++)
            //{
            //    numbers[i] = random.Next();
            //}
            //for (int i = 0; i < numbers.Length; i++)
            //{
            //    Console.WriteLine(numbers[i]);
            //}
            //Console.ReadKey();
            double value_3;
            string y = "Yes";
            string n = "No";
            bool success = false;
            Console.WriteLine("Введите любое число: ");
            do
            {
                string answer = Console.ReadLine();
                success = Double.TryParse(answer, out double value_1);
                if (value_1 >= 1)
                {
                    Console.WriteLine("Вы ввели: " + value_1);
                }
                if (!success)
                {
                    Console.WriteLine("Вы не ввели число!");
                }
                Console.WriteLine("Введите любое число: ");
                string answer_2 = Console.ReadLine();
                success = Double.TryParse(answer_2, out double value_2);
                if (value_2 >= 1)
                {
                    Console.WriteLine("Вы ввели: " + value_2);
                }
                if (!success)
                {
                    Console.WriteLine("Вы ввели не число!");
                }
                Console.WriteLine("Хотите умножить числа? y/n");
                string answer_3 = Console.ReadLine();
                if (answer_3 == "y")
                {
                    Console.WriteLine("Ваш ответ:" + y);
                }
                else if (answer_3 == "n")
                {
                    Console.WriteLine("Ваш ответ:" + n);
                }
                else
                {
                    Console.WriteLine("Неверно");
                }
                
                if (answer_3 == "n")
                {
                    break;
                }
                Console.WriteLine("Please, wait...");
                for (int i = 0; i < 10; i++)
                {
                    Console.Write("[ ]");
                }
                Console.WriteLine();
                value_3 = value_1 * value_2;
                Console.WriteLine("Ответ: " + value_3);
            } while (!success);
        }
    }
}