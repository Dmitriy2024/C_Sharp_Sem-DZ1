// Программа которая на входе принемает два числа и выдает, какое число большее,  а какое меньшее.
Console.Write("Введите первое число:  ");
int numberOne = Convert.ToInt32(Console.ReadLine());

Console.Write("Введите второе число:  ");
int numberTwo = Convert.ToInt32(Console.ReadLine());

int numberMax = numberOne;

if(numberMax > numberTwo) 
{
    Console.WriteLine("Первое число " + numberOne + " больше второго числа " + numberTwo);
     
    Console.WriteLine("max=" + numberOne + "  min=" + numberTwo);
}
else 
{
    Console.WriteLine("Второе число " + numberTwo + " больше первого числа " + numberOne);
    Console.WriteLine("min=" + numberOne + "  max=" + numberTwo);
    
}
 


/*
// Программу, которая принимает на вход три числа и выдаёт максимальное из этих чисел.

Console.Write("Введите первое число:  ");
int numberOne = Convert.ToInt32(Console.ReadLine());

Console.Write("Введите второе число:  ");
int numberTwo = Convert.ToInt32(Console.ReadLine());

Console.Write("Введите тертье число:  ");
int numberThree = Convert.ToInt32(Console.ReadLine());

int numberMax = numberOne;

if(numberMax > numberTwo)
{
    if(numberMax > numberThree)
    {
       Console.WriteLine("Наиболтшее чиcло №1 " + numberOne);
    }
    else 
    {
    Console.WriteLine("Наиболтшее чиcло №3  " + numberThree);
    }

}
else
{
     numberMax = numberTwo;

   if(numberMax > numberThree)
   {
    Console.WriteLine("Наиболтшее чиcло №2 " + numberTwo);
   }
   else 
   {
    Console.WriteLine("Наиболтшее чиcло №3 " + numberThree);
   }
}
*/

/*
//Программа, которая на вход принимает число и выдаёт, является ли число чётным (делится ли оно на два без остатка).
Console.Write("Введите число:  ");
int numberOne = Convert.ToInt32(Console.ReadLine());
if(numberOne%2 == 0)
{
    Console.WriteLine("Введенное чесло " + numberOne + " четное");
}
else
{
    Console.WriteLine("Введенное чесло " + numberOne + " нечетное");
}
*/

/*
//Программу, которая на вход принимает число (N), а на выходе показывает все чётные числа.
Console.Write("Введите число:  ");
int n = Convert.ToInt32(Console.ReadLine());
int a = 1;
while ( n < a )
{
    Console.Write(a);
    a++;
    Console.Write(a);
}
Console.Write(a);
*/


/*
//Ппрограмма, которая на вход принимает число (N), а на выходе показывает все чётные числа от 1 до N.
Console.Write("Введите число:  ");
int N = Convert.ToInt32(Console.ReadLine());
int i = 1;
while ( N >= i )
{
    if(i%2 == 0)
    {
    Console.Write(i + ",");
    i++;
    }
    else
    {
        i++;
    }
}
*/
