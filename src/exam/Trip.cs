using System;
using System.Collections.Generic;
using System.Text;

namespace exam
{
    class Trip
    {
        private string duration1;

        private string Getduration()
        {
            return duration1;
        }

        private void Setduration(string value)
        {
            duration1 = value;
        }

        double price;

        private double Price()
        {
            return price;
        }

        private void Price(double value)
        {
            price = value;
        }

        int sizeGroup;

        private int SizeGroup()
        {
            return sizeGroup;
        }

        private void SizeGroup(int value)
        {
            sizeGroup = value;
        }

    }
}
