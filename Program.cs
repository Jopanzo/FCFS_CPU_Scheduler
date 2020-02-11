using System;
namespace JSantana_ExtraCredit
{
    class Program
    {
        static void Main(string[] args)
        {
            int bursts = 1; // Variable used to make sure I do not do array elements not defined in p[x,x]
            int[,] p = new int[,] { { 1, 5 },{2,7 },{3,8 },{ 4, 6 } }; //first number will serve as the PID, second as cpu burst length
            //Attempting to impement the first come first serve
            DateTime t = DateTime.Now; //Starting time  
            for (int i = 0; i < p.GetLength(0); i++)
            {
                int pid = i + 1;
                DateTime loop = DateTime.Now; //to get an actual start time compared to time program initialized
                Console.WriteLine("Process ID is {0}, waited for {1}",pid,(loop - t));
                System.Threading.Thread.Sleep(p[i,bursts]*1000); //Since it is in miliseconds used 1000 to get seconds
                Console.WriteLine("CPU Burst was {0}",p[i,bursts]);
            }
            DateTime end = DateTime.Now; //To get total completion time
            Console.WriteLine("Total time is "+(end - t));
            Console.ReadLine();
        }
    }
}
