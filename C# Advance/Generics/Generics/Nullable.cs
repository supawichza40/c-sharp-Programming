namespace Generics
{
    //struct allow data type to be nullable.
    public class Nullable<T> where T : struct
    {
        private object _value;

        public Nullable()
        {
        }

        public Nullable(T value)
        {
            _value = value;
        }

        public bool HasValue
        {
            get { return _value != null; }
        }

        public T GetValueOrDefault()
        {
            if (HasValue)
                return (T)_value;

            return default(T);
        }
    }
    public class NullableNormal
    {
        private object _value;
        //since object is a base class for all type, they can store everything
        //object require boxing and unboxing,
            //can also be use as a method.
            //compile time variable.
        //var does not require boxing
            //compile time variable
            //boxing is implicit unboxing is explicit.
            //it is a compile time feature.
            //once initialise, cannot change type stored.
        //dynamic is a run time variable and does not require boxing and unboxing
            //run time variable

        public NullableNormal()
        {

        }
        public NullableNormal(int value)
        {
            _value = value;
        }
        public bool HasValue
        {
            get
            {
                return _value != null;
            }
        }
        public int GetValueOrDefault()
        {
            if (HasValue)
            {
                return (int)_value;
            }
            return default(int);
            //this return the default value of the int type.
        }
        //The generic allow us to use long, float, int, etc, instead of limited to only one type.
    }
}