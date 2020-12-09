using System;
using System.Linq;

namespace Plutus.Services
{
    public class GoalService
    {
        private readonly FileManager _fileManager = new FileManager();
        public async void EditGoal(Goal goal, string newName, string newAmount, DateTime newDueDate)
        {
            var amount = double.Parse(newAmount);
            var list = await HttpService.GetGoalsAsync();
            var index = list.IndexOf(list.First(i => goal.Name == i.Name && goal.Amount == i.Amount && goal.DueDate == i.DueDate));
            list[index] = new Goal(newName, amount, newDueDate);
            _fileManager.UpdateGoals(list);

        }
    }
}
