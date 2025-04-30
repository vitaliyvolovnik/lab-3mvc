using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace MvcMovie.Models;

public class Movie
{
    public int Id { get; set; }

    [Required(ErrorMessage = "Title is required.")]
    [StringLength(100, ErrorMessage = "Title cannot be longer than 100 characters.")]
    public string? Title { get; set; }

    [Display(Name = "Release Date")]
    [DataType(DataType.Date)]
    [Required(ErrorMessage = "Release Date is required.")]
    public DateTime ReleaseDate { get; set; }

    [Required(ErrorMessage = "Genre is required.")]
    [StringLength(50, ErrorMessage = "Genre cannot be longer than 50 characters.")]
    public string? Genre { get; set; }

    [Column(TypeName = "decimal(18, 2)")]
    [Range(1, 1000, ErrorMessage = "Price must be between 1 and 1000.")]
    [Required(ErrorMessage = "Price is required.")]
    public decimal Price { get; set; }
}