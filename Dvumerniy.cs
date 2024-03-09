using System;

namespace task_3_4
{
    public sealed class Dvumerniy<T> : Massive<T>
    {

        private T[,] mass;
        public Dvumerniy(int m1, int m2, 
        Func<T> getItemFunc
        ):base(
         getItemFunc)
        {
             mass = new T[m1, m2];
            ReCreate();
;
        }

        protected override void GetMass()
        {
            Random random = new Random();
            for (int i = 0; i < mass.GetLength(0); i++)
            {
                for (int j = 0; j < mass.GetLength(1); j++)
                {
                    mass[i, j] =GetNewItem();
                }
            }
        }

        public override void PrintMass()
        {
            int c = 0;
            Console.WriteLine(" ");
            foreach (var el in mass)
            {
                if (c != mass.GetLength(0) - 1)
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
            Console.WriteLine(" ");
        }
    }
}     
//         public void Print_snake()
//         {
//             int m1 = mass.GetLength(0);
//             int m2 = mass.GetLength(1);
//             Console.WriteLine(" ");
//             for (int i = 0; i < m1; i++)
//             {
//                 if (i % 2 == 0)
//                 {
//                     for (int g = m2 - 1; g >= 0; g--)
//                     {
//                         if (g == 0)
//                         { Console.Write($"{mass[i, g]}" + "\n"); }
//                         else
//                         { Console.Write($"{mass[i, g]}" + " "); }
//                     }
//                 }
//                 else
//                 {
//                     for (int j = 0; j < m2; j++)
//                     {
//                         if (j == m2 - 1)
//                         { Console.Write($"{mass[i, j]}" + "\n"); }
//                         else
//                         { Console.Write($"{mass[i, j]}" + " "); }
//                     }
//                 }
//             }
//         }

//     }
// }