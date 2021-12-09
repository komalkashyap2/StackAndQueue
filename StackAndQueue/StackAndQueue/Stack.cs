using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StackAndQueue
{
      class Stack
      {

        //Creating node a top
        public Node top;
        public void Push(int newData)
        {
            Node newNode = new Node(newData);
            if (this.top != null)
            {
                newNode.next = this.top;
            }
            this.top = newNode;
            Console.WriteLine("New Node {0} is added ", newNode.data);
        }
        //Peak method gives the top most element in stack without removing the element.
        public void Peek()
        {
            if (this.top == null)
            {
                Console.WriteLine("No elements present in the stack");
                return;
            }
            Console.WriteLine("The element after peaking is : " + this.top.data);
        }
        //Pop Method-Removes the top most element
        public void Pop()
        {
            if (this.top == null)
            {
                Console.WriteLine("No elements present in the stack");
                return;
            }
            Peek();
            this.top = this.top.next;
        }
        //Checking the any underflow or overflow occurs
        public void IsEmpty()
        {
            while (this.top != null)
            {
                Peek();
                Pop();
            }
        }
        public void Show()
        {
            Node temp = this.top;
            if (temp == null)
            {
                Console.WriteLine("No values to be added");
                return;
            }
            while (temp != null)
            {
                Console.WriteLine("Value in the stack " + temp.data);
                temp = temp.next;
            }
        }
    }
}
