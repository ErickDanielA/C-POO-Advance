using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WorkerEnumerate.Entities
    {
    internal class HourContract
        {
        public DateTime Date { get; set; }
        public Double ValuePerHour { get; set; }
        public int Hours { get; set; }

        public HourContract(DateTime date, double valuePerHour, int hours)
            {
            this.Date = date;
            this.ValuePerHour = valuePerHour;
            this.Hours = hours;
            }
        public Double totalValue()
            {
            return ValuePerHour * Hours;
            }
        }
    }
