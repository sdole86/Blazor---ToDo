namespace Blazor___ToDo.Services
{
    public interface ITodoService
    {
        public void Add(ToDoItem item);
        public IEnumerable<ToDoItem> GetAll();

        public void Complete(ToDoItem item);
        public void Delete(ToDoItem item);
        public void Uncomplete(ToDoItem item);

    }
}
