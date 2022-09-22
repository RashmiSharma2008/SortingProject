using System;
using System.Collections.Generic;
using System.IO;

namespace Sort
{
    class Program
    {
        static void Main(string[] args)
        {
         
            // Create a list of Infos.
            List<Info> Infos = new List<Info>();

            // Add data to the list.
            Infos.Add(new Info() { InfoName = "Janet Parsons", InfoId = 1434 });
            Infos.Add(new Info() { InfoName = "Vaughn Lewis", InfoId = 1234 });
            Infos.Add(new Info() { InfoName = "Adonis Julius Archer", InfoId = 1634 }); ;           
            Infos.Add(new Info() { InfoName = "Shelby Nathan Yoder", InfoId = 1444 });
            Infos.Add(new Info() { InfoName = "Marin Alvarez", InfoId = 1534 });
            Infos.Add(new Info() { InfoName = "London Lindsey", InfoId = 1434 });
            Infos.Add(new Info() { InfoName = "Beau Tristan Bentley", InfoId = 1234 });
            Infos.Add(new Info() { InfoName = "Leo Gardner", InfoId = 1634 });
            Infos.Add(new Info() { InfoName = "Hunter Uriah Mathew Clarke", InfoId = 1434 });
            Infos.Add(new Info() { InfoName = "Mikayla Lopez", InfoId = 1234 });
            Infos.Add(new Info() { InfoName = "Frankie Conner Ritter", InfoId = 1634 }); ;

            // Write out the data in the list. This will call the overridden
            // ToString method in the info class.
            Console.WriteLine("\nBefore sort:");
            foreach (Info objInfo in Infos)
            {
                Console.WriteLine(objInfo);
            }

            // Call Sort on the list. This will use the
            // default comparer, which is the Compare method
            // implemented on Info.
            //Infos.Sort();

            //Console.WriteLine("\nAfter sort by info number:");
            //foreach (Info objInfo in Infos)
            //{
            //    Console.WriteLine(objInfo);
            //}



            Infos.Sort(delegate (Info x, Info y)
            {

                if (x.InfoName == null && y.InfoName == null) return 0;
                else if (x.InfoName == null) return -1;
                else if (y.InfoName == null) return 1;
                else
                {

                    string[] xLstLastName = x.InfoName.Split();

                    string xLastName = xLstLastName[xLstLastName.Length - 1];

                    string[] yLstLastName = y.InfoName.Split();

                    string yLastName = yLstLastName[yLstLastName.Length - 1];

                    return xLastName.CompareTo(yLastName);
                }
            });

            Console.WriteLine("\nAfter sort by last name:");

        
            foreach (Info aPart in Infos)
            {
                Console.WriteLine(aPart);
            }

            //Write in file
         bool response=   FileOperation.ExportToTextFile(Infos, @"C:\Users\prade\OneDrive\Desktop\test11\testfile.txt", ',');



        }
    }





}
