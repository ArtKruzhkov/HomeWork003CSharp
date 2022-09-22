// Console.WriteLine("Enter number ");
// int N = int.Parse(Console.ReadLine()!);
// string X = N.ToString();
// int lenght = X.Length;
// int index = 0;
// while(index < lenght / 2)
// {
//     if(X[index] == X[lenght -1 - index])
//     {
//         Console.WriteLine("palidrom");
//     }
//     else
//     {
//         Console.WriteLine("not palidrom");
//     }
//     index++;
// } //не знаю как написать код верно, чтобы выдывал только 1 раз что число палидром или нет, видел решение в интернетах через функцию 
// и return true или false но сам не знаю как это написать поэтому не стал. Этот код проверяет первое число с последним, 2ое с предпоследним
// и так до середины числа, если хоть одно число будет не равно, то выведет надпись not polidrom, и если хоть 1 такой вывод есть, то число 
// НЕ является палидромом. Если есть выводы ТОЛЬКО palidrom, то число является палидромом.

// Console.WriteLine("Enter X1 ");
// int x1 = int.Parse(Console.ReadLine()!);
// Console.WriteLine("Enter Y1 ");
// int y1 = int.Parse(Console.ReadLine()!);
// Console.WriteLine("Enter Z1 ");
// int z1 = int.Parse(Console.ReadLine()!);
// Console.WriteLine("Enter X2 ");
// int x2 = int.Parse(Console.ReadLine()!);
// Console.WriteLine("Enter Y2 ");
// int y2 = int.Parse(Console.ReadLine()!);
// Console.WriteLine("Enter Z2 ");
// int z2 = int.Parse(Console.ReadLine()!);
// double result = Math.Sqrt(Math.Pow(x2 - x1, 2) + Math.Pow(y2 - y1, 2) + Math.Pow(z2 - z1, 2));
// Console.WriteLine($"distance = {result:f2}");

// Console.WriteLine("Enter number ");
// int N = int.Parse(Console.ReadLine()!);
// for(int index = 1; index <= N; index++)
// {
//     double result = Math.Pow(index, 3);
//     Console.Write(result + " ");
// }