using System;

namespace Setul_1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int f;
            Console.WriteLine("Introduceti functia: ");
            f=int.Parse(Console.ReadLine());
            if (f==1)
                P1();//Functia de gr 1
            if (f == 2)
                P2(); //Functia de gradul 2
            if(f == 3)
                P3();//Daca n se divide cu k
            if (f == 4)
                P4();// An bisect
            if (f == 5)
                P5();//k cifra de la sf unui numar
            if(f==6)
               P6();//daca trei numere pot fi lungimile laturile unui triunghi
            if(f==7)
                P7();//swap cu variabila
            if(f==8)
                P8();//swap fara variabila
            if(f==9)
                P9();//toti divizorii lui n
            if (f == 10)
                P10(); //Verificare numar prim
            if (f == 11)
                P11(); //Afisarea inversa a cifreor unui numar
            if(f==12)
                P12();//Cate numere integi divizibile cu n se afla in intervalul [a, b]. 
            if (f == 13)
                P13(); //cati ani bisecti se afla intre y1 si y2
            if(f==14)
                P14();//palindrom
            if(f==15)
                P15();//3 numere in ordine crescatoare
            if(f==16)
                P16(); //5 numere in ordine crescatoare
            if(f==17)
                P17();//cmmmc cmmdc
            if(f==18)
                P18();//descompunere in factori primi
             if(f==19)
                P19(); //Determinati daca un numar e format doar cu 2 cifre care se pot repeta
        }
        static void P1()
        {
            double a, b, x;
            Console.WriteLine("Introduceti a: ");
            a = double.Parse(Console.ReadLine());
            Console.WriteLine("Introduceti b: ");
            b = double.Parse(Console.ReadLine());
            if (a == 0)
                Console.WriteLine("Ecuatia nu are solutii");
            if (b == 0)
            {
                Console.WriteLine("Solutia este 0");
            }
            else
            {
                x = -b / a;
                Console.WriteLine($"Solutia ecuatiei este {x}");
            }

        }
        static void P2()
        {
            double a, b, c, x1, x2, d;
            Console.WriteLine("Introduceti a: ");
            a = double.Parse(Console.ReadLine());
            Console.WriteLine("Introduceti b: ");
            b = double.Parse(Console.ReadLine());
            Console.WriteLine("Introduceti c: ");
            c = double.Parse(Console.ReadLine());
            d = b * b - 4 * a * c;
            if (a == 0)
            {
                x1 = x2 = -c / b;
                Console.WriteLine($"Solutia ecuatiei este {x1}");
            }
            else
            {
                if (d == 0)
                {
                    x1 = x2 = -b / 2 * a;
                    Console.WriteLine($"Solutiile sunt x1=x2={x1}");
                }
                if (d < 0)
                {
                    Console.WriteLine("Ecuatia nu are solutii reale");
                }
                if (d > 0)
                {
                    x1 = (-b + Math.Sqrt(d)) / 2 * a;
                    x2 = (-b - Math.Sqrt(d)) / 2 * a;
                    Console.WriteLine($"Solutiile ecuatiei sunt {x1} si {x2}");
                }
            }
        }
        private static void P3()
        {
            int n, k;
            Console.WriteLine("Introduceti n: ");
            n = int.Parse(Console.ReadLine());
            Console.WriteLine("Inroduceti k: ");
            k = int.Parse(Console.ReadLine());
            if (n % k == 0)
              Console.WriteLine("n se divide cu k");
            else
              Console.WriteLine("n nu se divide cu k");
        }
        private static void P4()
        {
            int a;
            Console.WriteLine("Introduceti anul: ");
            a = int.Parse(Console.ReadLine());
            if ((a % 400 == 0) || (a%100!=0 && a%4==0))
            {
                Console.WriteLine($"Anul {a} e an bisect");
            }
            else
            {
                Console.WriteLine($"Anul {a} nu e an bisect");
            }
        }
        private static void P5()
        {
            Console.WriteLine("Introduceti numarul: ");
            string numar = Console.ReadLine();
            Console.WriteLine("Introduceti k: ");
            int k=int.Parse(Console.ReadLine());
            if(k<1 || k>numar.Length)
            {
                Console.WriteLine("K nu apartine intervalului intre 1 si lungimea numarului");
            }
            else
            {
                char cifra = numar[numar.Length - k];
                Console.WriteLine($"Cea de a {k} cifra de la sfarsitul numarului este {cifra}");
            }
        }
       
         
        private static void P6()
        {
            int a, b, c;
            Console.WriteLine("Introduceti a: ");
            a = int.Parse(Console.ReadLine());
            Console.WriteLine("Introduceti b ");
            b = int.Parse(Console.ReadLine());
            Console.WriteLine("Introduceti c: ");
            c = int.Parse(Console.ReadLine()); 
            if(a>0 && b>0  && c>0)
            {
                if (a+b>c && a+c>b && b+c>a)
                {
                    Console.WriteLine("da");
                }
                else
                {
                    Console.WriteLine("Imposibil");
                }
            }
            else
                 Console.WriteLine("Imposibil");
        }
        static void P7()
        {
            int a, b, aux;
            Console.WriteLine("Introduceti prima valoare: ");
            a = int.Parse(Console.ReadLine());
            Console.WriteLine("Introduceti a doua valoare: ") ;
            b = int.Parse(Console.ReadLine());
            aux=a;
            a=b;
            b=aux;
            Console.WriteLine($"Valorile dupa swap: {a} si {b}");    
        }   
        private static void P8()
        {
            int a, b;
            Console.WriteLine("Introduceti prima valoare: ");
            a = int.Parse(Console.ReadLine());
            Console.WriteLine("Introduceti a doua valoare: ");
            b=int.Parse(Console.ReadLine());
            a = a + b;
            b = a - b;
            a = a - b;
            Console.WriteLine($"Valorile dupa swap sunt {a} si {b}");
        }
        private static void P9()
        {
            int n, i;
            Console.WriteLine("Introduceti numarul: ");
            n = int.Parse(Console.ReadLine());
            for (i = 1; i <= n; i++)
            {
                if (n % i == 0)
                Console.WriteLine(i);
            }
        }
        private static void P10()
        {
                int n;
                bool ok = true;
                Console.WriteLine("Introduceti n: ");
                n = int.Parse(Console.ReadLine());
                if ((n % 2 == 0 && n != 2) || (n < 2))
                    ok = false;
                for (int d = 3; d * d <= n; d += 2)
                {
                    if (n % d == 0)
                        ok = false;
                }
                if (ok)
                {
                    Console.WriteLine($"Numarul {n} este numar prim");
                }
                else
                {
                    Console.WriteLine($"Numarul {n} nu este prim");
                }

        }
        private static void P11()
        {
            int x, cif;
            Console.WriteLine("Introduceti numarul: ");
            x = int.Parse(Console.ReadLine());
            while (x > 0)
            {
                cif = x % 10;
                x = x / 10;
                Console.Write($"{cif}  ");
            }
        }
        private static void P12()
        {
            int a, b, n, k = 1, i;
            Console.WriteLine($"Introduceti n: ");
            n=int.Parse(Console.ReadLine());
            Console.WriteLine("Introduceti a: ");
            a = int.Parse(Console.ReadLine());
            Console.WriteLine("Introduceti b: ");
            b = int.Parse(Console.ReadLine());
            for(i=a;i<=b;i++)
            {
                if (n % i == 0)
                    k++;
            }
            Console.WriteLine($"In intervalul [{a}, {b}] sunt {k} divizori ai numarului {n}");
        }
        private static void P13()
        {
            int a1, a2, k=0, a;
            Console.WriteLine("Introduceti primul an ");
            a1 = int.Parse(Console.ReadLine());
            Console.WriteLine("Introduceti ultimul an ");
            a2 = int.Parse(Console.ReadLine());
            for (a = a1+1; a <= a2; a++)
            {
                if ((a % 4 == 0 && a % 100 != 0) || (a % 400 == 0))
                    k++;
            }
            Console.WriteLine($"{k} ani bisecti");
        } 
        private static void P14()
        {
            int n, og=0, aux;
            Console.WriteLine("Intrdoceti n: ");
            n = int.Parse(Console.ReadLine());
            aux=n;
             while(aux>0)
             {
                int cif=aux%10;
                aux = aux / 10;
                og = og * 10 + cif;
             }
            if (n == og)
            {
                Console.WriteLine($"Numarul {n} este palindrom");
            }
            else
            {
                Console.WriteLine($"Numarul {n} nu este palindrom");
            }
        }
        private static void P15()
        {
            int a, b, c;
            Console.WriteLine("Introduceti valorile:  ");
            a = int.Parse(Console.ReadLine());
            b = int.Parse(Console.ReadLine());
            c = int.Parse(Console.ReadLine());
            if (a <= b && a <= c)
            {
                if (b <=c)
                    Console.WriteLine($"{a}, {b}, {c}");
                else
                    Console.WriteLine($"{a}, {c}, {b}");
            }
            if(b<a && b<c)
            {
                if (a <c)
                    Console.WriteLine($"{b}, {a}, {c}");
                else
                    Console.WriteLine($"{b}, {c}, {a}");
            }
            if(c<a && c<b)
            {
                if (a < b)
                    Console.WriteLine($"{c}, {a}, {b}");
                else
                    Console.WriteLine($"{c}, {b}, {a}");
            }
        }
           private static void P16()
           {
                int a, b, c, d, e;
                Console.WriteLine("Introduceti valorile: ");
                a = int.Parse(Console.ReadLine());
                b = int.Parse(Console.ReadLine());
                c = int.Parse(Console.ReadLine());
                d = int.Parse(Console.ReadLine());
                e = int.Parse(Console.ReadLine());
                int var;
                if(a>b)
                {
                    var = a;
                    a = b;
                    b = var;
                }
                if(b>c)
                {
                    var = b;
                    b = c;
                    c = var;
                }
                if(c>d)
                {    var = c;
                     c = d;
                     d = var; 
                }
                if (d > e)
                {
                    var = d;
                    d = e;
                    e = var;
                }
                if (a > b)
                {
                    var = a;
                    a = b;
                    b = var;
                }
                if (b > c)
                {
                    var = b;
                    b = c;
                    c = var;
                }
                if (c > d)
                {
                    var = c;
                    c = d;
                    d = var;
                }
                if (a > b)
                {
                    var = a;
                    a = b;
                    b = var;
                }
                if (b > c)
                {
                    var = b;
                    b = c;
                    c = var;
                }
                if (a > b)
                {
                    var = a;
                    a = b;
                    b = var;
                }
            Console.WriteLine($"Numerele in ordine crescatoare sunt: {a}, {b}, {c}, {d}, {e}");
           }
           private static void P17() 
           {
                int a, b;
                Console.WriteLine("Introduceti primul numar: ");
                a = int.Parse(Console.ReadLine());
                Console.WriteLine("Introduceti al doilea numar: ");
                b = int.Parse(Console.ReadLine());
                int d, m;
                d = cmmdc(a, b);
                m = cmmmc(a, b);
                Console.WriteLine($"Cel mai mic multiplu comun este {m}");
                Console.WriteLine($"Cel mai mare divizor comun este {d}");
           }
           static int cmmdc(int a, int b)
           {
                while(a!=b)
                {
                if (a > b)
                    a = a - b;
                else
                    b = b - a;
                }
            return a;
           }
           static int cmmmc(int a, int b)
           {
                return Math.Abs(a*b)/cmmdc(a, b);  
           }
        
           private static  void P18() 
           {
               int x;
               Console.WriteLine("Introduceti numarul: ");
               x=int.Parse(Console.ReadLine());
                for (int i = 2; i <= x; i++)
                {
                    int putere = 0;
                    while (x % i == 0)
                    {
                        putere++;
                        x /= i;
                    }
                    if (putere > 0)
                    {
                        Console.Write($"{i}");
                        if (putere > 1)
                        { 
                            Console.Write($"^{putere}"); 
                        }
                        if (x > 1)
                        {
                            Console.Write("*");
                        }
                    }
                }
           }
        
         private static void P19()
         {
            Console.WriteLine("Introduceti numarul: ");
            string x=Console.ReadLine();
            bool verif=verifD(x);
            if (verif)
                Console.WriteLine($"{x} e format din doar doua cifre care se repeta");
            else
                Console.WriteLine($"{x} nu e format din doar doua cifre care se repeta");
         }
       static bool verifD(string x)
       {
            if (string.IsNullOrEmpty(x) || x.Length < 2)//lungimea nu poate fi 0 sau mai mica decat 2
                return false;
            char primaCifra = x[0];
            for (int i = 1; i < x.Length; i++)
            {
                if (x[i] != primaCifra && x[i] != x[1])//comparam prima cifra cu fiecare cifra
                {
                    return false;
                }
            }
            return true;
       }
    }   
}
      
        
    