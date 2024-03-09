using System;

namespace task_3_4
{
    public class GetItem 
    {
        private bool _choice;
        public GetItem(bool choice)
        {
            _choice = choice;
        }
        protected  int GetIntUserValue()
        {
                Console.Write($"Введите число");
                return Convert.ToInt32(Console.ReadLine());
        }
        protected  double GetDoubleUserValue()
        {
                Console.Write($"Введите дробное число");
                return Convert.ToDouble(Console.ReadLine());
        }
        protected  string? GetStringUserValue()
        {
                Console.Write($"Введите строку");
                return  Console.ReadLine();
        }
        protected  bool GetBoolUserValue()
        {
                Console.Write($"Введите true или false");
                return Convert.ToBoolean(Console.ReadLine());
        }

        protected  int GetIntRandValue()
        {
            return  new Random().Next(0, 10);
      
        }
        protected  double GetDoubleRandValue()
        {
            return  new Random().Next(0, 10);
        }
        protected  string GetStringRandValue()
        {
            return  Convert.ToString(new Random().Next(0, 10));
     }
        protected  bool GetBoolRandValue()
        {
            return  Convert.ToBoolean(new Random().Next(0,2));
        }

        public int GetNewIntItem()
        {
            return _choice? GetIntUserValue(): GetIntRandValue();
        }
        public double GetNewDoubleItem()
        {
            return _choice? GetDoubleUserValue(): GetDoubleRandValue();
        }
        public string? GetNewStringItem()
        {
            return _choice? GetStringUserValue(): GetStringRandValue();
        }
        public bool GetNewBoolItem()
        {
            return _choice? GetBoolUserValue(): GetBoolRandValue();
        }

    }


 }
