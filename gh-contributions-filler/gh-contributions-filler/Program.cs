﻿using System;

namespace gh_contributions_filler
{
    class Program
    {
        static void Main(string[] args)
        {
            string userInput = "";
            string username = "";
            string email = "";
            CommandManager cm;
            Console.Title = "GitHub Contributions Filler v1.0";
            Console.BufferHeight = 30;
            Console.WriteLine(@"
   _____   _   _     _    _           _     
  / ____| (_) | |   | |  | |         | |    
 | |  __   _  | |_  | |__| |  _   _  | |__  
 | | |_ | | | | __| |  __  | | | | | | '_ \ 
 | |__| | | | | |_  | |  | | | |_| | | |_) |
  \_____| |_|  \__| |_|  |_|  \__,_| |_.__/ 

 CONTRIBUTIONS FILLER V1.0
");
            if (Util.LoadUserSettings() == "")
            {
                Console.WriteLine(@"Configure your account settings");
                Console.Write(@"Username: ");
                username = Console.ReadLine();
                Console.Write(@"Email: ");
                email = Console.ReadLine();
                Util.SaveUserSettings(username, email);
            }
            else
            {
                username = Util.LoadUserSettings().Split(Environment.NewLine)[0];
                email = Util.LoadUserSettings().Split(Environment.NewLine)[1];
            }
            Util.RestartConsole();
            while (true)
            {
                userInput = Console.ReadLine();
                cm = new CommandManager(userInput, username, email);
            }
        }
    }
}
