namespace to_do_list_app.Models
{
    public class ToDoListModel
    {
        public Guid Id { get; set; }
        public string Title { get; set; }
        public string Description { get; set; }
        public DateTime? StartDate { get; set; }
        public DateTime? EndDate { get; set; }
        public int Priority { get; set; }
        public bool IsComplete { get; set; }
    }
}
