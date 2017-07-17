using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TrainingPlan.BusinessModel
{
    public interface IInput
    {
        Topic GetTopic();
        Trainer GetTrainer();
        Trainee GetTrainee();
        
    }
}
