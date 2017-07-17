using System;

namespace TrainingPlan.BusinessModel
{
    public class ConsoleInput : IInput
    {
        public Topic GetTopic()
        {
            Console.WriteLine("Enter name");
            return new Topic()
            {
                Name = Console.ReadLine()
            };
        }

        public Trainee GetTrainee()
        {
            Console.WriteLine("Enter name");
            string name = Console.ReadLine();
            string[] fullName = name.Split(' ');
            return new Trainee()
            {
                FirstName = fullName[0],
                LastName = fullName[1]
            };
        }

        public Trainer GetTrainer()
        {
            Console.WriteLine("Enter name");
            string name=Console.ReadLine();
            string[] fullName = name.Split(' ');
            return new Trainer()
            {
                FirstName =fullName[0],
                LastName =fullName[1]
            };
        }
    }
}
