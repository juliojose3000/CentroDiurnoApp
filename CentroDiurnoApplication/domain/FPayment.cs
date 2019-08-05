using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CentroDiurnoApplication
{

    class FPayment
    {

        private int id;
        private string description;
        string month;
        int year;
        private float amount_payment;

        public FPayment(int id, string description, string month, int year, float amount_payment)
        {
            this.id = id;
            this.description = description;
            this.month = month;
            this.year = year;
            this.amount_payment = amount_payment;
        }

        public int Id { get => id; set => id = value; }
        public string Description { get => description; set => description = value; }
        public string Month { get => month; set => month = value; }
        public int Year { get => year; set => year = value; }
        public float Amount_payment { get => amount_payment; set => amount_payment = value; }
    }
}
