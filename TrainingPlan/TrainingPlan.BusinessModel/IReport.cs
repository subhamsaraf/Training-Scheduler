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

}

