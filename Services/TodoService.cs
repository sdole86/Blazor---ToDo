namespace Blazor___ToDo.Services
{
    public class TodoService : ITodoService
    {
        private readonly IList<ToDoItem> _toDoItems;

        public TodoService()
        {
            _toDoItems = new List<ToDoItem> {
                new("Wash Clothes"),
                new("Clean Desk"),
                new("Wash Dishes", false),
                new("Clean Garage", true),
                new("Clean Room", true),
            };
        }

        public void Add(ToDoItem item)
        {
            _toDoItems.Add(item);
        }

        public IEnumerable<ToDoItem> GetAll()
        {
            return _toDoItems.ToList();
        }

        public void Delete(ToDoItem item)
        {
            _toDoItems.Remove(item);
        }

        public void Complete(ToDoItem item)
        {
            item.Completed = true;
        }

        public void Uncomplete(ToDoItem item)
        {
            item.Completed = false;
        }
    }
}
