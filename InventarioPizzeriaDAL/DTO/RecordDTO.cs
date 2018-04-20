using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InventarioPizzeriaDAL.DTO
{
    public class RecordDTO
    {
        private string dateTime;
        private string date;
        private string time;
        private int ticketNumber;
        private int orderNumber;
        private string name;
        private string portion;
        private double quantity;

        public string DateTime
        {
            get
            {
                return dateTime;
            }

            set
            {
                dateTime = value;
            }
        }

        public string Date
        {
            get
            {
                return date;
            }

            set
            {
                date = value;
            }
        }

        public string Time
        {
            get
            {
                return time;
            }

            set
            {
                time = value;
            }
        }

        public int TicketNumber
        {
            get
            {
                return ticketNumber;
            }

            set
            {
                ticketNumber = value;
            }
        }

        

        public int OrderNumber
        {
            get
            {
                return orderNumber;
            }

            set
            {
                orderNumber = value;
            }
        }

        

        

        public string Name
        {
            get
            {
                return name;
            }

            set
            {
                name = value;
            }
        }

        public string Portion
        {
            get
            {
                return portion;
            }

            set
            {
                portion = value;
            }
        }

        public double Quantity
        {
            get
            {
                return quantity;
            }

            set
            {
                quantity = value;
            }
        }
    }
}
