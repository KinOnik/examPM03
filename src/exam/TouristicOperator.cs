using System;
using System.Collections.Generic;
using System.IO;
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

        public void SortGroup()
        {
            Console.WriteLine("\tСортировка запущена.");
            for (int i = 0; i < groupInfo.Length; i++)
            {
                for (int j = 0; j < groupInfo.Length - 1 - i; j++)
                {
                    if(groupInfo[j].GetPrice() == groupInfo[j + 1].GetPrice())
                    {
                        if (groupInfo[j].GetSizeGroup() > groupInfo[j + 1].GetSizeGroup())
                        {
                            Trip temp = groupInfo[j + 1];
                            groupInfo[j + 1] = groupInfo[j];
                            groupInfo[j] = temp;
                        }
                    }
                    if (groupInfo[j].GetPrice() > groupInfo[j + 1].GetPrice())
                    {
                        Trip temp = groupInfo[j + 1];
                        groupInfo[j + 1] = groupInfo[j];
                        groupInfo[j] = temp;
                    }
                }
            }
            Console.WriteLine("\tСортировка окончена.");
        }

        public void SaveInfoFile()
        {
            StreamWriter str = new StreamWriter("GroupInfo.txt");
            for (int i = 0; i < groupInfo.Length; i++)
            {
                str.WriteLine($"Группа № {i+1}:\n\tПродолжительность: {groupInfo[i].GetDuration()}; Цена:{groupInfo[i].GetPrice()}; Размер группы: {groupInfo[i].GetSizeGroup()}");
            }
            str.Close();
        }
    }
}
