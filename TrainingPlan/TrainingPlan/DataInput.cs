using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TrainingPlan
{
    class DataInput
    {
        DataStoreAndGet dataStoreAndGet;
        public DataInput()
            {
                dataStoreAndGet = new DataStoreAndGet();
                ScheduleInput();
            }

        public void ScheduleInput()
        {
            Console.WriteLine("To set the Training Schedule, Press any key. :)");
            Console.WriteLine("\t \t Press 0 to go to main application..");
            string input = Console.ReadLine();
            while (input != "0")
            {
                Console.WriteLine("Please Provide the trainig plan Seperated by (,) ");

                Console.WriteLine("Task:  \t  Assigned Date:  \t No of Trainers Assigned:  \t Scheduled Completion Date:");
                string[] entry = Console.ReadLine().Split(',');
                dataStoreAndGet.SetToDoList(entry[0], entry[1], entry[2], int.Parse(entry[3]));


                Console.WriteLine("To enter another Plan press any key to Continue, Else enter 0");
                input = Console.ReadLine();
            }
        }
    }
}
