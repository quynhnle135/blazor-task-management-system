using System.ComponentModel.DataAnnotations;

public class TodoTask {
    public int Id { get; set; }

    [Required(ErrorMessage = "Task Title is required.")]
    public string Title { get; set; }

    [StringLength(500, ErrorMessage = "Description is too long.")]
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