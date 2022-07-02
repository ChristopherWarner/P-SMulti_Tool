using System;
using System.Collections.Generic;
using System.Text;

namespace P_SMulti_Tool
{
    public class ResidentialCollectionModel : CollectionModel
    {
        public string Address1 { get; set; }
        public string Address2 { get; set; }
        public string Postcode { get; set; }
        public string ContactNumber { get; set; }

        public ResidentialCollectionModel(string jobnumber, string name, string description, bool collected, DateTime createdate, DateTime? collectedon, string address1, string address2, string postcode, string contactnumber)
        {
            JobNumber = jobnumber;
            Name = name;
            Description = description;
            Collected = collected;
            CreateDate = createdate;
            CollectedOn = collectedon;
            Address1 = address1;
            Address2 = address2;
            Postcode = postcode;
            ContactNumber = contactnumber;

        }

        public static void CreateResidentialCollection(string jobnumber, string name, string description, bool collected, DateTime createdate, DateTime? collectedon, string address1, string address2, string postcode, string contactnumber)
        {
            ResidentialCollectionModel created = new ResidentialCollectionModel(jobnumber, name, description, collected, createdate, collectedon, address1, address2, postcode, contactnumber);

            
        }
      
        

        
    }
}
