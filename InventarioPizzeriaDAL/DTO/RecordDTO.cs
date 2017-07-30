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
        private string userName;
        private int orderNumber;
        private bool calculatePrice;
        private bool decreaseFromInventory;
        private string name;
        private string portion;
        private double quantity;
        private double price;
        private double value;
        private double total;

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

        public string UserName
        {
            get
            {
                return userName;
            }

            set
            {
                userName = value;
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

        public bool CalculatePrice
        {
            get
            {
                return calculatePrice;
            }

            set
            {
                calculatePrice = value;
            }
        }

        public bool DecreaseFromInventory
        {
            get
            {
                return decreaseFromInventory;
            }

            set
            {
                decreaseFromInventory = value;
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

        public double Price
        {
            get
            {
                return price;
            }

            set
            {
                price = value;
            }
        }

        public double Value
        {
            get
            {
                return value;
            }

            set
            {
                this.value = value;
            }
        }

        public double Total
        {
            get
            {
                return total;
            }

            set
            {
                total = value;
            }
        }
    }
}
