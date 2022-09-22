using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Collections.Generic;
using Sort;

namespace TestProject
{
    [TestClass]
    public class UnitTest1
    {
      


        [TestMethod]
        public void SortList()
        {

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

            Assert.AreEqual("Marin Alvarez", Infos[0].InfoName);

        }



        [TestMethod]
        public void TestFileGeneration()
          
        {
            bool Expectedresult = true;
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

            Expectedresult= FileOperation.ExportToTextFile(Infos, @"C:\Users\prade\OneDrive\Desktop\test11\testfile1.txt", ',');


            Assert.IsTrue(Expectedresult);
        }


    }
}
