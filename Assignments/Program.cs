using System;

namespace Assignments
{
    class Assignments
    {
        static void Main(string[] args)
        {
            Excel3();
        }
        static void TempConverter()
        {
            double celsius;
            double farenhait = 98;

            celsius = 5 * ((farenhait - 32.0) / 9);
            Console.WriteLine(celsius);
        }
        static void TempConverterInput()
        {
            double celsius;

            Console.WriteLine("Whats the temp in Farenhait?");

            double farenhait = Convert.ToDouble(Console.ReadLine());
            celsius = 5 * ((farenhait - 32.0) / 9);
            Console.WriteLine("Temp in Farenhait is:{0}", farenhait);
            Console.WriteLine("Temp in Celsius is:{0}", celsius);
        }
        static void QuadraticEquations()
        {
            Console.WriteLine("Enter A:");
            double a = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Enter b:");
            double b = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Enter c:");
            double c = Convert.ToDouble(Console.ReadLine());

            double x1 = (-b - Math.Sqrt(Math.Pow(b, 2) - 4 * a * c)) / (2 * a);
            double x2 = (-b + Math.Sqrt(Math.Pow(b, 2) - 4 * a * c)) / (2 * a);

            Console.WriteLine("x1 ={0} ", x1);
            Console.WriteLine("x2 ={0} ", x2);
        }
        static void TriangleArea()
        {
            Console.WriteLine("Please enter A:");
            double a = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Please enter C(hypotenuse):");
            double c = Convert.ToDouble(Console.ReadLine());
            double b = Math.Sqrt(Math.Pow(c, 2) - Math.Pow(a, 2));
            double area = (a * b) / 2;

            Console.WriteLine("The area of the triangle is:{0} ", Math.Round(area, 3));
        }
        static void TimeCalculator()
        {
            Console.WriteLine("How many seconds? ");
            int seconds = Convert.ToInt32(Console.ReadLine());
            double minutes = seconds / 60;
            Console.WriteLine("Minutes: {0}", minutes);
            double hours = minutes / 60;
            Console.WriteLine("Hours: {0}", hours);
            double days = hours / 24;
            Console.WriteLine("Days: {0}", days);
            double years = days / 365;
            Console.WriteLine("Years: {0}", years);

        }
        static void Pyramid()
        {
            Console.WriteLine("Enter A:");
            double a = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Enter b:");
            double b = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Enter h:");
            double h = Convert.ToDouble(Console.ReadLine());
            double v = (1.0 / 3) * (a * b * h);
            Console.WriteLine("The volume of a rectangular pyramid with sides {0} and {1} and height {2} is {3}", a, b, h, Math.Round(v, 3));
        }
        static void DiceRoll()
        {
            Console.WriteLine("Желана сума от хвърлянето на 2 зарчета: ");
            double clientSum = Convert.ToInt32(Console.ReadLine());

            if (clientSum < 2 || clientSum > 12)
            {
                Console.WriteLine("Моля въведете сума между 2 и 12");
                return;
            }

            Random random = new Random();
            int dice1 = random.Next(1, 7);
            int dice2 = random.Next(1, 7);
            int sum = dice1 + dice2;
            Console.WriteLine($"Първото хвърляне е {dice1}, второто хвърляне е {dice2} сборът им е {sum}");

            if (clientSum == sum)
            {
                Console.WriteLine("Congratulation u guessed right! ");
            }
            else
            {
                Console.WriteLine("Next time, pal...");
            }
        }
        static void Average()
        {
            Console.WriteLine("Enter A:");
            long a = Convert.ToInt64(Console.ReadLine());
            Console.WriteLine("Enter b:");
            long b = Convert.ToInt64(Console.ReadLine());
            Console.WriteLine("Enter c:");
            long c = Convert.ToInt64(Console.ReadLine());
            long average = (a + b + c) / 3;
            Console.WriteLine("The average is:{0} ", average.ToString("N4"));
        }
        static void Average2()
        {
            Console.WriteLine("Enter A:");
            int a = Convert.ToInt32(Console.ReadLine());
            if (a < 0 || a > 127)
            {
                Console.WriteLine("The number must be lower than 127 and positive number");
                return;
            }
            Console.WriteLine("Enter A:");
            int b = Convert.ToInt32(Console.ReadLine());
            if (b < 0 || b > 127)
            {
                Console.WriteLine("The number must be lower than 127 and positive number");
                return;
            }
            Console.WriteLine("Enter A:");
            int c = Convert.ToInt32(Console.ReadLine());
            if (c < 0 || c > 127)
            {
                Console.WriteLine("The number must be lower than 127 and positive number");
                return;
            }
            Console.WriteLine("Enter A:");
            int d = Convert.ToInt32(Console.ReadLine());
            if (d < 0 || d > 127)
            {
                Console.WriteLine("The number must be lower than 127 and positive number");
                return;
            }
            int average = (a + b + c + d) / 4;
            double avg = (a + b + c + d) / 4.0;
            Console.WriteLine("The average calculated with whole division is {0}", average);
            Console.WriteLine("The average calculated with decimal number division is {0}", avg);
        }
        static void Century()
        {
            Console.WriteLine("Write a year:");
            int year = Convert.ToInt32(Console.ReadLine());
            if (year < 1899)
            {
                Console.WriteLine("Before 20th century", year);
            }
            else if (year >= 1900 || year < 2000)
            {
                Console.WriteLine("During 20th century", year);
            }
            else if (year > 2000)
            {
                Console.WriteLine("After 20th century", year);
            }
        }
        static void DiceRoll2()
        {
            Console.WriteLine("Желана сума от хвърлянето на 2 зарчета: ");
            double clientSum = Convert.ToInt32(Console.ReadLine());


            if (clientSum < 2)
            {
                Console.WriteLine(" The sum of two rolls cannot be less than 2");
                return;
            }
            else if (clientSum > 12)
            {
                Console.WriteLine(" The sum of two rolls cannot be greater than 12");
                return;
            }

            Random random = new Random();
            int dice1 = random.Next(1, 7);
            int dice2 = random.Next(1, 7);
            int sum = dice1 + dice2;
            Console.WriteLine($"Първото хвърляне е {dice1}, второто хвърляне е {dice2} сборът им е {sum}");

            if (clientSum == sum)
            {
                Console.WriteLine("Congratulation u guessed right! ");
            }
            else
            {
                Console.WriteLine("Next time, pal...");
            }
        }
        static void WashingMachine()
        {
            Console.WriteLine("Pich a programme:");
            int programme = Convert.ToInt32(Console.ReadLine());

            switch (programme)
            {
                case 1:

                    Console.WriteLine("Temperature:60 degrees, Time: 125 minutes");
                    break;
                case 2:
                    Console.WriteLine("Temperature:90 degrees, Time: 106 minutes");
                    break;
                case 3:
                    Console.WriteLine("Temperature:40 degrees, Time: 98 minutes");
                    break;
                case 4:
                    Console.WriteLine("Temperature:50 degrees, Time: 65 minutes");
                    break;
                case 5:
                    Console.WriteLine("Desired temperature: ");
                    int temp = Convert.ToInt32(Console.ReadLine());
                    Console.WriteLine("Desired time: ");
                    int time = Convert.ToInt32(Console.ReadLine());
                    Console.WriteLine("Temperature:{0} degrees, Time: {1} minutes", temp, time);
                    break;
                default:
                    Console.WriteLine("No such programme");
                    break;

            }
        }
        static void Temperatures()
        {
            Console.WriteLine("Temperature: ");
            double temp = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Celsius - 1, Farenhait - 2, Kelvin - 3: ");
            int unit = Convert.ToInt32(Console.ReadLine());
            double celsius = 0;
            double farenhait = 0;
            double kelvin = 0;

            if (unit == 1)
            {
                celsius = temp;
                farenhait = ((9.0 / 5.0) * celsius) + 32;
                Console.WriteLine("Farenhait: {0}", farenhait);
                kelvin = celsius + 273.15;
                Console.WriteLine("Kelvin: {0}", kelvin);
            }
            else if (unit == 2)
            {
                farenhait = temp;
                celsius = (5.0 / 9.0) * (farenhait - 32);
                Console.WriteLine("Celsius: {0}", celsius);
                kelvin = ((5.0 / 9.0) * (farenhait - 32)) + 273.15;
                Console.WriteLine("Kelvin: {0}", kelvin);
            }
            else if (unit == 3)
            {
                kelvin = temp;
                celsius = kelvin - 273.15;
                Console.WriteLine("Celsius: {0}", celsius);
                farenhait = ((9.0 / 5.0) * (kelvin - 273.15)) + 32;
                Console.WriteLine("Farenhait: {0}", farenhait);
            }
            else
            {
                Console.WriteLine("Unsupported unit");
            }
        }
        static void Excel()
        {
            Console.WriteLine("Enter A:");
            int x = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter b:");
            int y = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter h:");
            int z = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("What function u want?  SUM, AVERAGE, MIN, MAX? ");
            string function = Console.ReadLine();
            double result = 0;
            if (function.Contains("SUM"))
            {
                result = x + y + z;
                Console.WriteLine("Result: {0}", result.ToString("0.0000"));
            }
            else if (function.Contains("AVERAGE"))
            {
                result = (x + y + z) / 3;
                Console.WriteLine("Result: {0}", result.ToString("0.0000"));
            }
            else if (function.Contains("MIN"))
            {
                int min = Math.Min(x, y);
                min = Math.Min(min, z);
                Console.WriteLine("MIN: {0}", min);
            }
            else if (function.Contains("MAX"))
            {
                int min = Math.Max(x, y);
                min = Math.Max(min, z);
                Console.WriteLine("MAX: {0}", min);
            }
            else
            {
                Console.WriteLine("Unsupported fuction");
            }

        }
        static void CoffeeMachine()
        {
            Console.WriteLine("Money: ");
            double money = Convert.ToDouble(Console.ReadLine());
            double esp = 0.50;
            double lesp = 0.60;
            double cappu = 0.85;
            double cwm = 0.90;
            double cfree = 0.60;
            Console.WriteLine("Choose from our menu:  short espresso \t(0.50)\n long espresso \t(0.60)\n  cappuccino\t(0.85)\n coffee with milk \t(0.90)\n caffeine-free \t(0.60)\n");
            Console.WriteLine("Which do you prefer 1,2,3,4,5");
            int chosed = Convert.ToInt32(Console.ReadLine());
            switch (chosed)
            {
                case 1:
                    if (money < esp)
                    {
                        Console.WriteLine("Not enough money.");
                    }
                    else
                    {
                        Console.WriteLine("Preparing your drink...");
                    }
                    break;
                case 2:
                    if (money < lesp)
                    {
                        Console.WriteLine("Not enough money.");
                    }
                    else
                    {
                        Console.WriteLine("Preparing your drink...");
                    }
                    break;
                case 3:
                    if (money < cappu)
                    {
                        Console.WriteLine("Not enough money.");
                    }
                    else
                    {
                        Console.WriteLine("Preparing your drink...");
                    }
                    break;
                case 4:
                    if (money < cwm)
                    {
                        Console.WriteLine("Not enough money.");
                    }
                    else
                    {
                        Console.WriteLine("Preparing your drink...");
                    }
                    break;
                case 5:
                    if (money < cfree)
                    {
                        Console.WriteLine("Not enough money.");
                    }
                    else
                    {
                        Console.WriteLine("Preparing your drink...");
                    }
                    break;
                default:
                    Console.WriteLine("Please select from menu. ");
                    break;
            }
        }
        static void SumIfLarger()
        {
            int sum = 0;
            int prevNum = 0;
            int currnum = 0;
            while (currnum >= prevNum)
            {
                prevNum = currnum;
                sum += prevNum;
                Console.WriteLine("Next: ");
                currnum = Convert.ToInt32(Console.ReadLine());
            }
            Console.WriteLine(sum);
        }
        static void Fibonacci()
        {

            Console.WriteLine("Limit: ");
            int limit = Convert.ToInt32(Console.ReadLine());

            int prev1 = 0;
            int prev2 = 1;
            Console.WriteLine(prev1);
            Console.WriteLine(prev2);
            int i = 0;

            for (i = 0; i < limit - 2; i++)
            {
                int curnum = prev1 + prev2;
                Console.WriteLine(curnum);
                prev1 = prev2;
                prev2 = curnum;
            }

        }
        static void ConeVolumLoop()
        {
            Console.WriteLine("Max Radius: ");
            int m = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Max Height: ");
            int n = Convert.ToInt32(Console.ReadLine());
            double v = 0;
            for (int i = 1; i <= m; i++)
            {
                for (int j = 1; j <= n; j++)
                {

                    v = (1.0 / 3) * (j * Math.PI * Math.Pow(i, 2));
                    Console.WriteLine("radius {0},height {1}", i, j);
                    Console.WriteLine("volume {0}", v.ToString("0.00"));
                }
            }
        }
        static void QuadraticEquationsLoop()
        {
            Console.WriteLine("Limit: ");
            int limit = Convert.ToInt32(Console.ReadLine());

            for (int i = 1; i <= limit; i++)
            {
                for (int j = 1; j <= limit; j++)
                {
                    for (int k = 1; k <= limit; k++)
                    {
                        Console.WriteLine("a = {0}, b = {1}, c = {2}", i, j, k);
                        double d = Math.Pow(j, 2) - 4 * i * k;
                        if (d > 0)
                        {
                            double x1 = (-j + Math.Sqrt(d)) / (2 * i);
                            double x2 = (-j - Math.Sqrt(d)) / (2 * i);
                            Console.WriteLine("x1 = {0}", x1);
                            Console.WriteLine("x2 = {0}", x2);
                        }
                        else
                        {
                            Console.WriteLine("No solution");
                        }
                    }
                }

            }
        }
        static void Capital()
        {
            Console.WriteLine("How many days? ");
            int days = Convert.ToInt32(Console.ReadLine());
            double[] price = new double[days];

            for (int i = 0; i < days; i++)
            {
                Console.WriteLine("Day{0}: ", i + 1);
                price[i] = Convert.ToDouble(Console.ReadLine());
            }

            double totalchangeOfPrice = 0;
            for (int i = 1; i < days; i++)
            {
                double priceChange = price[i] - price[i - 1];
                if (priceChange > 0)
                {
                    Console.WriteLine("UP with {0:F4}", priceChange);
                }
                else if (priceChange < 0)
                {
                    Console.WriteLine("DOWN with {0:F4}", priceChange);
                }
                else
                {
                    Console.WriteLine("Not changes");
                    totalchangeOfPrice += priceChange;
                }
            }
            double average = 0;
            for (int i = 0; i < days; i++)
            {
                average += price[i];

            }
            average = average / days;
            Console.WriteLine("Average price for the period: {0:F4}", average);
        }
        static void Unique()
        {
            Console.WriteLine("How many numbers? ");
            int count = Convert.ToInt32(Console.ReadLine());
            int[] numbers = new int[count];

            for (int i = 0; i < count; i++)
            {
                numbers[i] = Convert.ToInt32(Console.ReadLine());
            }

            for (int i = 0; i < count - 1; i++)
            {
                if (numbers[i] == 0)
                    continue;
                for (int j = i + 1; j < count; j++)
                {
                    if (numbers[i] == numbers[j])
                    {
                        Console.WriteLine("Dublicate found!");
                        numbers[j] = 0;
                    }
                }
            }
            for (int i = 0; i < count; i++)
            {
                Console.Write(numbers[i] + " ");
            }
        }
        static void BubbleSort2()
        {
            Console.WriteLine("Word: ");
            string word = Console.ReadLine();
            char[] wordAsArray = word.ToCharArray();
            Array.Sort(wordAsArray);
            string sortedWord = new string(wordAsArray);
            Console.WriteLine(sortedWord);
        }
        static void ArrayCompare()
        {
            Console.WriteLine("How many elemnts in first array? ");
            int firstArrayEl = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("How many elemnts in second array? ");
            int secondArrayEl = Convert.ToInt32(Console.ReadLine());

            int[] firstArray = new int[firstArrayEl];
            for (int i = 0; i < firstArrayEl; i++)
            {
                firstArray[i] = Convert.ToInt32(Console.ReadLine());
            }
            int[] secondArray = new int[secondArrayEl];
            for (int i = 0; i < secondArrayEl; i++)
            {
                secondArray[i] = Convert.ToInt32(Console.ReadLine());
            }

            foreach (int num1 in firstArray)
            {
                foreach (int num2 in secondArray)
                {
                    if (num1 == num2)
                    {
                        Console.WriteLine("Match:{0}", num1);
                    }
                }
            }

        }
        static void MatrixHorizontal()
        {
            Console.WriteLine("Columns: ");
            int c = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Rows: ");
            int r = Convert.ToInt32(Console.ReadLine());

            for (int i = 1; i <= c; i++)
            {
                for (int j = 1; j <= r; j++)
                {

                    Console.Write((i - 1) * c + j + " ");
                }
                Console.WriteLine();
            }
        }
        static void ReverseWord()
        {
            Console.WriteLine("Word to be reversed: ");
            string word = Console.ReadLine();
            char[] reverse = word.ToCharArray();
            Array.Reverse(reverse);
            string reversedWord = new string(reverse);
            Console.WriteLine(reversedWord);
        }
        static void Excel3()
        {
            int[] array = new int[5];
            int count = 0;
            while (true)
            {
                int number = Convert.ToInt32(Console.ReadLine());
                if (number < 0)
                    break;
                if (count == array.Length)
                {
                    Array.Resize(ref array, array.Length + 1);
                }
                array[count] = number;
                count++;
            }


            int sum = 0;
            double average = 0.0;
            int min = int.MaxValue;
            int max = int.MinValue;
            

            for (int i = 0; i < count; i++)
            {
                if (array[i] == 0)
                    continue;
                sum = sum + array[i];
                average = sum / count;
                if (array[i] < min)
                
                    min = array[i];
                
                if (array[i] > max)
                
                    max = array[i];
                
            }
            Console.WriteLine("SUM = {0}, AVERAGE= {1}, COUNT= {2}, MIN= {3}, MAX= {4}", sum, average, count, min, max);
        }
    }
}
