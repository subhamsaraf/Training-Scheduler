using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TrainingPlan.BusinessModel
{
    public interface ISchedule
    {
        void AddTopic(TopicSchedule topicSchedule);
    }
}
