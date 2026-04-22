using System;

class Program
{
    static void Main()
    {
        Console.Write("Nombre: ");
        string nom = Console.ReadLine();
        Console.WriteLine("Hola " + nom);
        Console.WriteLine();

        Console.WriteLine("=== 1 ===");
        notas();
        Console.WriteLine();

        Console.WriteLine("=== 2 ===");
        Console.Write("Num: ");
        int n = int.Parse(Console.ReadLine());
        rango(n);
        Console.WriteLine();

        Console.WriteLine("=== 3 ===");
        tienda();
        Console.WriteLine();

        Console.WriteLine("=== 4 ===");
        nums();
        Console.WriteLine();

        Console.WriteLine("=== 5 ===");
        Console.Write("N: ");
        int x = int.Parse(Console.ReadLine());
        tri(x);
    }

    static void notas()
    {
        int[] a = new int[10];
        int s = 0, ap = 0;

        for (int i = 0; i < 10; i++)
        {
            Console.Write("Nota " + (i + 1) + ": ");
            a[i] = int.Parse(Console.ReadLine());
            s += a[i];
            if (a[i] >= 61) ap++;
        }

        double p = (double)s / 10;
        Console.WriteLine("Prom: " + p);
        Console.WriteLine("Aprob: " + ap);
        Console.WriteLine("Reprob: " + (10 - ap));
    }

    static void rango(int n)
    {
        int s = 0, pa = 0, im = 0;

        for (int i = 1; i <= n; i++)
        {
            s += i;
            if (i % 2 == 0) pa++;
            else im++;
        }

        Console.WriteLine("Suma: " + s);
        Console.WriteLine("Pares: " + pa);
        Console.WriteLine("Impares: " + im);
    }

    static void tienda()
    {
        double t = 0;
        int c = 0, op;

        do
        {
            Console.WriteLine("\n1) Compra");
            Console.WriteLine("2) Total");
            Console.WriteLine("3) Clientes");
            Console.WriteLine("4) Salir");
            Console.Write("Op: ");
            op = int.Parse(Console.ReadLine());

            if (op == 1)
            {
                Console.Write("Monto: ");
                double m = double.Parse(Console.ReadLine());
                t += m;
                c++;
                Console.WriteLine("OK");
            }
            else if (op == 2)
            {
                Console.WriteLine("Total: " + t);
            }
            else if (op == 3)
            {
                Console.WriteLine("Clientes: " + c);
            }
            else if (op == 4)
            {
                Console.WriteLine("Bye");
            }
            else
            {
                Console.WriteLine("Error");
            }

        } while (op != 4);
    }

    static void nums()
    {
        int cant = 0, pos = 0, neg = 0, s = 0, n;

        Console.WriteLine("Nums (0 para salir):");
        do
        {
            n = int.Parse(Console.ReadLine());
            if (n != 0)
            {
                cant++;
                s += n;
                if (n > 0) pos++;
                else neg++;
            }
        } while (n != 0);

        Console.WriteLine("Cant: " + cant);
        Console.WriteLine("Pos: " + pos);
        Console.WriteLine("Neg: " + neg);
        Console.WriteLine("Suma: " + s);
    }

    static void tri(int n)
    {
        for (int i = 1; i <= n; i++)
        {
            for (int j = 1; j <= i; j++)
            {
                Console.Write(j);
            }
            Console.WriteLine();
        }
    }
}