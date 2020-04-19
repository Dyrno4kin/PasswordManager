namespace Models
{
    public class Account
    {
        public int Id { get; set; }
        public string NameAccount { get; set; }
        public string URL { get; set; }
        public string LoginAccount { get; set; }
        public string PasswordAccount { get; set; }
        public string Comment { get; set; }
        public int PasswordGroupId { get; set; }
        public virtual PasswordGroup PasswordGroup { get; set; }
    }
}
