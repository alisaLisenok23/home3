/*Задача 1: Напишите программу, которая принимает на вход пятизначное число и проверяет, 
            является ли оно палиндромом.
            14212 -> нет
            12821 -> да
            23432 -> да
            Задача 2: Напишите программу, которая принимает на вход координаты двух точек 
            и находит расстояние между ними в 3D пространстве.
            A (3,6,8); B (2,1,-7), -> 15.84
            A (7,-5, 0); B (1,-1,9) -> 11.53
            Задача 3: Напишите программу, которая принимает на вход число (N)
            и выдаёт таблицу кубов чисел от 1 до N.
            3 -> 1, 8, 27
            5 -> 1, 8, 27, 64, 125*/
            void palindrom(int num)
            {
                int val = num, temp = 0;
                for (; val > 0; val = val / 10)
                    temp = (temp * 10) + (val % 10);
                if (num == temp)
                    Console.WriteLine("число палиндром");
                else Console.WriteLine("нет");
            }
            double distance(int[] arr)
            {
                double result;
                /*s=√((x 2 - x 1) 2+ (y 2 - y 1) 2+ (z 2 - z 1) 2))*/
                result = Math.Sqrt((arr[0] - arr[3]) * (arr[0] - arr[3]) + (arr[1] - arr[4]) * (arr[1] - arr[4]) + (arr[2] - arr[5]) * (arr[2] - arr[5]));
                return result;
            }
            void cube(int N)
            {
                for(int i=0;i<N;)
                {
                    i++;

                    Console.WriteLine(i * i * i);

                }
            }

            int n;
            double s;
            int[] array = new int[6];
            Console.WriteLine("проверка числа на палиндром");
            Console.Write("введите пятизначное число:");
            n = Convert.ToInt32(Console.ReadLine());
            palindrom(n);
            Console.WriteLine("программа принимает на вход координаты двух точек и находит расстояние между ними в трехмерном пространстве");
            Console.Write("введите координату первой точки Х:");
            array[0] = Convert.ToInt32(Console.ReadLine());
            Console.Write("введите координату первой точки Y:");
            array[1] = Convert.ToInt32(Console.ReadLine());
            Console.Write("введите координату первой точки Z:");
            array[2] = Convert.ToInt32(Console.ReadLine());
            Console.Write("введите координату второй точки Х:");
            array[3] = Convert.ToInt32(Console.ReadLine());
            Console.Write("введите координату второй точки Y:");
            array[4] = Convert.ToInt32(Console.ReadLine());
            Console.Write("введите координату второй точки Z:");
            array[5] = Convert.ToInt32(Console.ReadLine());
            s = distance(array);
            Console.WriteLine("расстояние между точками = " + s);
            Console.WriteLine("программа выводит таблицу кубов до числа N");
            Console.Write("введите N ");
            n = Convert.ToInt32(Console.ReadLine());
            cube(n);