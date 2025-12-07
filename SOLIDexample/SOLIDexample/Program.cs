using SOLIDexample.DIP;
using SOLIDexample.LSP;
using SOLIDexample.OCP;

namespace SOLIDexample
{
    internal class Program
    {

        static void Main(string[] args)
        {
            #region OCP
            //IMeal meal=new MushedPotato();
            //IMeal meal2=new FrenchFries();
            //IMeal meal3=new Soup();

            //Chef chef = new Chef();

            //chef.CookMeal(meal);
            //chef.CookMeal(meal2);
            //chef.CookMeal(meal3); 
            #endregion

            #region LSP

            //FlyShow<Eagle> flyShow = new FlyShow<Eagle>();

            //flyShow.StartShow();




            //Penguin penguin = new Penguin();

            //penguin.Fly(); 
            #endregion

            #region DIP



            //Knife knife = new Knife();
            //Scissor scissor = new Scissor();

            //Pizza pizza = new(scissor);

            //pizza.Sell();

            #endregion

        }

        #region Task_Async_Await
        //static async Task Main(string[] args)
        //{
        //   Task task= GetProducts();


        //    for (int i = 0; i < 10; i++)
        //    {
        //        Console.WriteLine("Main thread kodu ishe dushur"+i);
        //    }

        //    Console.WriteLine("Program bitdi");
        //    task.Wait();
        //}

        //public async static Task GetProducts()
        //{
        //    Console.WriteLine("Mehsullara sorgu atildi");
        //    await Task.Delay(7000);//sql sorgusu
        //    Console.WriteLine("Mehsullar geldi");
        //}
        #endregion


      
















    }
}
