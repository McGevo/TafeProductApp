﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProductApps
{
    class Product
    {
        private decimal price;
        private int quantity;
        private decimal totalPayment;
        private decimal delivery;
        private decimal wrapping;
        private decimal gst;

        private static decimal DEFAULT_DELIVERY = 25;
        private static decimal DEFAULT_WRAPPING = 5;
        private static decimal DEFAULT_GST = 1.1M;

        private decimal Price
        {
            get { return price; }
            set { price = value; }
        }

        private int Quantity
        {
            get { return quantity; }
            set { quantity = value; }
        }

        public decimal TotalPayment
        {
            get { return totalPayment; }
            set { totalPayment = value; }
        }


        private decimal Delivery
        {
            get { return delivery; }
            set { delivery = value; }
        }


        private decimal Wrapping
        {
            get { return wrapping; }
            set { wrapping = value; }
        }

        private decimal GST
        {
            get { return gst; }
            set { gst = value; }
        }

        //Constructor for Product
        public Product(decimal price, int quantity)
        {
            Price = price;
            Quantity = quantity;
            Delivery = DEFAULT_DELIVERY;
            Wrapping = DEFAULT_WRAPPING;
            GST = DEFAULT_GST;
        }

        //Calculate the total payment
        public void calTotalPayment()
        {
            TotalPayment = Price * Quantity;
        }

        //Calculate the total payment with delivery charge
        public decimal calTotalWithCharge()
        {
            return TotalPayment + Delivery;
        }

        public decimal calTotalWithWrap()
        {
            return calTotalWithCharge() + Wrapping;
        }

        public decimal calTotalWithGST()
        {
            return calTotalWithWrap() * GST;
        }
    }
}
