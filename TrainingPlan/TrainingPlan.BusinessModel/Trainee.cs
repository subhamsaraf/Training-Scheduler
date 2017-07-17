namespace TrainingPlan.BusinessModel
{
    public class Trainee : Participant
    {
        public override string Type
        {
            get
            {
                return "Trainee";
            }
        }

        public override string ToString()
        {
            return (FirstName+" "+LastName);
        }

    }

}
