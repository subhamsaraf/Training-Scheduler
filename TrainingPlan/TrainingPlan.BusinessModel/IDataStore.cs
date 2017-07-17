using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TrainingPlan.BusinessModel
{
    public interface IDataStore
    {
        void AddTrainer(Trainer trainer);
        void AddTopic(Topic topic);
        void AddTrainee(Trainee trainee);
        List<Trainer> GetTrainers();
        List<Trainee> GetTrainees();
        List<Topic> GetTopics();
        void ScheduleTopic(TopicSchedule topicSchedule);
    }
}
