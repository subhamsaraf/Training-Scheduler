using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TrainingPlan.BusinessModel
{
    public interface IReport
    {
        List<Topic> GetTopics();
        List<Trainee> GetTrainees();
        List<Trainer> GetTrainers();
        IDataStore DataStore { get; set; }
    }

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

