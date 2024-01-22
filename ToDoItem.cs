namespace Blazor___ToDo
{
    public class ToDoItem
    {
        public ToDoItem(string text)
        {
            Text = text;
        }

        public string Text { get; set; }
        public bool Completed { get; set; }
    }
}
