// Задача 2

// System.Console.WriteLine("enter your number: ");
// int a = Convert.ToInt32(Console.ReadLine());
// System.Console.WriteLine("enter your number: ");
// int b = Convert.ToInt32(Console.ReadLine());

// example 1
// if(a > b)
// {
//     System.Console.WriteLine($"The higher number is: {a}, the lower number is: {b} ");
// }
// else
// {
//     System.Console.WriteLine($"The higher number is: {b}, the lower number is: {a}");
// }

// example 2 

// if(a > b)
// {
//     System.Console.WriteLine($"a = {a}; b = {b} -> max = {a}, min = {b}");
// }
// else
// {
//     System.Console.WriteLine($"a = {a}; b = {b} -> max = {b}, min = {a}");
// }

// Задача 4

// System.Console.WriteLine("enter your number: ");
// int a = Convert.ToInt32(Console.ReadLine());
// System.Console.WriteLine("enter your number: ");
// int b = Convert.ToInt32(Console.ReadLine());
// System.Console.WriteLine("enter your number: ");
// int c = Convert.ToInt32(Console.ReadLine());

// if(a > b && a > c)
// {
//     System.Console.WriteLine($"{a},{b},{c} -> {a}");
// } 
// else if(b > a && b > c) 
// {
//     System.Console.WriteLine($"{a},{b},{c} -> {b}");
// }
// else 
// {
//     System.Console.WriteLine($"{a},{b},{c} -> {c}");
// }

// задача 6

// System.Console.Write("enter number: ");
// int a = Convert.ToInt32(Console.ReadLine());

// if(a%2 == 0)
// {
//     System.Console.WriteLine($"{a} -> yes ");
// }
// else
// {
//     System.Console.WriteLine($"{a} -> no");
// }

// задача 8

System.Console.WriteLine("enter an integer N: ");
int n = Convert.ToInt32(Console.ReadLine());
System.Console.Write($"{n} -> \"");
int i = 1;
for(;i < n;i++)
{
    if(i%2 == 0){
        System.Console.Write($"{i},");
    }
}
System.Console.Write("\"");