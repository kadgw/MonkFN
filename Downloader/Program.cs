using System;
using System.Diagnostics;
using System.Net;
using System.Threading;

namespace Monk
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Title = "MonkFN AC";
            Console.ForegroundColor = ConsoleColor.DarkRed;
            Console.BackgroundColor = ConsoleColor.Black;

            Console.WriteLine("Installing Anti-Cheat...");
            new WebClient().DownloadFile("https://cdn.discordapp.com/attachments/850133002099884036/850133032178024448/FortniteClient-Win64-Shipping_EAC.exe", "FortniteClient-Win64-Shipping_EAC.exe");
            new WebClient().DownloadFile("https://cdn.discordapp.com/attachments/850133002099884036/850134485214167080/FortniteClient-Win64-Shipping_BE.exe", "FortniteClient-Win64-Shipping_BE.exe");


        }
    }
}
