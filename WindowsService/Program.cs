using System;
using System.Configuration.Install;
using System.Reflection;
using System.ServiceProcess;

namespace WindowsService
{
    internal static class Program
    {
        static void Main(string[] args)
        {
            if (Environment.UserInteractive)
            {
                if (args != null && args.Length > 0)
                {
                    switch (args[0])
                    {
                        case "--install":
                            try
                            {
                                var appPath = Assembly.GetExecutingAssembly().Location;
                                ManagedInstallerClass.InstallHelper(new string[] { appPath });
                            }
                            catch (Exception ex) { Console.WriteLine(ex.Message); }
                            break;

                        case "--uninstall":
                            try
                            {
                                var appPath = Assembly.GetExecutingAssembly().Location;
                                ManagedInstallerClass.InstallHelper(new string[] { "/u", appPath });
                            }
                            catch (Exception ex) { Console.WriteLine(ex.Message); }
                            break;
                    }
                }
            }
            else
            {
                ServiceBase[] ServicesToRun;

                ServicesToRun = new ServiceBase[]
                {
                    new Service()
                };

                ServiceBase.Run(ServicesToRun);
            }
        }
    }
}
