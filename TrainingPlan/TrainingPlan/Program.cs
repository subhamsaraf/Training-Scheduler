using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TrainingPlan.BusinessModel;

namespace TrainingPlan
{
    class Program
    {
        static void Main(string[] args)
        {
            IInput scanner = new ConsoleInput();
            int id = 1;
            IDataStore dataStore = new InMemoryDataStore(); 
            while (true)
            {
                Console.WriteLine("Enter\n(1)Add Trainer\n(2)Add Trainee\n(3)Add Topic\n(4)View Trainers");
                int choice;
                if (Int32.TryParse(Console.ReadLine(), out choice))
                {
                    switch (choice)
                    {
                        case 1:
                            Trainer newTrainer = scanner.GetTrainer();
                            dataStore.AddTrainer(newTrainer);
                            break;
                        case 2:
                            Trainee newTrainee = scanner.GetTrainee();
                            dataStore.AddTrainee(newTrainee);
                            break;
                        case 3:
                            Topic newTopic = scanner.GetTopic();
                            dataStore.AddTopic(newTopic);
                            break;
                        case 4:
                            IReport report = new Report();
                            report.DataStore = dataStore;
                            List<Trainer> listOfTrainers = report.GetTrainers();
                            break;
                        default:
                            break;
                    }
                }
                else Console.WriteLine("Invalid Input");
            }
        }
    }
}
