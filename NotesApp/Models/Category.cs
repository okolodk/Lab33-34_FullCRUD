using System.ComponentModel.DataAnnotations;
namespace NotesApp.Models;

public class Category {
    public int Id {get; set;}
    public DateTime CreatedAt {get; set;} = DateTime.UtcNow;
    public List<Note> Notes {get; set;} = new();

    [Required(ErrorMessage = "Название катигории обязательно")]
    [MaxLength(100, ErrorMessage = "Название не должно превышать 100 символов")]
    public string Name {get; set;} = string.Empty;

    [MaxLength(500, ErrorMessage = "Описание не должно привышать 500 символов")]
    public string Description {get; set;} = string.Empty;

    [MaxLength(7)]
    public string Color {get; set;} = "#3498db";
}