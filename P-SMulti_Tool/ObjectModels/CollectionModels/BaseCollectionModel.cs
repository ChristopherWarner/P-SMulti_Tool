using System;
using System.Collections.Generic;
using System.Text;

namespace P_SMulti_Tool
{
    public class BaseCollectionModel
    {
        public string JobNumber { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public bool Collected { get; set; }
        public DateTime CreateDate { get; set; }
        public DateTime? CollectedOn { get; set; }

        public BaseCollectionModel()
        {

        }
        public static BaseCollectionModel Set_Collected_True(BaseCollectionModel Received)
        {
            Received.Collected = true;
            Received.CollectedOn = DateTime.Now;
            return Received;
        }
        public static BaseCollectionModel Update_Property(BaseCollectionModel Received)
        {
            return Received;
        }
  


    }

}












