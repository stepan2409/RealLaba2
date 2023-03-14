using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RealLaba2
{
    class Operator
    {
        public Operator(string name = "", decimal price = 0, int usersAmount = 0)
        {
            this.name = name;
            this.price = price;
            this.usersAmount = usersAmount;
        }
        
        private string name;
        public string Name
        {
            get { return name; }
            set { name = value; }
        }

        private decimal price;
        public decimal Price
        {
            get { return price; }
            set { price = value; }
        }

        private int usersAmount;
        public int UsersAmount
        {
            set { usersAmount = value; }
        }

        public decimal CalculateIncome()
        {
            return usersAmount * price;
        }
    }
}
