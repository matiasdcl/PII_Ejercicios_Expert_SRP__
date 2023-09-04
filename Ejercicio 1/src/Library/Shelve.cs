using System;
using System.Collections.Generic;

public class Shelve
    {
        public string shelveName;
        public List<Sector> sectorList = new List<Sector>();

        public Shelve(string shelveName, List<Sector> sectorList)
        {
            this.shelveName = shelveName;
            this.sectorList = sectorList;
        }

        public void AddSectorToShelve(Sector sector)
        {
            sectorList.Add(sector);
        }

        public void WhichSectorsAreInShelve()
        {
            foreach (var sectors in sectorList)
            {
                Console.WriteLine($"{sectors.sectorName}\n");
            }
        }
    }