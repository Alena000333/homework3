// Напишите программу, которая принимает на вход пятизначное число и проверяет, является ли оно палиндромом.

// 14212 -> нет

// 12821 -> да

// 23432 -> да

void Number ( int num )
{
int n1 = num/10000;
Console.WriteLine($" {n1} ");
int n2 = (num/10)%10;
Console.WriteLine($" {n2} ");
int n4 = (num%100)/10;
Console.WriteLine($" {n4} ");
int n5 = num%10;
Console.WriteLine($" {n5} ");
if (n1==n5)
{
if(n2==n4)
{
Console.WriteLine(" число париндром ");
}
else{
Console.WriteLine( "число не палиндром " );
}

}
else
{
Console.Write (" число не палиндром" );
}
}

Console.WriteLine(" Введите число: ");
int x = Convert.ToInt32(Console.ReadLine() );
Number(x);
