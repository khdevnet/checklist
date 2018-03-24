using System;
using LoadAssemblyToDomainAndExecute.Bootstrap;

namespace LoadAssemblyToDomainAndExecute.Worker.Bob
{
    public class Startup : MarshalByRefObject, IBootstrap
    {
        public void Run()
        {
            new BobWorker().DoSomething();
        }
    }
}