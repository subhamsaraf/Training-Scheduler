using System.Collections.Generic;

namespace TrainingPlan.BusinessModel
{
    public class Report : IReport
    {
        public IDataStore DataStore { get; set; }
        public List<Topic> GetTopics()
        {
            return DataStore.GetTopics();
        }

        public List<Trainee> GetTrainees()
        {
            return DataStore.GetTrainees();
        }

        public List<Trainer> GetTrainers()
        {
            return DataStore.GetTrainers();
        }
    }

}

