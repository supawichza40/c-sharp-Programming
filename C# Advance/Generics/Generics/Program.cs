using System;

namespace Generics
{
    class Program
    {
        static void Main(string[] args)
        {
            var number = new Nullable<int>();
            Console.WriteLine("Has Value ?" + number.HasValue);
            Console.WriteLine("Value: " + number.GetValueOrDefault());

            var number2 = new NullableNormal(10);
            Console.WriteLine("Has Value ?" + number2.HasValue);
            Console.WriteLine("Value: " + number2.GetValueOrDefault());
            Console.ReadKey();

            var number3 = new NullableSupa<double>(10.001);
            Console.WriteLine("Has Value ?" + number3.HasValue());
            Console.WriteLine("Value: " + number3.GetValueOrDefault());
            Console.ReadKey();
        }
    }
    class NullableSupa<T> where T : struct
    {
        private object _number { get; set; }
        public NullableSupa()
        {

        }
        public NullableSupa(T number)
        {
            _number = number;
        }
        public bool HasValue()
        {
            return _number != null;
        }
        public T GetValueOrDefault()
        {
            if (HasValue())
            {
                return (T)_number;
            }
            return default(T);
        }
    }
}
