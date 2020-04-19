using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;

namespace Models
{
    public class User
    {
        public int Id { get; set; }
        public string FIO { get; set; }
        public string Login { get; set; }
        public string Password { get; set; }
        public string Email { get; set; }
        public bool Status { get; set; }
        public bool Authentication { get; set; }

        [ForeignKey("UserId")]
        public virtual List<PasswordGroup> PasswordGroups { get; set; }
    }
}
