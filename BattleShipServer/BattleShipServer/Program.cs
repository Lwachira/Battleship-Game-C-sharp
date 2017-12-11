using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.ServiceModel;
using System.ServiceModel.Description;
using BattleShipService;

namespace BattleShipServer
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.CursorVisible = false;
            Uri baseAddress = new Uri("http://localhost:8000/BattleShipServer");

            Game game = new Game();

            ServiceHost host = new ServiceHost(new GameServer(new Game()), baseAddress);

            try
            {
                host.AddServiceEndpoint(typeof(IServer),new WSHttpBinding(), "Server");

                ServiceMetadataBehavior smb = new ServiceMetadataBehavior();
                smb.HttpGetEnabled = true;

                host.Description.Behaviors.Add(smb);

                host.Open();

                Console.WriteLine("Server is up. Waiting for clients.");

                for(;;)
                {
                    Console.WriteLine("Press (X) to shutdown server.");
                    ConsoleKeyInfo k = Console.ReadKey();
                    if (k.Key == ConsoleKey.X)
                    {
                        host.Close();
                        break;
                    }
                }
            }
            catch(Exception ex)
            {
                Console.WriteLine(ex.Message);
                Console.ReadLine();
            }
        }
    }
}
