using LidkopingsZoo.Models.Elements;

namespace LidkopingsZoo.Models.Animals.LandAnimals
{
    public class Cow : Land
    {
        public override int Speed { get; set; }
        public Cow(int Speed, string name, string description) : base(Speed, name, description)
        {
            this.Speed = 27;
            this.Name = "Cow";
            this.Description = "Cattle (Bos taurus) are large, domesticated, bovid ungulates. They are prominent modern members of the subfamily Bovinae and the most widespread species of the genus Bos. Mature female cattle are referred to as cows and mature male cattle are referred to as bulls. Colloquially, young female cattle (heifers), young male cattle (bullocks), and castrated male cattle (steers) are also referred to as \"cows\".";
        }
        public override void IFly()
        {
            throw new NotImplementedException();
        }

        public override void IRun()
        {
            Console.WriteLine("I run");
        }

        public override void ISwim()
        {
            throw new NotImplementedException();
        }
    }
}
