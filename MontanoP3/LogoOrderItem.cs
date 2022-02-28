using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MontanoP3
{
    class LogoOrderItem
    {
        public LogoOrderItem()
            :this("TBD", false, "TBD", "TBD", 0, 0)
        {
            Calc();
        }

        public LogoOrderItem(string userText, bool hasLogo = false)
            : this(userText, hasLogo, "TBD", "TBD", 0, 0)
        {
            Calc();
        }

        public LogoOrderItem(string userText, bool hasLogo = true, string orderId = " ", string itemType = "mug", int numColors = 0, int numItems = 0)
        {
            UserText = userText;
            HasLogo = hasLogo;
            OrderId = orderId;
            ItemType = itemType;
            this.numColors = numColors;
            this.numItems = numItems;
            Calc();
        }



        public bool HasLogo { get; set; }
        public string OrderId { get; set; }
        public string ItemType { get; set; }
        public string UserText { get; set; }

        private int numItems;
        public int NumItems
        {
            get { return numItems; }
            set { numItems = value; Calc(); }
        }

        private int numColors;
        public int NumColors
        {
            get { return numColors; }
            set { numColors = value; Calc(); }
        }
        public decimal Price { get; private set; }
        private void Calc()
        {
            if (UserText == "")
            {
                if (ItemType == "Mug" && HasLogo == true)
                {
                    Price = (decimal)((3.50 * numItems) + (numItems * (numColors * .03)) + (numItems * .10));
                }
                else if (ItemType == "Pen" && HasLogo == true)
                {
                    Price = (decimal)((1.00 * numItems) + (numItems * (numColors * .03)) + (numItems * .10));
                }
                else if (ItemType == "USB" && HasLogo == true)
                {
                    Price = (decimal)((4.00 * numItems) + (numItems * (numColors * .03)) + (numItems * .10));
                }
                else if (ItemType == "Mug" && HasLogo == false)
                {
                    Price = (decimal)(3.50 * numItems);
                }
                else if (ItemType == "Pen" && HasLogo == false)
                {
                    Price = (decimal)(1.00 * numItems);
                }
                else if (ItemType == "USB" && HasLogo == false)
                {
                    Price = (decimal)(4.00 * numItems);
                }
                else
                {
                    Price = 0;
                }
            }
            else if (UserText != null)
            {
                if (ItemType == "Mug" && HasLogo == true)
                {
                    Price = (decimal)((3.50 * numItems) + (numItems * (numColors * .03)) + (numItems * .10) + (numItems * .05));
                }
                else if (ItemType == "Pen" && HasLogo == true)
                {
                    Price = (decimal)((1.00 * numItems) + (numItems * (numColors * .03)) + (numItems * .10) + (numItems * .05));
                }
                else if (ItemType == "USB" && HasLogo == true)
                {
                    Price = (decimal)((4.00 * numItems) + (numItems * (numColors * .03)) + (numItems * .10) + (numItems * .05));
                }
                else if (ItemType == "Mug" && HasLogo == false)
                {
                    Price = (decimal)((3.50 * numItems) + (numItems * .05));
                }
                else if (ItemType == "Pen" && HasLogo == false)
                {
                    Price = (decimal)((1.00 * numItems) + (numItems * .05));
                }
                else if (ItemType == "USB" && HasLogo == false)
                {
                    Price = (decimal)((4.00 * numItems) + (numItems * .05));
                }
            }
        }

        public override string ToString()
        {
            return "Order number: " + OrderId + " You ordered " + numItems + " " + ItemType + " with " + numColors + " logos "
                + " with the folowing text: " + UserText + ". Final price of order is: " + Price.ToString("c");
        }
    }
}
