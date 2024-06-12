// See https://aka.ms/new-console-template for more information

namespace HW11Collections
{
    class Program
    {
        static void printQueue(Queue<int> q)
        {
            foreach (var i in q)
            {
                Console.WriteLine(i);
            }
                
        }
        static void printDictionary(Dictionary<string, int> dictionary)
        {
            foreach(var i in dictionary)
            {
                Console.WriteLine("Key: {0}, Value: {1}",
                    i.Key, i.Value);
            }
        }
        static void printStack(Stack<int> stack)
        {
            foreach(var i in stack)
            {
                Console.WriteLine(i);
            }
        }
        static public void Main()
        {
            Queue<int> q = new Queue<int>();
            for (int i = 0; i < 10; i++)
            {
                q.Enqueue(i);
            }
            printQueue(q);
            Dictionary<string, int> d =
              new Dictionary<string, int>(){
                                  {"Pear", 40},
                                  {"Mango",25},
                                {"Apple", 60} };
            printDictionary(d);
            Stack<int> s = new Stack<int>();
            for(int i = 0; i < 10; i++)
            {
                s.Push(i);
            }
            printStack(s);
        }

    }
}