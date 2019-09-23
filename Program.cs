using System;
using System.Diagnostics;
using System.Collections;
using System.Collections.Generic;

namespace vaderstation
{
    class Program
    {

        static void addTempReading(int input)
        {
            //throw new Exception("Not implemented yet");

        }

        static void listAllTemps(List<double> temprature)
        {
            // throw new Exception("Not implemented yet");

            Console.WriteLine("Previous temprature readings: ");
            for (int i = 0; i < temprature.Count; i++)
            {

                Console.WriteLine("[{0}] {1}", i, temprature[i]);
            }

        }

        static void calcAverageTemp()
        {
            throw new Exception("Not implemented yet");

        }

        static void removeAllTemps()
        {
            throw new Exception("Not implemented yet");

        }

        static void Main(string[] args)
        {
            // var p = new Process();

            // p.StartInfo = new ProcessStartInfo(@"C:\Windows\System32\WindowsPowerShell\v1.0\powershell.exe", "dotnet run")
            // {
            //     UseShellExecute = false
            // };

            // p.Start();
            Console.CursorVisible = false;
            string[] menuContent = { "Lägg till tempratur mätning", "Skriv ut alla tempraturer och medeltempraturer", "Ta bort tempraturmätning", "Avsluta" };
            var menu = new Menu(menuContent);

            string menuHeader = "Väderstationen";
            menu = menu.GetMenu(menu, menuHeader);

            List<double> temp = new List<double>();

            bool exit = false;

            do
            {
                switch (menu.SelectedIndex)
                {
                    case 0:
                        // Lägg till temp
                        string stringInput = Console.ReadLine();
                        double input;
                        try
                        {
                            Console.WriteLine("Enter temprature reading: ");
                            stringInput = Console.ReadLine();
                            input = Convert.ToDouble(stringInput);
                            temp.Add(input);
                        }
                        catch
                        {
                            Console.WriteLine("You can only enter numbers");
                        }

                        break;
                    case 1:
                        // Skriv ut alla temp och medeltemp
                        listAllTemps(temp);
                        break;
                    case 2:
                        // Tabort alla temp 
                        removeAllTemps();
                        break;
                    case 3:
                        // Avsluta
                            exit = true; 
                        return;
                    default:
                        break;
                }
            }while(!exit);
            Console.ReadKey();                                      // Paus i programmet så att användaren hinner läsa
            Console.ForegroundColor = ConsoleColor.Gray;            // Byter tillbaka färg till gray
            Console.Clear();


        }


    }
}
