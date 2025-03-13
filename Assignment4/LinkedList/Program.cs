using System;

namespace HW4.LinkedList
{
    // 链表节点
    public class Node<T>
    {
        public T Data { get; set; }
        public Node<T> Next { get; set; }

        public Node(T data) { 
            Data = data;
            Next = null;
        }

        public Node() {
            Next = null;
        }
    }

    // 链表
    public class GenericList<T>
    {
        private Node<T> head, tail;

        public GenericList()
        {
            tail = null;
            head = new Node<T>();
        }

        // 创建一个链表
        public void insertNode(T data)
        {
            Node<T> node = new Node<T>(data);
            if(head.Next == null)
            {
                head.Next = node;
                tail = node;
            }
            else
            {
                tail.Next = node;
                tail = node;
            }
        }

        public void createList(T[] datas)
        {
            for(int i = 0; i < datas.Length; i++)
            {
                insertNode(datas[i]);
            }
        }

        public void ForEach(Action<Node<T>> action)
        {
            action(head.Next);
        }
    }

    public class Test
    {
        static void Main(string[] args)
        {
            GenericList<int> list = new GenericList<int>();
            list.createList([1, 2, 3, 4, 5]);
            // 输出所有数
            list.ForEach(p =>
            {
                Console.WriteLine("output all datas");
                while (p != null)
                {
                    Console.Write(p.Data + " ");
                    p = p.Next;
                }
                Console.WriteLine();
            });
            // 求最大值
            list.ForEach(p =>
            {
                Console.WriteLine("get max");
                int max = int.MinValue;
                while (p != null)
                {
                    if (max < p.Data)
                        max = p.Data;
                    p = p.Next;
                }
                Console.WriteLine(max);
            });
            // 求最小值
            list.ForEach(p =>
            {
                Console.WriteLine("get min");
                int min = int.MaxValue;
                while (p != null)
                {
                    if (min > p.Data)
                        min = p.Data;
                    p = p.Next;
                }
                Console.WriteLine(min);
            });
            // 求和
            list.ForEach(p =>
            {
                Console.WriteLine("get sum");
                int sum = 0;
                while (p != null)
                {
                    sum += p.Data;
                    p = p.Next;
                }
                Console.WriteLine(sum);
            });
        }
    }
}