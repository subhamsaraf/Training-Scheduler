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
            IReport consoleBasedReporting = new ConsoleBasedReporting()
            {
                DataStore = dataStore
            };
            while (true)
            {
                Console.WriteLine("Enter\n(1)Add Trainer\n(2)Add Trainee\n(3)Add Topic\n(4)View Trainers\n(5)View Trainees\n(6)View Topics");
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
                            consoleBasedReporting.GetTrainers();
                            break;
                        case 5:
                            consoleBasedReporting.GetTrainees();
                            break;
                        case 6:
                            consoleBasedReporting.GetTopics();
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
