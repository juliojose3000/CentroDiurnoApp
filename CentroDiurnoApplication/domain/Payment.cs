using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CentroDiurnoApplication
{
    class Payment
    {
        int id;
        string description;
        string month;
        int year;
        float amount_conapan;
        float amount_fodesaf;
        float amount_jps;
        float total;

        public Payment(int id, string description, string month, int year, float amount_conapan, float amount_fodesaf, float amount_jps, float total)
        {
            this.id = id;
            this.description = description;
            this.month = month;
            this.year = year;
            this.amount_conapan = amount_conapan;
            this.amount_fodesaf = amount_fodesaf;
            this.amount_jps = amount_jps;
            this.total = total;
        }

        public int Id { get => id; set => id = value; }
        public string Description { get => description; set => description = value; }
        public string Month { get => month; set => month = value; }
        public int Year { get => year; set => year = value; }
        public float Amount_conapan { get => amount_conapan; set => amount_conapan = value; }
        public float Amount_fodesaf { get => amount_fodesaf; set => amount_fodesaf = value; }
        public float Amount_jps { get => amount_jps; set => amount_jps = value; }
        public float Total { get => total; set => total = value; }
    }

}
