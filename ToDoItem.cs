namespace Blazor___ToDo
{
    public class ToDoItem
    {
        public ToDoItem(string text)
        {
            Text = text;
        }

        public ToDoItem(string text, bool completed)
        {
            Text = text;
            Completed = completed;
        }

        public string Text { get; set; }
        public bool Completed { get; set; }
    }
}
