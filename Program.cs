namespace StackAssignment
{
    internal class Program
    {
        static void Main(string[] args)
        {
            StackExample stackobj = new StackExample();
            stackobj.pushData(56);
            stackobj.pushData(30);
            stackobj.pushData(70);
            Console.WriteLine("---------------------");

            stackobj.DisplayData();
            Console.WriteLine("-------------------");

            stackobj.Peek();
            Console.WriteLine("-------------------");
            stackobj.pop();


        }
    }
}