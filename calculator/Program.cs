
//calculator

int calculatorchoice;
char answer;
try
{
    do
    {
        Console.WriteLine("Welcome To Multifunction Caculator \n");
        Console.WriteLine("Choose your calculator choice ");
        Console.WriteLine("1. Normal calculator");
        Console.WriteLine("2. Scientific calculator \n");
        Console.Write("Enter your choice : ");

        calculatorchoice = Convert.ToInt32(Console.ReadLine());
        if (calculatorchoice == 1)
        {
            normalcalculator();
        }
        else if (calculatorchoice == 2)
        {
            scicalculator();
        }
        else
        {
            Console.WriteLine("invalid choice");
        }

        void normalcalculator()
        {
            int choice;
            Console.WriteLine("\n You have selected the normal calculator");
            Console.WriteLine("\n Available Operations \n");
            Console.WriteLine("1. Addition");
            Console.WriteLine("2. Subtraction");
            Console.WriteLine("3. Multiplication");
            Console.WriteLine("4. Divison \n");
            choice = Convert.ToInt32(Console.ReadLine());
            Console.Write("enter your first number : ");
            double num1 = Convert.ToDouble(Console.ReadLine());
            Console.Write("enter your second number : ");
            double num2 = Convert.ToDouble(Console.ReadLine());

            double result;

            switch (choice)
            {
                case 1:
                    Console.WriteLine("You selected Addition");
                    result = num1 + num2;
                    Console.Write($"Result : {result}");
                    break;
                case 2:
                    Console.WriteLine("You selected Subtraction");
                    result = num2 - num1;
                    Console.Write($"Result : {result}");
                    break;
                case 3:
                    Console.WriteLine("You selected  Multiplication");
                    result = num1 * num2;
                    Console.Write($"Result : {result}");
                    break;
                case 4:
                    Console.WriteLine("You selected Divison");
                    if (num2 != 0)
                    {
                        result = num2 / num1;
                        Console.Write($"Result : {result}");
                    }
                    else
                    {
                        Console.WriteLine("Divison by zero is not allowed");
                    }
                    break;
                default:
                    Console.WriteLine("invalid choice");
                    break;
            }
        }

        void scicalculator()
        {
            int choice;
            Console.WriteLine("\n You have selected the scientific calculator");
            Console.WriteLine("\n Available Operations \n");
            Console.WriteLine("1. Addition (+)");
            Console.WriteLine("2. Subtraction (-)");
            Console.WriteLine("3. Multiplication (*)");
            Console.WriteLine("4. Divison (/)");
            Console.WriteLine("5. Power (x^y)");
            Console.WriteLine("6. Square Root (x)");
            Console.WriteLine("7. Logarithm (log)");
            Console.WriteLine("8. Sine (sin) ");
            Console.WriteLine("9. Cosine (cos)");
            Console.WriteLine("10. Tangent (tan) \n");
            choice = Convert.ToInt32(Console.ReadLine());

            double result;
            int num1;
            int num2;
            switch (choice)
            {
                case 1:
                    Console.WriteLine("You selected Addition");
                    Console.Write("Enter your first number : ");
                    num1 = Convert.ToInt32(Console.ReadLine());
                    Console.Write("Enter your second number : ");
                    num2 = Convert.ToInt32(Console.ReadLine());
                    result = num1 + num2;
                    Console.Write($"Result : {result} ");
                    break;
                case 2:
                    Console.WriteLine("You selected Subraction");
                    Console.Write("Enter your first number : ");
                    num1 = Convert.ToInt32(Console.ReadLine());
                    Console.Write("Enter your second number : ");
                    num2 = Convert.ToInt32(Console.ReadLine());
                    result = num1 - num2;
                    Console.Write($"Result : {result}");
                    break;
                case 3:
                    Console.WriteLine("You selected Multiplication");
                    Console.Write("Enter your first number : ");
                    num1 = Convert.ToInt32(Console.ReadLine());
                    Console.Write("Enter your second number : ");
                    num2 = Convert.ToInt32(Console.ReadLine());
                    result = num1 * num2;
                    Console.Write($"Result : {result}");
                    break;
                case 4:
                    Console.WriteLine("You selected  Divison");
                    Console.Write("Enter your first number : ");
                    num1 = Convert.ToInt32(Console.ReadLine());
                    Console.Write("Enter your second number : ");
                    num2 = Convert.ToInt32(Console.ReadLine());
                    if (num2 != 0)
                    {
                        result = num1 / num2;
                        Console.Write($"Result : {result}");
                    }
                    else
                    {
                        Console.WriteLine("Divison by zero is not allowed");
                    }
                    break;
                case 5:
                    Console.WriteLine("You selected Power");
                    Console.Write("Enter the base number : ");
                    num1 = Convert.ToInt32(Console.ReadLine());
                    Console.Write("Enter your exponent : ");
                    num2 = Convert.ToInt32(Console.ReadLine());
                    result = Math.Pow(num1, num2);
                    Console.Write($"Result : {result}");
                    break;
                case 6:
                    Console.WriteLine("You selected Square Root");
                    Console.Write("Enter the number : ");
                    num1 = Convert.ToInt32(Console.ReadLine());
                    result = Math.Sqrt(num1);
                    Console.Write($"Result : {result}");
                    break;
                case 7:
                    Console.WriteLine("You selected Logarithm");
                    Console.Write("Enter the number : ");
                    num1 = Convert.ToInt32(Console.ReadLine());
                    if (num1 > 0)
                    {
                        result = Math.Log10(num1);
                        Console.Write($"Result : {result}");
                    }
                    else
                    {
                        Console.WriteLine("Enter the posotive number for base 10 logarithm");
                    }
                    break;
                case 8:
                    Console.WriteLine("You selected Sine");
                    Console.Write("Enter the number : ");
                    num1 = Convert.ToInt32(Console.ReadLine());
                    result = Math.Sin(num1);
                    Console.Write($"Result : {result}");
                    break;
                case 9:
                    Console.WriteLine("You selected Cosine");
                    Console.Write("Enter the number : ");
                    num1 = Convert.ToInt32(Console.ReadLine());
                    result = Math.Cos(num1);
                    Console.Write($"Result : {result}");
                    break;
                case 10:
                    Console.WriteLine("You selected Tangent");
                    Console.Write("Enter the number : ");
                    num1 = Convert.ToInt32(Console.ReadLine());
                    result = Math.Tan(num1);
                    Console.Write($"Result : {result}");
                    break;
                default:
                    Console.Write("invalid choice");
                    break;
            }

        }
        Console.Write(" \n Do you want to use calculator again? enter Y for continue and N for exit :  ");
        answer = char.Parse(Console.ReadLine());
    }


    while (answer == 'y' || answer == 'Y');

    Console.WriteLine("ThankYou for using Multifunction Calculator.");
}
catch (FormatException)
{
    Console.WriteLine("invalid Try again.");
}