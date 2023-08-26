using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace QuizManagmentSystem.Models
{
    public class UserData
    {
        [Key]
        public int Id { get; set; }
        [Required(ErrorMessage = "{0} Is Required")]
        [StringLength(20)]
        [DisplayName("First Name")]
        public string? FName { get; set; }
        [StringLength(20)]
        [DisplayName("Middle Name")]
        [Required(ErrorMessage = "{0} Is Required")]
        public string? MName { get; set; }
        [StringLength(20)]
        [Required(ErrorMessage = "{0} Is Required")]
        [DisplayName("Last Name")]
        public string? LName { get; set; }
        [Required(ErrorMessage = "{0} Is Required")]
        [DataType(DataType.EmailAddress)]
        [StringLength(50)]
        public string? Email { get; set; }
        [DataType(DataType.PhoneNumber)]
        [StringLength(10)]
        [Required(ErrorMessage = "{0} Is Required")]
        public string? Phone { get; set; }
        [StringLength(10)]

        public string? Gender { get; set; }
        [StringLength(50)]
        [Required(ErrorMessage = "{0} Is Required")]
        public string? Depatment { get; set; }
        [Required(ErrorMessage = "{0} Is Required")]
        [DataType(DataType.Password)]
        [StringLength(15)]
        public string? Password { get; set; }
        [StringLength(15)]
        [DataType(DataType.Password)]
        [Required(ErrorMessage = "{0} Is Required")]
        [DisplayName("Confirm Password")]
        public string? ConfirmPassword { get; set; }
    }
}
