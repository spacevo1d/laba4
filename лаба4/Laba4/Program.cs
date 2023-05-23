// See https://aka.ms/new-console-template for more information
using Laba4;

double[] c = { 1, 2, 3, 4, 5 };
Vektor a = new Vektor(c);
a.append(7);
Console.WriteLine(a);
a.append(5, 6);
Console.WriteLine(a);
a.delete();
Console.WriteLine(a);
a.deleteIn(2);
Console.WriteLine(a);
a.append(7);
Console.WriteLine(a);
a.delete(5);
Console.WriteLine(a);
Console.WriteLine(a.Size);

//Vektor[] a = new Vektor[5];
//for (int i = 0; i < 5; i++)
//{
//    a[i] = new Vektor(6);
//    a[i].rnd(-100, 100);
//}
//for (int i = 0; i < 5; i++)
//{
//    Console.WriteLine(a[i]);
//}
//Vektor pol = new Vektor();
//Vektor otric = new Vektor();
//for (int i = 0; i < 5; i++)
//{
//    for (int j = 0; j < 6; j++)
//    {
//        if (a[i].get(j) > 0)
//        {
//            pol.append(a[i].get(j));
//        }
//        else if (a[i].get(j) < 0)
//        {
//            otric.append(a[i].get(j));
//        }
//    }
//}
//Console.WriteLine();
//Console.WriteLine();
//Console.WriteLine(otric);
//Console.WriteLine(pol);
