namespace LidkopingsZoo.Models.Visitation
{
    public class Visitor : User
    {
        public int Id { get; set; }
        public Visitor(string userName) : base(userName)
        {
            this.UserName = userName;
        }
    }
}
