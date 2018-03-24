using System;

namespace LoadAssemblyToDomainAndExecute.Worker.Bob
{
    public class BobWorker
    {
        public void DoSomething()
        {
            Console.WriteLine("Host domain: " + AppDomain.CurrentDomain.FriendlyName);
            Console.WriteLine("My name is Bob!");
            Console.WriteLine("Working for you Master!");
        }
    }
}