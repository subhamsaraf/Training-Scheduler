using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TrainingPlan
{
    struct ToDOList
    {
         public string taskAssigned;
         public string assignedDate, completionDate;
         public int noOfPeopleAssigned;
    }
    class DataStoreAndGet
    {
        private List<ToDOList> taskList;

        public List<ToDOList> GetToDoList()
        {
            return taskList;
        }
        public void SetToDoList(string taskAssigned, string assignedDate, string completionDate, int noOfPeopleAssigned)
        {
            ToDOList toDoList = new ToDOList();
            toDoList.taskAssigned = taskAssigned;
            toDoList.assignedDate = assignedDate;
            toDoList.completionDate = completionDate;
            toDoList.noOfPeopleAssigned = noOfPeopleAssigned;
            taskList.Add(toDoList);
        }
    }
}
