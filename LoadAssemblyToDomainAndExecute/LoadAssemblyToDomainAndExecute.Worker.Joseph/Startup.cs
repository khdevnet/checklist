using System;
using LoadAssemblyToDomainAndExecute.Bootstrap;

namespace LoadAssemblyToDomainAndExecute.Worker.Joseph
{
    public class Startup : MarshalByRefObject, IBootstrap
    {
        public void Run()
        {
            new JosephWorker().DoSomething();
        }
    }
}