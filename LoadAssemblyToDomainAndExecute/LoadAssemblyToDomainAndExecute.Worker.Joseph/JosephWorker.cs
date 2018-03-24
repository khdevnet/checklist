using System;

namespace LoadAssemblyToDomainAndExecute.Worker.Joseph
{
    public class JosephWorker
    {
        public void DoSomething()
        {
            Console.WriteLine("Host domain: " + AppDomain.CurrentDomain.FriendlyName);
            Console.WriteLine("My name is Joseph!");
            Console.WriteLine("Working for you Master!");
        }
    }
}