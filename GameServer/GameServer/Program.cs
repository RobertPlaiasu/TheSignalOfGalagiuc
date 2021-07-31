using System;

namespace GameServer
{
    internal class Program
    {
        public static void Main(string[] args) 
        {
            Console.Title = "Game Server";
            Console.WriteLine("Game Server");
            
            Server.Start(50,26950);
            
            Console.ReadKey();
        }
    }
}