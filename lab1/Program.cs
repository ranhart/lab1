namespace lab1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var prog = new Program();

            //while (true) // Задание 1.1
            //{
            //    Console.Write("Задание №1.1. Введите десятичную дробь х: ");
            //    string x = Console.ReadLine();
            //    if (double.TryParse(x, out double num))
            //    {
            //        Console.WriteLine("Ответ: {0}", prog.fraction(num));
            //        break;
            //    }
            //    Console.WriteLine("Ошибка ввода.");
            //}

            //while (true) // Задание 1.3
            //{
            //    Console.Write("Задание №1.3. Введите символ из перечня: "0 1 2 3 4 5 6 7 8 9": ");
            //    string x = Console.ReadLine();
            //    if (char.TryParse(x, out char num) && Char.IsDigit(Convert.ToChar(x)))
            //    {
            //        Console.WriteLine("Ответ: {0}", prog.charToNum(num));
            //        break;
            //    }
            //    Console.WriteLine("Ошибка ввода.");
            //}

            //while (true) // Задание 1.5
            //{
            //    Console.Write("Задание №1.5. Введите число: ");
            //    string x = Console.ReadLine();
            //    if (int.TryParse(x, out int num))
            //    {
            //        Console.WriteLine("Ответ: {0}", prog.is2Digits(num));
            //        break;
            //    }
            //    Console.WriteLine("Ошибка ввода.");
            //}

            //while (true) // Задание 1.7
            //{
            //    Console.Write("Задание №1.7. Введите числовой диапазон и число: ");
            //    string a = Console.ReadLine();
            //    string b = Console.ReadLine();
            //    string x = Console.ReadLine();
            //    if (int.TryParse(a, out int num1) && int.TryParse(b, out int num2) && int.TryParse(x, out int num3))
            //    {
            //        Console.WriteLine("Ответ: {0}", prog.isInRange(num1,num2, num3));
            //        break;
            //    }
            //    Console.WriteLine("Ошибка ввода.");
            //}

            //while (true) // Задание 1.9
            //{
            //    Console.Write("Задание №1.9. Введите три одинаковых числа: ");
            //    string a = Console.ReadLine();
            //    string b = Console.ReadLine();
            //    string с = Console.ReadLine();
            //    if (int.TryParse(a, out int num1) && int.TryParse(b, out int num2) && int.TryParse(с, out int num3))
            //    {
            //        Console.WriteLine("Ответ: {0}", prog.isEqual(num1, num2, num3));
            //        break;
            //    }
            //    Console.WriteLine("Ошибка ввода.");
            //}

            //while (true) // задание 2.1
            //{
            //    Console.Write("Задание №2.1. Введите число: ");
            //    string a = Console.ReadLine();
            //    if (int.TryParse(a, out int num))
            //    {
            //        Console.WriteLine("Ответ: {0}", prog.abs(num));
            //        break;
            //    }
            //    Console.WriteLine("Ошибка ввода.");
            //}

            //while (true) // задание 2.3
            //{
            //    Console.Write("Задание №2.3. Введите число: ");
            //    string a = Console.ReadLine();
            //    if (int.TryParse(a, out int num))
            //    {
            //        Console.WriteLine("Ответ: {0}", prog.is35(num));
            //        break;
            //    }
            //    Console.WriteLine("Ошибка ввода.");
            //}

            //while (true) // задание 2.5
            //{
            //    Console.Write("Задание №2.5. Введите число: ");
            //    string a = Console.ReadLine();
            //    string b = Console.ReadLine();
            //    string c = Console.ReadLine();
            //    if (int.TryParse(a, out int num1) && int.TryParse(b, out int num2) && int.TryParse(c, out int num3))
            //    {
            //        Console.WriteLine("Ответ: {0}", prog.max3(num1, num2, num3));
            //        break;
            //    }
            //    Console.WriteLine("Ошибка ввода.");
            //}

            //while (true) // задание 2.7
            //{
            //    Console.Write("Задание №2.7. Введите число: ");
            //    string a = Console.ReadLine();
            //    string b = Console.ReadLine();
            //    if (int.TryParse(a, out int num1) && int.TryParse(b, out int num2))
            //    {
            //        Console.WriteLine("Ответ: {0}", prog.sum2(num1, num2));
            //        break;
            //    }
            //    Console.WriteLine("Ошибка ввода.");
            //}

            //while (true) // задание 2.9
            //{
            //    Console.Write("Задание №2.9. Введите число: ");
            //    string x = Console.ReadLine();
            //    if (int.TryParse(x, out int num))
            //    {
            //        Console.WriteLine("Ответ: {0}", prog.day(num));
            //        break;
            //    }
            //    Console.WriteLine("Ошибка ввода.");
            //}

            //while (true) // задание 3.1
            //{
            //    Console.Write("Задание №3.1. Введите число: ");
            //    string x = Console.ReadLine();
            //    if (int.TryParse(x, out int num))
            //    {
            //        Console.WriteLine("Ответ: {0}", prog.listNums(num));
            //        break;
            //    }
            //    Console.WriteLine("Ошибка ввода.");
            //}

            //while (true) // задание 3.3
            //{
            //    Console.Write("Задание №3.3. Введите число: ");
            //    string x = Console.ReadLine();
            //    if (int.TryParse(x, out int num))
            //    {
            //        Console.WriteLine("Ответ: {0}", prog.chet(num));
            //        break;
            //    }
            //    Console.WriteLine("Ошибка ввода.");
            //}

            //while (true) // задание 3.5
            //{
            //    Console.Write("Задание №3.5. Введите число: ");
            //    string x = Console.ReadLine();
            //    if (long.TryParse(x, out long num))
            //    {
            //        Console.WriteLine("Ответ: {0}", prog.numLen(num));
            //        break;
            //    }
            //    Console.WriteLine("Ошибка ввода.");
            //}

            //while (true) // задание 3.7
            //{
            //    Console.Write("Задание №3.7. Введите число: ");
            //    string x = Console.ReadLine();
            //    if (int.TryParse(x, out int num))
            //    {
            //        Console.WriteLine("Ответ: ");
            //        prog.square(num);
            //        break;
            //    }
            //    Console.WriteLine("Ошибка ввода.");
            //}

            //while (true) // задание 3.9
            //{
            //    Console.Write("Задание №3.9. Введите число: ");
            //    string x = Console.ReadLine();
            //    if (int.TryParse(x, out int num))
            //    {
            //        Console.WriteLine("Ответ: ");
            //        prog.rightTriangle(num);
            //        break;
            //    }
            //    Console.WriteLine("Ошибка ввода.");
            //}

            //while (true) // задание 4.1
            //{
            //    Console.Write("Задание №4.1. Введите число: ");
            //    string x = Console.ReadLine();
            //    int[] arr = {1, 2, 3, 4, 2, 2, 5};
            //    if (int.TryParse(x, out int num))
            //    {
            //        Console.WriteLine("Ответ: {0}", prog.findFirst(arr, num));
            //        break;
            //    }
            //    Console.WriteLine("Ошибка ввода.");
            //}

            while (true) // задание 4.3
            {
                Console.Write("Задание №4.3. Введите число: ");
                string x = Console.ReadLine();
                int[] arr = { 1, 2, 3, 4, 2, 2, 5 };
                if (int.TryParse(x, out int num))
                {
                    Console.WriteLine("Ответ: {0}", prog.findFirst(arr, num));
                    break;
                }
                Console.WriteLine("Ошибка ввода.");
            }
        }
        public double fraction(double x)
        {
            return Math.Round(x - (int)x, 15);
        }

        public int charToNum(char x)
        {
            return (int)x - (int)'0';
        }

        public bool is2Digits(int x)
        {
            if (x >= 10 && x < 100) return true;
            else return false;
        }

        public bool isInRange(int a, int b, int num)
        {
            if ((num > a && num < b) || (num < a && num > b)) return true;
            else return false;
        }

        public bool isEqual(int a, int b, int c)
        {
            if(a == b && a == c && b == c) return true;
            else return false;
        }

        public int abs(int x)
        {
            if(x >= 0) return x;
            else return x - x*2;
        }

        public bool is35(int x)
        {
            if(x%3 == 0 && x%5 == 0) return false;
            else if(x%3 == 0 || x%5 == 0) return true;
            else return false;
        }

        public int max3(int x, int y, int z)
        {
            if (x >= y && x >= z) return x;
            else if (y >= z && y >= x) return y;
            else return z;
        }

        public int sum2(int x, int y)
        {
            if (x + y >= 10 && x + y < 20) return 20;
            else return x+y;
        }

        public String day(int x)
        {
            switch (x)
            {
                case 1:
                    return "Понедельник";
                    break;
                case 2:
                    return "Вторник";
                    break;
                case 3:
                    return "Среда";
                    break;
                case 4:
                    return "Четверг";
                    break;
                case 5:
                    return "Пятница";
                    break;
                case 6:
                    return "Суббота";
                    break;
                case 7:
                    return "Воскресенье";
                    break;
                default:
                    return "Такого дня недели не существует";
                    break;
            }
        }
        public String listNums(int x)
        {
            string str = "";
            for (int i = 0; i <= x; i++)
            {
                str += Convert.ToString(i);
                str += " ";
            }
            return str;
        }

        public String chet(int x)
        {
            string str = "";
            for (int i = 0; i <= x; i += 2)
            {
                str += Convert.ToString(i);
                str += " ";
            }
            return str;
        }

        public int numLen(long x)
        {
            int cnt = 0;
            while (x != 0)
            {
                cnt++;
                x /= 10;
            }
            return cnt;
        }

        public void square(int x)
        {
            for (int i = 0; i < x; i++)
            {
                for(int j = 0; j < x; j++)
                {
                    Console.Write('*');
                }
                Console.WriteLine();
            }
        }

        public void rightTriangle(int x)
        {
            int k = 0;
            int l = 1;
            for (int i = 0; i < x; i++)
            {
                for (int j = k; j < x-1; j++)
                {
                    Console.Write(' ');
                }
                for (int m = 0; m < l; m++)
                {
                    Console.Write('*');
                }
                k++;
                l++;
                Console.WriteLine();
            }
        }

        public int findFirst(int[] arr, int x)
        {
            for (int i = 0; i < arr.Length; i++)
            {
                if (arr[i] == x) return i;
            }
            return -1;
        }
    }
}
