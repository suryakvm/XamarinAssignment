using System;
namespace MasterDetailsPage.Models
{
    public class Case
    {

        public int id { get; set; }
        public int decisionId { get; set; }
        public string name { get; set; }
        public int importance { get; set; }
        public string type{ get; set; }

        public Case()
        {
        }
    }
}
