using LidkopingsZoo.Models.Elements;

namespace LidkopingsZoo.Models.Animals.AirAnimals
{
    public class Griffin : Air
    {
        public override int MaxAltitude { get; set; }
        public Griffin(int MaxAltitude, string name, string description) : base(MaxAltitude, name, description)
        {
            this.MaxAltitude = 4000;
            this.Name = "Griffin";
            this.Description = "The griffin, griffon, or gryphon (Ancient Greek: γρύψ, romanized: grýps; Classical Latin: grȳps or grȳpus; Late and Medieval Latin gryphes, grypho etc.; Old French: griffon) is a legendary creature with the body, tail, and back legs of a lion, and the head and wings of an eagle with its talons on the front legs.Because the lion was traditionally considered the king of the beasts, and the eagle the king of the birds, by the Middle Ages, the griffin was thought to be an especially powerful and majestic creature. Since classical antiquity, griffins were known for guarding treasures and priceless possessions.";
        }
    }
}
