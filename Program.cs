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

            stackobj.DisplayData();


        }
    }
}