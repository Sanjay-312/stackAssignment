using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StackAssignment
{
    internal class StackExample
    {
        public Node top;
        public StackExample()
        {
            top = null;
        }

        public void pushData(int data)
        {
            Node node=new Node(data);
            node.Next = top;
            top= node;
            Console.WriteLine("{0} is inseretd into stack",data);
        }
        public void DisplayData()
        {
            if(top == null)
            {
                Console.WriteLine("stack is empty");

            }
            else
            {
                Node temp = top;
                while(temp != null)
                {
                    Console.WriteLine(temp.data+" ");
                    temp = temp.Next;
                }
            }

        }

    }
}
