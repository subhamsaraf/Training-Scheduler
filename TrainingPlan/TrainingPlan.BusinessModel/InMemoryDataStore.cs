using System;
using System.Collections.Generic;

namespace TrainingPlan.BusinessModel
{
    public class InMemoryDataStore : IDataStore
    {
        private List<Trainer> listOfTrainers;
        private List<Trainee> listOfTrainees;
        private List<Topic> listOfTopics;

        public void AddTopic(Topic topic)
        {
            if (listOfTopics == null)
            {
                listOfTopics = new List<Topic>();
            }
            listOfTopics.Add(topic);
        }

        public void AddTrainee(Trainee trainee)
        {
            if (listOfTrainees == null)
            {
                listOfTrainees = new List<Trainee>();
            }
            listOfTrainees.Add(trainee);
        }

        public void AddTrainer(Trainer trainer)
        {
            if(listOfTrainers==null)
            {
                listOfTrainers = new List<Trainer>();
            }
            listOfTrainers.Add(trainer);
        }

        public List<Topic> GetTopics()
        {
            return listOfTopics;
        }

        public List<Trainee> GetTrainees()
        {
            return listOfTrainees;
        }

        public List<Trainer> GetTrainers()
        {
            return listOfTrainers;
        }

        public void ScheduleTopic(TopicSchedule topicSchedule)
        {
            
        }
    }
}
