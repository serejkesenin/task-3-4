using System;

namespace task_3_4
{
    public sealed class Stupenchatiy<T> : Massive<T>
    {
        private T[][] mass;
        public Stupenchatiy(int m,  Func<T> getItemFunc
        ):base(
         getItemFunc)
        {
            mass = new T[m][];
         
            ReCreate();
        }
        protected override void GetMass()
        {
            int n = mass.GetLength(0);
            Random random = new Random();
            for (int i = 0; i < n; i++)
            {
                int len = random.Next(0, 10);
                mass[i] = new T[len];
                for (int j = 0; j < len; j++)
                {
                    mass[i][j] = GetNewItem();
                }
            }
        }

        // protected override void GetMass_user()
        // {
        //     Console.WriteLine("Вы создаете ступенчатый массив  ");
        //     int n = mass.GetLength(0);
        //     for (int i = 0; i < n; i++)
        //     {
        //         Console.Write($"Введите длину {i + 1} строки: ");
        //         int len = Convert.ToInt32(Console.ReadLine());
        //         mass[i] = new int[len];
        //         for (int j = 0; j < len; j++)
        //         {
        //             Console.Write($"Элемент [{i},{j}]: ");
        //             mass[i][j] = Convert.ToInt32(Console.ReadLine());
        //         }
        //     }
        // }
        public override void PrintMass()
        {
            Console.WriteLine(" ");
            int c = 0;
            for (int i = 0; i < mass.Length; i++)
            {
                foreach (T el in mass[i])
                {
                    if (c != mass[i].Length - 1)
                    {
                        Console.Write($"{el}" + " ");
                        c++;
                    }
                    else
                    {
                        Console.Write($"{el}" + "\n");
                        c = 0;
                    }
                }
            }
            Console.WriteLine(" ");
        }
    }
}
