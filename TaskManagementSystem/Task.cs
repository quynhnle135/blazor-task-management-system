using System.ComponentModel.DataAnnotations;

public class TodoTask {
    public int ID { get; set; }

    [Required]
    public string Title { get; set; }

    [StringLength(500, ErrorMessage = "Description is too long (500 characters maximum!)")]
    public string Description { get; set; }

    [Required]
    public TaskPriority Priority { get; set; }

    [Required]
    public TaskStatus Status { get; set; }
}

public enum TaskPriority {
    Low,
    Medium, 
    High
}

public enum TaskStatus {
    ToDo,
    InProgress,
    Done
}