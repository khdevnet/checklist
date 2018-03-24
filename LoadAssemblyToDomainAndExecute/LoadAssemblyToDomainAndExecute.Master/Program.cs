using LoadAssemblyToDomainAndExecute.Bootstrap;
using System;

namespace LoadAssemblyToDomainAndExecute.Master
{
    class Program
    {
        static void Main(string[] args)
        {
            using (BootstrapDomain<IBootstrap> bootstrapDomain = new BootstrapDomain<IBootstrap>(
                "LoadAssemblyToDomainAndExecute.Worker.Joseph",
                "LoadAssemblyToDomainAndExecute.Worker.Joseph.Startup"))
            {
                bootstrapDomain.Value.Run();
            }
            using (BootstrapDomain<IBootstrap> bootstrapDomain = new BootstrapDomain<IBootstrap>(
                "LoadAssemblyToDomainAndExecute.Worker.Bob",
                "LoadAssemblyToDomainAndExecute.Worker.Bob.Startup"))
            {
                bootstrapDomain.Value.Run();
            }
            Console.ReadLine();
        }
    }
}