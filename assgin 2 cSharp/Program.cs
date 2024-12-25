namespace assgin_2_cSharp
{
    internal class Program
    {
        static void Main(string[] args)
        {
        //    #region Question 1
        //    bool isValidInput;
        //    int inputNumber;
        //    do
        //    {
        //        Console.WriteLine("Enter a Number:");
        //        isValidInput = int.TryParse(Console.ReadLine(), out inputNumber);
        //    } while (!isValidInput);

        //    if (inputNumber % 2 == 0 && inputNumber % 5 == 0)
        //    {
        //        Console.WriteLine("YES");
        //    }
        //    else
        //    {
        //        Console.WriteLine("NO");
        //    }
        //    #endregion

        //    #region Question 2          
        //    do
        //    {
        //        Console.WriteLine("Enter a Number:");
        //        isValidInput = int.TryParse(Console.ReadLine(), out inputNumber);
        //    } while (!isValidInput);

        //    if (inputNumber > 0)
        //    {
        //        Console.WriteLine("Positive");
        //    }
        //    else if (inputNumber < 0)
        //    {
        //        Console.WriteLine("Negative");
        //    }
        //    else
        //    {
        //        Console.WriteLine("Zero");
        //    }
        //    #endregion

        //    #region Question 3      
        //    int num1, num2, num3;
        //    do
        //    {
        //        Console.WriteLine("Enter three numbers:");
        //        isValidInput = int.TryParse(Console.ReadLine(), out num1) &&
        //                       int.TryParse(Console.ReadLine(), out num2) &&
        //                       int.TryParse(Console.ReadLine(), out num3);
        //    } while (!isValidInput);

        //    int max = Math.Max(num1, Math.Max(num2, num3));
        //    int min = Math.Min(num1, Math.Min(num2, num3));

        //    Console.WriteLine($"Max: {max}, Min: {min}");
        //    #endregion

        //    #region Question 4
        //    do
        //    {
        //        Console.WriteLine("Enter a Number:");
        //        isValidInput = int.TryParse(Console.ReadLine(), out inputNumber);
        //    } while (!isValidInput);

        //    Console.WriteLine(inputNumber % 2 == 0 ? "Even" : "Odd");
        //    #endregion

        //    #region Question 5
        //    char character;
        //    do
        //    {
        //        Console.WriteLine("Enter a Character:");
        //        isValidInput = char.TryParse(Console.ReadLine(), out character);
        //    } while (!isValidInput);

        //    character = char.ToLower(character);
        //    if ("aeiou".Contains(character))
        //    {
        //        Console.WriteLine("Vowel");
        //    }
        //    else
        //    {
        //        Console.WriteLine("Consonant");
        //    }
        //    #endregion

        //    #region Question 6
        //    do
        //    {
        //        Console.WriteLine("Enter a Number:");
        //        isValidInput = int.TryParse(Console.ReadLine(), out inputNumber);
        //    } while (!isValidInput);

        //    if (inputNumber > 0)
        //    {
        //        for (int i = 1; i <= inputNumber; i++)
        //        {
        //            Console.WriteLine(i);
        //        }
        //    }
        //    else
        //    {
        //        for (int i = inputNumber; i <= 1; i++)
        //        {
        //            Console.WriteLine(i);
        //        }
        //    }
        //    #endregion

        //    #region Question 07
        //    do
        //    {
        //        Console.WriteLine("Enter a Number:");
        //        isValidInput = int.TryParse(Console.ReadLine(), out inputNumber);
        //    } while (!isValidInput);

        //    for (int i = 1; i <= 12; i++)
        //    {
        //        Console.WriteLine($"{inputNumber} x {i} = {inputNumber * i}");
        //    }
        //    #endregion

        //    #region Question 08
        //    do
        //    {
        //        Console.WriteLine("Enter a Number:");
        //        isValidInput = int.TryParse(Console.ReadLine(), out inputNumber);
        //    } while (!isValidInput);

        //    if (inputNumber > 0)
        //    {
        //        for (int i = 1; i <= inputNumber; i++)
        //        {
        //            if (i % 2 == 0)
        //            {
        //                Console.WriteLine(i);
        //            }
        //        }
        //    }
        //    else
        //    {
        //        for (int i = inputNumber; i <= 1; i++)
        //        {
        //            if (i % 2 == 0)
        //            {
        //                Console.WriteLine(i);
        //            }
        //        }
        //    }
        //    #endregion

        //    #region Question 09
        //    int baseNum, exponent;
        //    do
        //    {
        //        Console.WriteLine("Enter Base:");
        //        isValidInput = int.TryParse(Console.ReadLine(), out baseNum);
        //        Console.WriteLine("Enter Exponent:");
        //        isValidInput = isValidInput && int.TryParse(Console.ReadLine(), out exponent);
        //    } while (!isValidInput);

        //    double result = Math.Pow(baseNum, exponent);
        //    Console.WriteLine($"{baseNum} ^ {exponent} = {result}");
        //    #endregion

        //    #region Question 10
        //    double total = 0, average, percentage;
        //    for (int i = 1; i <= 5; i++)
        //    {
        //        double mark;
        //        do
        //        {
        //            Console.WriteLine($"Enter marks for Subject {i} (0-100):");
        //            isValidInput = double.TryParse(Console.ReadLine(), out mark) && mark >= 0 && mark <= 100;
        //        } while (!isValidInput);
        //        total += mark;
        //    }

        //    average = total / 5;
        //    percentage = (total / 500) * 100;
        //    Console.WriteLine($"Total: {total}, Average: {average}, Percentage: {percentage}%");
        //    #endregion

        //    #region Question 11
        //    int month;
        //    do
        //    {
        //        Console.WriteLine("Enter Month Number (1-12):");
        //        isValidInput = int.TryParse(Console.ReadLine(), out month) && month >= 1 && month <= 12;
        //    } while (!isValidInput);

        //    switch (month)
        //    {
        //        case 1:
        //        case 3:
        //        case 5:
        //        case 7:
        //        case 8:
        //        case 10:
        //        case 12:
        //            Console.WriteLine("31 days");
        //            break;
        //        case 2:
        //            Console.WriteLine("28 or 29 days");
        //            break;
        //        default:
        //            Console.WriteLine("30 days");
        //            break;
        //    }
        //    #endregion

        //    #region Question 12
        //    int num1Calc, num2Calc;
        //    char operation;
        //    do
        //    {
        //        Console.WriteLine("Enter First Number:");
        //        isValidInput = int.TryParse(Console.ReadLine(), out num1Calc);
        //        Console.WriteLine("Enter an Operator (+, -, *, /):");
        //        isValidInput = isValidInput && char.TryParse(Console.ReadLine(), out operation);
        //        Console.WriteLine("Enter Second Number:");
        //        isValidInput = isValidInput && int.TryParse(Console.ReadLine(), out num2Calc);
        //    } while (!isValidInput);

        //    switch (operation)
        //    {
        //        case '+':
        //            Console.WriteLine($"{num1Calc} + {num2Calc} = {num1Calc + num2Calc}");
        //            break;
        //        case '-':
        //            Console.WriteLine($"{num1Calc} - {num2Calc} = {num1Calc - num2Calc}");
        //            break;
        //        case '*':
        //            Console.WriteLine($"{num1Calc} * {num2Calc} = {num1Calc * num2Calc}");
        //            break;
        //        case '/':
        //            if (num2Calc != 0)
        //            {
        //                Console.WriteLine($"{num1Calc} / {num2Calc} = {(double)num1Calc / num2Calc}");
        //            }
        //            else
        //            {
        //                Console.WriteLine("Division by zero is not allowed.");
        //            }
        //            break;
        //        default:
        //            Console.WriteLine("Invalid operator.");
        //            break;
        //    }
        //    #endregion
        }
    }
}
