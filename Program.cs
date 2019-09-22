using System;
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

        static void listAllTemps()
        {
            throw new Exception("Not implemented yet");

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
            Console.CursorVisible = false;
            string[] menuContent = {"Lägg till tempratur mätning", "Skriv ut alla tempraturer och medeltempraturer", "Ta bort tempraturmätning", "Avsluta"};
            var menu = new Menu(menuContent);

            string menuHeader = "Väderstationen";
            menu = menu.GetMenu(menu, menuHeader);

            List<double> temp = new List<double>();



            switch(menu.SelectedIndex)
            {
                case 0:
                // Lägg till temp
                    string stringInput = Console.ReadLine();
                    double input;
                    try
                    {
                        input = Convert.ToDouble(stringInput);
                        temp.Add(input);
                    }catch{
                        Console.WriteLine("You can only enter numbers");
                    }

                    break;
                case 1:
                // Skriv ut alla temp och medeltemp
                listAllTemps();
                    break;
                case 2:
                // Tabort alla temp 
                removeAllTemps();
                    break;
                case 3:
                // Avsluta
                    return;
                default:
                    break;
            }
            Console.ReadKey();                                      // Paus i programmet så att användaren hinner läsa
            Console.ForegroundColor = ConsoleColor.Gray;            // Byter tillbaka färg till gray
            Console.Clear();


        }

        
    }
}
