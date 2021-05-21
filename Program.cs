using System;
using System.IO;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Threading;
using System.Diagnostics;

namespace Phone_freesharp
{
    static class Program
    {
        [DllImport("kernel32.dll")]
        [return: MarshalAs(UnmanagedType.Bool)]
        static extern bool AllocConsole();
        static void Main()
        {
            AllocConsole();
            Console.Clear();
            int i = 0;
            //Console.SetBufferSize(Console.WindowWidth, Console.WindowHeight);
            Console.CursorVisible = false;
            foreach(String line in Data.logo)
            {
                Console.SetCursorPosition((Console.WindowWidth / 2) - (Data.logo[1].Length) / 2, 5 + i);
                Console.Write(Data.logo[i]);
                i++;
            }
            i = 0;
            while(i < Data.options.Length)
            {
                String ControlDuet = Data.options[i] + " " + Data.options[i + 1];
                Console.SetCursorPosition((Console.WindowWidth / 2) - (ControlDuet.Length / 2), (i / 2) + (6 + Data.logo.Length));
                Console.Write(ControlDuet);
                i = i + 2;
            }
            ConsoleKey choice = Console.ReadKey().Key;
            if(choice == ConsoleKey.D1)
            {
                Console.Clear();
                String[] files = Directory.GetFiles("C:\\Users\\" + Environment.UserName + "\\AppData\\Local\\Temp");
                foreach(String file in files)
                {
                    try
                    {
                        File.Delete(file);
                        Console.ForegroundColor = ConsoleColor.Green;
                        Console.Write("[Cleaner] ");
                        Console.ResetColor();
                        Console.Write("Removed " + file.Replace("C:\\Users\\" + Environment.UserName + "\\AppData\\Local\\Temp\\", "{").Split('.')[1] + "} from ");
                        Console.ForegroundColor = ConsoleColor.Green;
                        Console.Write("C:\\Users\\" + Environment.UserName + "\\AppData\\Local\\Temp\r\n");
                    }
                    catch
                    {
                        Console.ForegroundColor = ConsoleColor.Green;
                        Console.Write("[Cleaner] ");
                        Console.ResetColor();
                        Console.Write("Failed to remove " + file.Replace("C:\\Users\\" + Environment.UserName + "\\AppData\\Local\\Temp\\", "{").Split('.')[0] + "} from ");
                        Console.ForegroundColor = ConsoleColor.Red;
                        Console.Write("C:\\Users\\" + Environment.UserName + "\\AppData\\Local\\Temp\r\n");
                    }
                }
                Console.ForegroundColor = ConsoleColor.Cyan;
                Console.Write("\n\n[Cleaner]");
                Console.ResetColor();
                Console.Write(" Click enter to go back\n");
                readforenter1:
                if (Console.ReadKey().Key == ConsoleKey.Enter)
                {
                    Main();
                }
                else
                {
                    goto readforenter1;
                }
            }
            else if(choice == ConsoleKey.D2)
            {
                Console.Clear();
                Console.ForegroundColor = ConsoleColor.Green;
                Console.Write("[MC-OPTIMIZE] ");
                Console.ResetColor();
                Console.Write("Opening Minecraft File\r\n");
                try
                {
                    File.Delete("C:\\Users\\" + Environment.UserName + "\\AppData\\Roaming\\.minecraft\\options.txt");
                    Console.ForegroundColor = ConsoleColor.Green;
                    Console.Write("[MC-OPTIMIZE] ");
                    Console.ResetColor();
                    Console.Write("Removed old options file!\r\n");
                }
                catch
                {
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.Write("[MC-OPTIMIZE] ");
                    Console.ResetColor();
                    Console.Write("Failed to remove old options file!\r\n");
                }
                File.Create("C:\\Users\\" + Environment.UserName + "\\AppData\\Roaming\\.minecraft\\options.txt");
                Thread.Sleep(200);
                File.WriteAllText("C:\\Users\\" + Environment.UserName + "\\AppData\\Roaming\\.minecraft\\options.txt", Data.mcoptions);
                Console.ForegroundColor = ConsoleColor.Green;
                Console.Write("[MC-OPTIMIZE] ");
                Console.ResetColor();
                Console.Write("Installed new Minecraft Settings!\r\n");
                try
                {
                    File.Delete("C:\\Users\\" + Environment.UserName + "\\AppData\\Roaming\\.minecraft\\optionsof.txt");
                    Console.ForegroundColor = ConsoleColor.Green;
                    Console.Write("[MC-OPTIMIZE] ");
                    Console.ResetColor();
                    Console.Write("Removed old Optifine options file!\r\n");
                }
                catch
                {
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.Write("[MC-OPTIMIZE] ");
                    Console.ResetColor();
                    Console.Write("Failed to remove old Optifine options file!\r\n");
                }
                File.Create("C:\\Users\\" + Environment.UserName + "\\AppData\\Roaming\\.minecraft\\optionsof.txt");
                File.WriteAllText("C:\\Users\\" + Environment.UserName + "\\AppData\\Roaming\\.minecraft\\optionsof.txt", Data.optifineOptions);
                Console.ForegroundColor = ConsoleColor.Cyan;
                Console.Write("[MC-OPTIMIZE] ");
                Console.ResetColor();
                Console.Write("Click enter to go back\n");
                readforenter2:
                if (Console.ReadKey().Key == ConsoleKey.Enter)
                {
                    Main();
                }
                else
                {
                    goto readforenter2;
                }
            }
            else if(choice == ConsoleKey.D3)
            {
                Console.Clear();
                Console.ForegroundColor = ConsoleColor.Green;
                Console.Write("[Debloat]");
                Console.ResetColor();
                Console.Write("Removing Bad Updates\n");
                Thread.Sleep(2000);
                foreach (String Command in Data.badupdates)
                {
                    Process.Start("CMD.exe", Command);
                    Console.ForegroundColor = ConsoleColor.Green;
                    Console.Write("\n[Debloat] ");
                    Console.ResetColor();
                    Console.Write("Executed ");
                    Console.ForegroundColor = ConsoleColor.Green;
                    Console.Write("[" + Command + "]\n");
                    Console.ResetColor();
                }
                Console.ForegroundColor = ConsoleColor.Green;
                Console.Write("\n[Debloat] ");
                Console.ResetColor();
                Console.Write("Disabling Telementary Tasks!\n");
                Thread.Sleep(500);
                foreach(String Command in Data.telementarytasks)
                {
                        Process.Start("CMD.exe", Command);
                        Console.ForegroundColor = ConsoleColor.Green;
                        Console.Write("\n[Debloat] ");
                        Console.ResetColor();
                        Console.Write("Executed ");
                        Console.ForegroundColor = ConsoleColor.Green;
                        Console.Write("[" + Command + "]\n");
                        Console.ResetColor();
                }
                Application.Exit();
            }else if (choice == ConsoleKey.D4)
            {
                Console.Clear();
                Console.Write("Just don't use this lmao");
                Console.ReadKey();
                Main();
            }
            Console.ReadKey();
        }
    }
}
