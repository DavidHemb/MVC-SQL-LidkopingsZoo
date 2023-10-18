using LidkopingsZoo.Models.Elements;

namespace LidkopingsZoo.Models.Animals.LandAnimals
{
    public class SantaClaus : Land
    {
        public override int Speed { get; set; }
        public SantaClaus(int Speed, string name, string description) : base(Speed, name, description)
        {
            this.Speed = 539626424;
            this.Name = "SantaClaus";
            this.Description = "Santa Claus, also known as Father Christmas, Saint Nicholas, Saint Nick, Kris Kringle, or simply Santa, is a legendary figure[1] originating in Western Christian culture who is said to bring gifts during the late evening and overnight hours on Christmas Eve. He is said to accomplish this with the aid of Christmas elves, who make the toys in his North Pole workshop, and with the aid of flying reindeer who pull his sleigh through the air.[2][3]\r\n\r\nThe modern figure of Santa is based on folklore traditions surrounding Saint Nicholas, the English figure of Father Christmas, and the Dutch figure of Sinterklaas.";
        }
    }
}
