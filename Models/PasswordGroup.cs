using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;

namespace Models
{
    public class PasswordGroup
    {
        public int Id { get; set; }
        public string GroupName { get; set; }
        public int UserId { get; set; }
        public virtual User User { get; set; }

        [ForeignKey("PasswordGroupId")]
        public virtual List<Account> Accounts { get; set; }
    }
}
