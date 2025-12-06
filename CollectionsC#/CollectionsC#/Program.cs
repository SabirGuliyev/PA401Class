using System.Collections;

namespace CollectionsC_
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region SortedList_Non-Generic

            //SortedList sorted = new SortedList();
            //sorted.Add(5, "Aynur");
            //sorted.Add(6,"Revan");
            //sorted.Add(9,"Sabir");


            //foreach (var item in sorted)
            //{

            //    Console.WriteLine(item);

            //}







            //sorted.Add(); 
            #endregion

            #region SortedList_Generic

            //Add() big O(n)    ContainsKey() O(log N)  Index destekliyir
            //SortedList<int, string> sortedList = new SortedList<int, string>();
            //sortedList.Add(50, "Aynur");
            //sortedList.Add(20, "Shamil");
            //sortedList.Add(30, "Ulvi");
            //sortedList.Add(10, "Sabir");
            //sortedList.Add(-10, "Test");

            //Console.WriteLine(sortedList[-10]);


            //sortedList.ContainsKey()

            //Keys [1 , 2 , 3 , 4]
            //Values [Sabir, Shamil]

            //bool result = sortedList.TryAdd(4, "Revan");
            //Console.WriteLine(result);
            //Console.WriteLine("-----------------");


            //foreach (var item in sortedList)
            //{

            //    Console.WriteLine(item.Key + " " + item.Value);

            //}

            #endregion

            #region Stack
            //LIFO Push()  O(1)  Pop  O(1) Index desteklemir
            //Stack<string> stack = new();

            //stack.Push("Baki");
            //stack.Push("Gence");
            //stack.Push("Lenkeran");
            //stack.Push("Naxchivan");


            //for (int i = 0; i < stack.Count; i++)
            //{
            //    Console.WriteLine(stack.ElementAt(i));
            //}

            //Console.WriteLine(stack.TryPeek());


            //string str;
            //Console.WriteLine(stack.Pop());
            //Console.WriteLine(stack.Pop());
            //Console.WriteLine(stack.Pop());

            //Console.WriteLine("-------------");

            //Console.WriteLine(stack.TryPop(out str));

            //Console.WriteLine(str);
            //Console.WriteLine("----------------------");


            //foreach (string item in stack)
            //{
            //    Console.WriteLine(item);
            //}


            #endregion


            #region Queue
            //FIFO Enqueue() O(1)  Dequeue() O(1) Index desteklemir

            //Queue<string> queue = new();

            //queue.Enqueue("Anar");
            //queue.Enqueue("Zulfiqar");
            //queue.Enqueue("Ali");
            //queue.Enqueue("Samir");





            //Console.WriteLine(queue.TryDequeue());
            //Console.WriteLine(queue.Dequeue());
            //Console.WriteLine(queue.Dequeue());
            //Console.WriteLine(queue.Dequeue());
            //Console.WriteLine(queue.Dequeue());
            //Console.WriteLine(queue.Dequeue());
            //Console.WriteLine("--------------");

            //foreach (var item in queue)
            //{
            //    Console.WriteLine(item);
            //}

            #endregion

            #region Dictionary
            // Add() O(1) =average   Get()  O(1)?
            //Dictionary<string,string> dictionary = new Dictionary<string,string>();

            //dictionary.Add("baki", "Sabir");
            //dictionary.Add("gence", "Revan");
            //dictionary.Add(8, "Ali");
            //dictionary.TryAdd(2, "Kubra");

            //foreach (var item in dictionary)
            //{
            //    Console.WriteLine(item);
            //}
            //Console.WriteLine(dictionary.Values.Contains("Sabir"));


            #endregion

            //HashSet<string> table = new();

            //table.Add("asd");

            #region LinkedList
            //Add()  O(1)   Remove()  O(1)  Get() O(n)
            //LinkedList<int> nums=new LinkedList<int>();

            //nums.AddLast(1);
            //nums.AddLast(2);
            //nums.AddLast(3);
            //nums.AddLast(4);

            //foreach(int i in nums)
            //{
            //    Console.WriteLine(i);
            //}

            //Console.WriteLine("---------------------");
            //nums.AddFirst(5);

            //foreach (int i in nums)
            //{
            //    Console.WriteLine(i);
            //}

            //IEnumerable
            //IQueryable
            //ICollection
            //IList

            #endregion

        }
    }
}
