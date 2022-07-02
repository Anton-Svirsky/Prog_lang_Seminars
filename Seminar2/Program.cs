void randomNumber(int min, int max){
   int number = new Random().Next(min, max+1);
   Console.Write(number + " -> ");
    if (number / 10 > number % 10){
       Console.WriteLine(number / 10);
    }
    else{
       Console.WriteLine(number % 10);
    }
}

Console.WriteLine("Введите минимальное число диапазона: ");
int start = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите максимальное число диапазона: ");
int end = Convert.ToInt32(Console.ReadLine());
randomNumber(start, end);


