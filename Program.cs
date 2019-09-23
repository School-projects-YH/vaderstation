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
            throw new Exception("Not implemented yet");

        }
        static void listAllTemps(List<double> temprature)
        {

            Console.WriteLine();
            Console.WriteLine("Previous temprature readings: ");
            for (int i = 0; i < temprature.Count; i++)
            {
                Console.WriteLine("[{0}] {1}", i+1, temprature[i]);
            }

            Console.WriteLine("\nAverage temprature: ");
            Console.WriteLine(calcAverageTemp(temprature).ToString("0.00"));
            Console.ReadKey();
        }
        static double calcAverageTemp(List<double> temprature)
        {
            double sum = 0;
            for (int i = 0; i < temprature.Count; i++){
                sum += temprature[i];
            }
            sum = sum / temprature.Count;
            
            return sum;
        }
        static void removeAllTemps(List<double> temprature)
        {
            temprature.Clear();
            Console.WriteLine("\nHårdisken brann upp så tyvärr så sparades inget");
            Console.ReadKey();
        }

        static void Main(string[] args)
        {
            string[] menuContent = { "Lägg till tempratur mätning", "Skriv ut alla tempraturer och medeltempraturer", "Ta bort tempraturmätning", "Avsluta" };
            var menu = new Menu(menuContent);

            string menuHeader = "Väderstationen";

            List<double> temp = new List<double>();
            bool exit = false;

            do
            {
                menu = menu.GetMenu(menu, menuHeader);
                Console.ReadKey(true);

                switch (menu.SelectedIndex)
                {
                    case 0:
                        // Lägg till temp
                        double input;
                        try
                        {
                            Console.WriteLine("\nEnter temprature reading: ");
                            string stringInput = Console.ReadLine();
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
                        removeAllTemps(temp);
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

            Console.ResetColor();
            Console.Clear();

        }
    }
}
