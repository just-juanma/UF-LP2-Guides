//using System;
//using System.Collections;

//public class Stack
//{
//    public static void Main(string[] args)
//    {
//        Stack<int> stack1 = new Stack<int>();
//        Stack<int> stack2 = new Stack<int>();
//        Stack<int> stack3 = new Stack<int>();

//        stack1.Push(2);
//        stack1.Push(5);
//        stack1.Push(8);
//        stack1.Push(9);
//        stack1.Push(11);
//        stack1.Push(15);
//        stack1.Push(17);
//        stack1.Push(19);
//        stack1.Push(20);

//        stack2.Push(77);
//        stack2.Push(66);
//        stack2.Push(55);
//        stack2.Push(44);
//        stack2.Push(32);
//        stack2.Push(31);
//        stack2.Push(29);
//        stack2.Push(3);
//        stack2.Push(2);
//        stack2.Push(1);

//        while (stack2.Count > 0) {
//            stack3.Push(stack2.Pop());
//        }

//        int idx1 = stack1.Pop();
//        int idx3 = stack3.Pop();

//        while(stack1.Count > 0 || stack3.Count > 0)
//        {
//            if (idx1 > idx3)
//            {
//                stack2.Push(idx1);
//                idx1 = stack1.Pop();
//            }
//            else 
//            {
//                stack2.Push(idx3);
//                idx3 = stack3.Pop();
//            }
//        }

//        foreach (int item in stack2)
//        {
//            Console.WriteLine(item);   
//        }

//    }
//}