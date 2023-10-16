namespace LidkopingsZoo.Models.Visitation
{
    public class Visitor : User
    {
        public Visitor(string userName) : base(userName)
        {
            this.UserName = userName;
        }
    }
}
