using System;
namespace MasterDetailsPage.Models
{
    public class Decision
    {
           

        public int id { get; set; }
        //public int userId { get; set; }
        public string name { get; set; }
        public int positive { get; set; }
        public int negative { get; set; }

        public Decision()
        {

        }

        public Decision(int id)
        {
        }

        public Decision(int id, string name, int positive, int negative) : this(id)
        {
            this.id = id;
            //this.userId = userId;
            this.name = name;
            this.positive = positive;
            this.negative = negative;
        }
    }
}
