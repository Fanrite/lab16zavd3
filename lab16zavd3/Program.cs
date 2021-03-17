using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab16zavd3
{
    class Program
    {
        struct Slow
        {
            public string abri;
            public string full;
            
            public void Info()
            {
                Console.WriteLine($"{abri} - {full}");
            }

            public Slow(string a, string f)
            {
                this.abri = a;
                this.full = f;
            }

            public Slow(bool vib) : this()
            {
                if (vib)
                {
                    Console.Write("Введіть абривіатуру: ");
                    this.abri = Console.ReadLine();
                    Console.Write("Введіть значення: ");
                    this.full = Console.ReadLine();                  
                }
            }

        }
        static void Main(string[] args)
        {
            Slow[] arr = new Slow[]
            {
                new Slow("Wifi","Вайфай"),
                new Slow("CPU","Центральний процессор"),
                new Slow("GPU","Графічний  процессор"),
            };

            bool flag = true;
            while (flag)
            {
                int v;
                Console.Clear();
                Console.WriteLine("Виберіть режим: \n1 - Ввід даних  \n2 - Пошук в словнику  \n3 - Показ всієї бази \n4 - Вихід з програми");
                v = Convert.ToInt32(Console.ReadLine());

                if (v == 1)
                {
                    bool b = true;
                    while (b)
                    {
                        int e;
                        Console.Clear();
                        Console.WriteLine("1 - Ввести  2- Вихід");
                        e = Convert.ToInt32(Console.ReadLine());
                        Console.Clear();
                        if (e == 1) new Slow(true);
                        if (e == 2) b = false;
                    }
                    
                }

                if (v == 2)
                {
                    bool b = true;
                    while (b)
                    {
                        int e;
                        string posh;
                        Console.Clear();
                        Console.WriteLine("1 - Знайти  2- Вихід");
                        e = Convert.ToInt32(Console.ReadLine());
                        Console.Clear();
                        if (e == 1)
                        {
                            Console.Write("Введіть абривіатуру:");
                            posh = Console.ReadLine();

                            int index = -1;

                            for (int i = 0; i < arr.Count(); i++)
                                if (arr[i].abri == posh) index = i;

                            if (index == -1)
                            {
                                Console.WriteLine($"Нічого не знайдено на {posh}");
                                Console.ReadKey();
                            }
                                
                            else
                            {
                                Console.WriteLine($"Ось що знайдено на {posh}:");
                                arr[index].Info();
                                Console.ReadKey();
                            }
                        }

                        if (e == 2) b = false;
                    }
                }

                if (v == 3)
                {
                    Console.Clear();
                    Console.WriteLine("Вся база:");
                    foreach (Slow n in arr)
                        n.Info();
                    Console.ReadKey();

                }

                if (v == 4)
                    flag = false;

            }
        }
    }
}
