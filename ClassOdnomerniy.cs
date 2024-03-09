using System;

namespace task_3_4
{
    public sealed class Odnomerniy<T> : Massive<T>
    {
        private T[] mass;


        public Odnomerniy(int n,  Func<T> getItemFunc
        ):base(
         getItemFunc)
        {
            mass = new T[n];
           
            ReCreate();

        }

        protected override void GetMass()
        {
            Random random = new Random();
            for (int i = 0; i < mass.Length; i++)
            {
                mass[i]  = GetNewItem();
            }
        }

        
        public override void PrintMass()
        {
            Console.WriteLine(" ");
            for (int i = 0; i < mass.Length; i++)
            {
                Console.Write(mass[i] + " ");
            }
        }
    }
}



        // public override void Average()
        // {
        //     int sum = 0;
        //     foreach (int el in mass)
        //     {
        //         sum += el;
        //     }
        //     Console.WriteLine($"Среднее значение одномерного массива: {sum / mass.Length}");
        //     Console.WriteLine(" ");
        // }
//         public void GetMassWoDubs()
//         {
//             int newMassLength = mass.Length;
//             for (int i = 0; i < mass.Length; i++)
//             {
//                 for (int j = i; j < mass.Length; j++)
//                 {
//                     if (mass[i] == mass[j] && i != j)
//                     {
//                         newMassLength--;
//                         break;
//                     }
//                 }
//             }
//            // Console.WriteLine("New array length = " + newMassLength + "\n");

//             int[] newMass = new int[newMassLength];
//             for (int i = 0; i < newMass.Length; i++)
//             {
//                 newMass[i] = int.MinValue;
//             }
//             int c = 0;
//             for (int i = 0; i < mass.Length; i++)
//             {
//                 if (!Ex(mass[i], newMass))
//                 {
//                     newMass[c] = mass[i];
//                     c++;
//                 }
//             }
//         }


//         public bool Ex(int val, int[] mass)
//         {
//             for (int i = 0; i < mass.Length; i++)
//             {
//                 if (mass[i] == val)
//                 {
//                     return true;
//                 }
//             }
//             return false;
//         }


//     }
// }