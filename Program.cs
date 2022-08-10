namespace FindMaximumNumber
{
    public class Program
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("***Welcome To Find Maximum Numbe***");
            MaximumIntegerNum maximum = new MaximumIntegerNum();
            int value = maximum.MaximumInteger(44, 56, 72);

            Console.WriteLine("The Maximum Integer is:- " + value);
        }
    }
}