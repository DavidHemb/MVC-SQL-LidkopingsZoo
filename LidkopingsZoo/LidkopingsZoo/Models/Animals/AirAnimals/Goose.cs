using LidkopingsZoo.Models.Elements;

namespace LidkopingsZoo.Models.Animals.AirAnimals
{
    public class Goose : Air
    {
        public override int MaxAltitude { get; set; }
        public Goose(int MaxAltitude, string name, string description) : base(MaxAltitude, name, description)
        {
            this.MaxAltitude = 8800;
            this.Name = "Goose";
            this.Description = "A goose (pl: geese) is a bird of any of several waterfowl species in the family Anatidae. This group comprises the genera Anser (the grey geese and white geese) and Branta (the black geese). Some other birds, mostly related to the shelducks, have \"goose\" as part of their names. More distantly related members of the family Anatidae are swans, most of which are larger than true geese, and ducks, which are smaller.";
        }
        public override void IFly()
        {
            Console.WriteLine("I fly");
        }

        public override void IRun()
        {
            throw new NotImplementedException();
        }

        public override void ISwim()
        {
            throw new NotImplementedException();
        }
    }
}
