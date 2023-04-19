using System;
using System.Collections.Generic;
using System.Text;

namespace exam
{
    class Trip
    {
        private string duration;
        private double price;
        private int sizeGroup;

        public Trip()
        {
            duration = "";
            price = 0;
            sizeGroup = 0;
        }

        public string GetDuration()
        {
            return duration;
        }

        public void SetDuration(string value)
        {
            duration = value;
        }


        public double GetPrice()
        {
            return price;
        }

        public void SetPrice(double value)
        {
            price = value;
        }

        public int GetSizeGroup()
        {
            return sizeGroup;
        }

        public void SetSizeGroup(int value)
        {
            sizeGroup = value;
        }

    }
}
