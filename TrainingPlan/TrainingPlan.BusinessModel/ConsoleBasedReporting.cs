using System;
using System.Collections.Generic;

namespace TrainingPlan.BusinessModel
{
    public class ConsoleBasedReporting : IReport
    {
        public IDataStore DataStore
        {
            get;
            set;
        }

        public List<Topic> GetTopics()
        {
            foreach (var topic in DataStore.GetTopics())
            {
                Console.WriteLine(topic);
            }
            return DataStore.GetTopics();
        }

        public List<Trainee> GetTrainees()
        {
            foreach (var trainee in DataStore.GetTrainees())
            {
                Console.WriteLine(trainee);
            }
            return DataStore.GetTrainees();
        }

        public List<Trainer> GetTrainers()
        {
            foreach (var trainer in DataStore.GetTrainers())
            {
                Console.WriteLine(trainer);
            }
            return DataStore.GetTrainers();
        }


    }

}

