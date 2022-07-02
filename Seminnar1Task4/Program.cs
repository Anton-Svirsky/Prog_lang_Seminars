Console.Write("Input number: ");
int number = Convert.ToInt32(Console.ReadLine());
string even_numbers = " - > ";
for (int count = 1; count <= number; count++)
    if (count == count % 2)
    {
    count = count + count;
    even_numbers = even_numbers + count + ", ";
    }
Console.WriteLine(number + even_numbers);