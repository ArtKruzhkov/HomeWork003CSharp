Console.WriteLine("Enter 5 digits number ");
int N = int.Parse(Console.ReadLine()!);
int num1 = N / 10000;
int num2 = N % 10;
int num3 = N / 1000;
int num4 = num3 % 10;
int num5 = N / 10;
int num6 = num5 % 10;
if((num1 == num2)&&(num4 == num6))
{
    Console.WriteLine("palidrom");
}
else
{
    Console.WriteLine("Not palidrom");
}