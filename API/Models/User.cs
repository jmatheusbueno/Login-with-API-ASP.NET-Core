using System.ComponentModel.DataAnnotations;

namespace Models.User
{
    public class User
    {
        [Key]
        public int Id { get; set; }

        [Required(ErrorMessage = "Este campo é obrigatório")]
        [MinLength(3, ErrorMessage = "O campo deve conter entre 3 a 15 caractéres")]
        [MaxLength(15, ErrorMessage = "O campo deve conter entre 3 a 15 caractéres")]
        public string Username { get; set; }

        [Required]
        [DataType(DataType.Password, ErrorMessage = "O tipo dos dados não correnponde a uma senha")]
        [StringLength(15, MinimumLength = 5, ErrorMessage = "O campo deve conter entre 5 a 15 caractéres")]
        public string Password { get; set; }
    }
}