using LidkopingsZoo.Models.Elements;

namespace LidkopingsZoo.Models.Animals.WaterAnimals
{
    public class Kraken : Water
    {
        public override int DivingDepth { get; set; }
        public Kraken(int DivingDepth, string name, string description) : base(DivingDepth, name, description)
        {
            this.DivingDepth = 11034;
            this.Name = "Kraken";
            this.Description = "The kraken (/ˈkrɑːkən/)[7] is a legendary sea monster of enormous size said to appear in the sea between Norway and Iceland.\r\n\r\nKraken, the subject of sailors' superstitions and mythos, was first described in the modern era in a travelogue by Francesco Negri in 1700. This description was followed in 1734 by an account from Dano-Norwegian missionary and explorer Hans Egede, who described the kraken in detail and equated it with the hafgufa of medieval lore.";
        }
    }
}
