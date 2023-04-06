// Задача 64: Задайте значение N. Напишите программу, которая выведет все натуральные числа в промежутке от N до 1.
//  Выполнить с помощью рекурсии.

// N = 5 -> "5, 4, 3, 2, 1"
// N = 8 -> "8, 7, 6, 5, 4, 3, 2, 1"



// Console.WriteLine("Введите число");
// int num =int.Parse(Console.ReadLine());

// int count =num;

// int PrintNumber()
// {
// if(count==0)
// {
// return count;
// }

// Console.Write(count+" ");

// count--;

// return (PrintNumber());
// }

// PrintNumber();


// Задача 64 (с изменениями преподователя по записи семинара): Задайте значения M и N.
//  Напишите программу, которая выведет все вещественные числа в промежутке от M до N с шагом 0.5.
// M = 1; N = 5 -> "1, 2, 3, 4, 5"
// M = 4; N = 8 -> "4, 6, 7, 8"


// Console.WriteLine("Введите число M");
// double M =int.Parse(Console.ReadLine());
// Console.WriteLine("Введите число N");
// double N =int.Parse(Console.ReadLine());


// double PrintNumber()
// {
// if(M>N)
// {
// return M;
// }

// Console.Write(M+" ");

// M=M+0.5;

// return (PrintNumber());
// }

// PrintNumber();



// Задача 66: Задайте значения M и N. Напишите программу, которая найдёт сумму натуральных элементов в промежутке от M до N.

// M = 1; N = 15 -> 120
// M = 4; N = 8. -> 30

// Console.WriteLine("Введите число M");
// int M =int.Parse(Console.ReadLine());
// Console.WriteLine("Введите число N");
// int N =int.Parse(Console.ReadLine());
// int sum=0;
// int count=M;

// int PrintNumber()
// {
// if(count>N)
// {
// return count;
// }

// sum=sum+count;

// count++;

// return (PrintNumber());
// }
// PrintNumber();
// Console.WriteLine("M="+M+" N="+N+" -> "+sum);



// Задача 68: Напишите программу вычисления функции Аккермана с помощью рекурсии. Даны два неотрицательных числа m и n.
// m = 2, n = 3 -> A(m,n) = 9
// m = 3, n = 2 -> A(m,n) = 29


// Функция Аккермана — простой пример вычислимой функции, которая не является примитивно рекурсивной.
// Она обозначается A(m,n), принимает два неотрицательных целых числа в качестве параметров и возвращает натуральное число. 
// Эта функция растёт очень быстро, например, число A(4,4) настолько велико, 
// что количество цифр в порядке этого числа многократно превосходит количество атомов в наблюдаемой части Вселенной.

// Функция Аккермана определяется рекурсивно для неотрицательных целых чисел m и n следующим образом:

//                               условия:
//          / n+1,               m=0;
//         |
// A(m,n)=<   A(m-1,1),          m>0,n=0;
//         |
//          \ A(m-1,A(m,n-1)),   m>0,n>0;

Console.WriteLine("Введите число M");
int M =int.Parse(Console.ReadLine());
Console.WriteLine("Введите число N");
int N =int.Parse(Console.ReadLine());
int Akerman(int M, int N)
		{
			if(M == 0)
			{
				return N + 1;
			}
			else if((M > 0) && (N == 0))
			{
				return Akerman(M - 1, 1);
			}
			else
      {
        return Akerman(M - 1, Akerman(M, N - 1));
		  }
    }
		
		Console.WriteLine(Akerman(M,N));
	