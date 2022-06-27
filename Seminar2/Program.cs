int number = new Random().Next(10, 100);
//Console.Writeline(number);
int num1 = number / 10;
int num2 = number % 10;
Console.Writeline(number + num1 + num2);