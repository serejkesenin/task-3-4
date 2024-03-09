using System;

namespace task_3_4
{
    public abstract class Massive<T> : IPrint
    {
        protected Func<T> GetItemFunc;
        protected abstract void GetMass();
        public abstract void PrintMass();
        public Massive(
        Func<T> getItemFunc)
        {
            GetItemFunc = getItemFunc;
    }
        public void ReCreate()
        {
            GetMass();
        }
       protected T GetNewItem()
        {
            return  GetItemFunc();
        }
    }


 }
