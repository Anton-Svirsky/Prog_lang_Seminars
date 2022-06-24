Console.Write("Input number: ");
int number = Convert.ToInt32(Console.ReadLine());
int oneline = 0;
for (int count = 1; count < number; count++)
{
    if(count % 2 == 0)
    {
        oneline = count;
    }
}
 Console.WriteLine(number + " - > " + oneline);