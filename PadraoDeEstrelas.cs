/*Padrões de Estrela em C#
Padrão 1
********
*******
******
*****
****
***
**
*
*/
public class Program
{
 
    public static void Main(string[] args)
    {
        for (int linha = 8; linha >= 1; --linha)
        {
            for (int coluna = 1; coluna <= linha; ++coluna)
            {
                Console.Write("*");
            }
 
            Console.WriteLine();
        }
    }
}
/*
Padrão 2
*
**
***
****
*****
******
*******
********
*/
public class Program
{
 
    public static void Main(string[] args)
    {
        for (int linha = 1; linha <= 8; ++linha)
        {
            for (int coluna = 1; coluna <= linha; ++coluna)
            {
                Console.Write("*");
            }
 
            Console.WriteLine();
        }
    }
}
/*
Padrão 3

*/
public class Program
{
 
    public static void Main()
    {
        int numero, i, k, count = 1;
        Console.WriteLine("Informe o número de Linhas: ");
        numero = int.Parse(Console.ReadLine());
        count = numero - 1;
        for (k = 1; k <= numero; k++)
        {
            for (i = 1; i <= count; i++)
                Console.Write(" ");
            count--;
            for (i = 1; i <= 2 * k - 1; i++)
                Console.Write("*");
            Console.WriteLine();
        }
        count = 1;
        for (k = 1; k <= numero - 1; k++)
        {
            for (i = 1; i <= count; i++)
                Console.Write(" ");
            count++;
            for (i = 1; i <= 2 * (numero - k) - 1; i++)
                Console.Write("*");
            Console.WriteLine();
        }
        Console.ReadLine();
    }
}
/*
Padrão 4
*/
public class Program
{
    public static void Main(string[] args)
    {
        int val = 8;
        int i, j, k;
        for (i = 1; i <= val; i++)
        {
            for (j = 1; j <= val - i; j++)
            {
                Console.Write(" ");
            }
            for (k = 1; k <= i; k++)
            {
                Console.Write("*");
            }
            Console.WriteLine("");
        }
        Console.ReadLine();
    }
}
/*
Padrão 5
* *
** **
*** ***
**** ****
***** *****
****** ******
******* *******
******** ********
*/
public class Program
{
    public static void Main(string[] args)
    {
        int numero = 8;
 
        for (int i = 0; i < numero; ++i)
        {
            for (int j = 0; j <= i; ++j)
            {
                Console.Write("*");
            }
 
            if (i != numero - 1)
            {
                Console.Write(" ");
            }
            else
            {
                Console.Write(" * ");
            }
            for (int j = 0; j <= i; ++j)
            {
                Console.Write("*");
            }
 
            Console.WriteLine();
        }
    }
}
/*
Padrão 6
*/
public class Program
{
    public static void Main(string[] args)
    {
        int numero = 7;
 
        for (int i = 0; i < numero; i++)
        {
            if (i == 0 || i == 6)
            {
                for (int j = 0; j < numero; j++)
                {
                    Console.Write("*");
                }
                Console.WriteLine();
            }
            if (i >= 1 && i <= 5)
            {
                for (int j = 0; j < numero; j++)
                {
                    if (j == 0 || j == 6)
                    {
                        Console.Write("*");
                    }
                    else if (j >= 1 && j <= 5)
                    {
                        Console.Write(" ");
                    }
                }
                Console.WriteLine();
            }
        }
 
    }
}
/*
Padrão 7
*/
public class Program
{
    static void estrelas(int count)
{
    for (int i = 0; i < count; ++i)
        Console.Write("*");
}
 
static void espacos(int count)
{
    for (int i = 0; i < count; ++i)
        Console.Write(" ");
}
    public static void Main(string[] args)
    {
 
        int n = 8;
 
        for (int i = 0; i < n; ++i)
        {
            estrelas(i + 1);
            espacos(n - i - 1);
            estrelas(n - i + 1);
            espacos(2 * i);
            estrelas(n - i);
            espacos(n - i - 1);
            estrelas(i + 1);
 
            Console.WriteLine();
        }
 
    }
}
//Codigo feito baseado nos exercicios do Site: http://www.csharpstar.com/
