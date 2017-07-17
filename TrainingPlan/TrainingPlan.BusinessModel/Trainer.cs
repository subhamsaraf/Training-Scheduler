namespace TrainingPlan.BusinessModel
{
    public class Trainer : Participant
    {
        public override string Type
        {
            get
            {
                return "Trainer";
            }
        }

        public override string ToString()
        {
            return (FirstName + " " + LastName);
        }

    }

}
