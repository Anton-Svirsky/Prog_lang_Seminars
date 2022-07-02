Console.Write("Input number1: ");
int number1 = Convert.ToInt32(Console.ReadLine());
Console.Write("Input number2: ");
int number2 = Convert.ToInt32(Console.ReadLine());
if (number1 > number2)
    Console.WriteLine("number1 = " + number1 + ", number2 = " + number2 + " - > max = " + number1);
else if (number1 == number2)
    Console.WriteLine("number1 = " + number1 + ", number2 = " + number2 + " - > there is no max");
else
    Console.WriteLine("number1 = " + number1 + ", number2 = " + number2 + " - > max = " + number2);