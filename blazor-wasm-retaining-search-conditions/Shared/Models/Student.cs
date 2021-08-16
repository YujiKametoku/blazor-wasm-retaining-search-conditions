using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace blazorwasmretainingsearchconditions.Shared.Models
{
    public class Student
    {
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        [Key]
        public long Id { get; set; }

        [Required]
        public string FirstName { get; set; }

        [Required]
        public string LastName { get; set; }

        [Required]
        public int Age { get; set; }

        [Required]
        // 列挙型を文字列として登録するためにTypeNameで文字型を指定します。
        // 文字型：text、varchar(n)などです。
        [Column(TypeName = "text")]
        public Gender Gender { get; set; }

        [Required]
        public string Email { get; set; }
    }
}