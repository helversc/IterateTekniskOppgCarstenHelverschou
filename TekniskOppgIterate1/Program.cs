using System;
using System.Collections.Generic;
using System.Xml;
using System.Data;

namespace TekniskOppgIterate1
{
    class Program
    {
        static void Main(string[] args)
        {
            String xmlFil = "http://people.iterate.no/jorgensen/testxml/people.xml";

            DataSet datasett = new DataSet(); // lager et datasett
            datasett.ReadXml(xmlFil); // leser inn filen til datasettet
            DataTable tabell = datasett.Tables[0]; //Lager en tabell og fyller tabellen med informasjonen i datasettet

            Console.WriteLine("People: ");     
            Console.Write("         Name    Address    PostCode    PostArea");

            foreach (DataRow row in tabell.Rows) // går gjennom tabellen og skriver ut informasjonen til konsollen
            {
                Console.WriteLine();
                Console.Write("Person ");
                foreach (DataColumn col in tabell.Columns)
                {
                    Console.Write(row[col].ToString() + " ");

                }
            }
            Console.ReadLine(); // dette er bare for å lage en forsinkelse så man kan se konsollen og lese resultatene.
        }
    }
}
