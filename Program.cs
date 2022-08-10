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

          MaximumString maximum = new MaximumString();
            string str = maximum.MaximumStringValue("Apple", "Peach", "Banaana");

            Console.WriteLine("The MaximumString is: " + str);
        }
    }
}