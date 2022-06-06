using System;
using System.Collections.Generic;
using System.Text;

namespace P_SMulti_Tool
{
    public class CollectionModel
    {
        public string JobNumber { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public bool Collected { get; set; }
        public DateTime CreateDate { get; set; }
        public DateTime? CollectedOn { get; set; } = null;

        public CollectionModel()
        {
         
        }


    }

}












