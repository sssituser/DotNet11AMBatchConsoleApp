using System;
using System.Collections.Generic;
using System.Text;

namespace Inheritance
{
    internal class Plants
    {
        private int palntId;
        private string plantName;
     
        public void SetPlant(int plantId,string plantName)
        {
            this.palntId = plantId;
            this.plantName = plantName;
            
        }
        public void SetPlantPrice()
        {
            Console.WriteLine("Plant Price : $100");
        }

    }
}
