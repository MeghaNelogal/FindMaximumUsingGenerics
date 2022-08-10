namespace FindMaximumNumber
{
    public class Program
    {
        public static void Main(string[] args)
        {
            //Console.WriteLine("***Welcome To Find Maximum Numbe***");
            //MaximumIntegerNum maximum = new MaximumIntegerNum();
            //int value = maximum.MaximumInteger(44, 56, 72);

            //Console.WriteLine("The Maximum Integer is:- " + value);

            //FindMaximumFloat maximum = new FindMaximumFloat();
            //double value = maximum.MaximumFloatNumber(3.6, 5.7, 7.7);

            //Console.WriteLine("The Maximum Float is:- " + value);

            //MaximumString maximum = new MaximumString();
            //  string str = maximum.MaximumStringValue("Apple", "Peach", "Banaana");

            //  Console.WriteLine("The MaximumString is:- " + str);

            int[] intArray = { 222, 234, 333, 444, 555 };
            GenericMax<int> gen = new GenericMax<int>(intArray);
            gen.PrintMaxValue();

            double[] doubleArray = { 22.2, 54.4, 6.32, 77.5, 1.11 };
            GenericMax<double> genDouble = new GenericMax<double>(doubleArray);
            genDouble.PrintMaxValue();

            string[] stringArray = { "121", "131", "141", "151", "161" };
            GenericMax<string> genString = new GenericMax<string>(stringArray);
            genString.PrintMaxValue();
        }
    }
}