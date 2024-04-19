using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text.RegularExpressions;

namespace projektMVC.Models
{
    [Table("Student")]
    public class Student
    {
        [Key]
        public int OsobaId { get; set; }

        [Required(ErrorMessage = "Nazwisko jest wymagane.")]
        [Display(Name = "Nazwisko")]
        public string Nazwisko { get; set; }

        [Required(ErrorMessage = "Imię jest wymagane.")]
        [Display(Name = "Imię")]
        public string Imie { get; set; }

        [Required(ErrorMessage = "Pole wiek jest wymagane.")]
        [Display(Name = "Wiek")]
        public int Wiek { get; set; }

        [ForeignKey("GroupId")]
        public virtual Group Group { get; set; }

        [Display(Name = "ID Grupy")]
        public int GroupId { get; set; }


    }
}
