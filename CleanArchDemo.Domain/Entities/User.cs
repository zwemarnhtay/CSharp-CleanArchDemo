using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CleanArchDemo.Domain.Entities;


[Table("Tbl_Users")]
public class User
{
    [Key]
    public int UserId { get; set; }
    [Column("UserName")]
    public string Name { get; set; }
    public string Address { get; set; }
    public string Phone { get; set; }
    public string Role { get; set; }
    public string Email { get; set; }
}
