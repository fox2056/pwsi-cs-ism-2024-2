using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace projektMVC.Models
{
    [Table("Group")]
    public class Group
    {
        public Group()
        {
            Students = new HashSet<Student>();
        }
        [Key]
        public int GrupaId { get; set; }

        [Required(ErrorMessage = "Nazwa grupy jest wymagana.")]
        [Display(Name = "Nazwa grupy")]
        public string Nazwa { get; set; }

        public virtual ICollection<Student> Students { get; set; }

    }
}
