namespace MultiThreadingProgramming
{
    internal class Program
    {
        public static int Count = 0;
        private static readonly object LockObject = new();
        private static readonly object LockObject2 = new();
        static void Main(string[] args)
        {

            //Thread thread = new Thread(GetFirst);
            //Thread thread2 = new Thread(GetSecond);


            //thread.Start();

            //thread2.Start();



            //thread.Join();

            //thread2.Join();

            //Console.WriteLine(Count);

           Task task= Task.Run(() =>
            {
                for (int i = 0; i < 10000; i++)
                {

                    Console.WriteLine($"1ci dovr donur {i}");
                }
            });



            Console.WriteLine("Main threaddeki kod ishe dushdu");
            Console.WriteLine("Program bitti");
            task.Wait();





        }

        public static void GetFirst()
        {
            for (int i = 0; i < 100000; i++) {

                //Console.WriteLine($"1ci dovr donur {i}");
                lock (LockObject2)
                {
                    lock (LockObject)
                    {
                        Count++;
                    }

                }
               
                
            }
        }
        public static void GetSecond()
        {
            for (int i = 0; i < 100000; i++)
            {

                //Console.WriteLine($"2ci dovr {i}");
                lock (LockObject)
                {
                    lock (LockObject2)
                    {
                        Count--;
                    }
                }
                
            }
        }
    }
}
