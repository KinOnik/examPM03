using System;

namespace exam
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("\n\tУкажите количество групп: ");
            int n = Convert.ToInt32(Console.ReadLine());
            
            TouristicOperator group = new TouristicOperator(n);

            group.AddGroupInfo();
            group.SortGroup();
            group.SaveInfoFile();
        }
    }
}
