using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TrainingPlan.BusinessModel
{
    public abstract class Participant
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public int Id { get; set; }
        public abstract string Type { get; }
    }

}
