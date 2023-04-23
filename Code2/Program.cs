// See https://aka.ms/new-console-template for more information
Console.WriteLine("Hello, World!");
// Максимальное из трех чисел
Console.Write("Первое число (a:)");
int i = int.Parse(Console.ReadLine());

Console.Write("Второе число (b:)");
int k = int.Parse(Console.ReadLine());

Console.Write("Третье число (с:)");
int l = int.Parse(Console.ReadLine());

int max =i;

if(i>max) max = i ;
if(k>max) max = k;
if(l>max) max = l;
{
Console.Write("max=");    
Console.WriteLine (max);
}