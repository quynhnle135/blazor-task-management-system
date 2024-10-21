using System.ComponentModel.DataAnnotations;

public class Todo {
    [Required(ErrorMessage = "Task's title is required.")]
    public string Title { get; set; }

    [StringLength(500, ErrorMessage = "Description is too long (500 characters maximum!)")]
    public string Description { get; set; }

    [Required(ErrorMessage = "Task's priority is required.")]
    public TodoPriority Priority { get; set; }

    [Required(ErrorMessage = "Task's status is required.")]
    public TodoStatus Status { get; set; }
}

public enum TodoPriority {
    Low,
    Medium, 
    High
}

public enum TodoStatus {
    ToDo,
    InProgress,
    Done
}