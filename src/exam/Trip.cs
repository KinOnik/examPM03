using System;
using System.Collections.Generic;
using System.Text;

namespace exam
{
    class Trip
    {
        private string duration1;

        public string GetDuration()
        {
            return duration1;
        }

        public void SetDuration(string value)
        {
            duration1 = value;
        }

        double price;

        public double GetPrice()
        {
            return price;
        }

        public void SetPrice(double value)
        {
            price = value;
        }

        int sizeGroup;

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
