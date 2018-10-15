namespace Sample.CSharpRiddles
{
    public class MyInt
    {
        public int Value { get; set; }

        public static implicit operator int(MyInt value) => value.Value;

        public static bool operator ==(MyInt value1, MyInt value2)
        {
            value1.Value ++;
            return value1.Value == value2.Value;
        }

        public static bool operator !=(MyInt value1, MyInt value2)
        {
            return value1.Value != value2.Value;
        }
    }

    public class Test
    {
        public void Testing()
        {
            var a = new MyInt() { Value = 0 };
            if (a == 1 && a == 2 && a == 3)
            {
                System.Console.WriteLine("I'm here.");
            }
        }
    }
}