using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PathfinderLootGenerator
{
    //ExcelData class to keep data readed from Excel sheet
    internal class ExcelData
    {
        public string Number { get; set; }
        public string Name { get; set; }
        public string Weapon { get; set; }
        public string Groups { get; set; }        
        public string Description { get; set; }
        public string Other { get; set; }
        public string Visual { get; set; }
        
        
    }
}
