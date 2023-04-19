using System;
using System.Collections.Generic;
using System.Text;

namespace exam
{
    class TouristicOperator
    {
        Trip[] groupInfo;

        TouristicOperator(int size)
        {
            groupInfo = new Trip[size];
        }

        public void AddGroupInfo()
        {
            Console.WriteLine("\tЗаполнение массаива: ");
            for (int i = 0; i < groupInfo.Length; i++)
            {
                Console.WriteLine($"\n\tГруппа №:{i+1} ");
                Console.Write("\n\t\tУкажите продолжительность: ");
                groupInfo[i].SetDuration(Console.ReadLine());
                Console.Write("\n\t\tУкажите цену: ");
                groupInfo[i].SetPrice(Convert.ToDouble(Console.ReadLine()));
                Console.Write("\n\t\tУкажите размер группы: ");
                groupInfo[i].SetSizeGroup(Convert.ToInt32(Console.ReadLine()));
            }

        }
    }
}
