namespace LidkopingsZoo.Models.Visitation
{
    public class Visitor : User
    {
        public Visitor(string Id, string userName) : base(userName)
        {
            this.UserName = userName;
        }
    }
}
