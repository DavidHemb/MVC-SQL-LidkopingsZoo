using LidkopingsZoo.Models.Elements;

namespace LidkopingsZoo.Models.Animals.AirAnimals
{
    public class Dragon : Air
    {
        public override int MaxAltitude { get; set; }
        public Dragon(int MaxAltitude, string name, string description) : base(MaxAltitude, name, description)
        {
            this.MaxAltitude = 7000;
            this.Name = "Dragon";
            this.Description = "A dragon is a large magical legendary creature that appears in the folklore of multiple cultures worldwide. Beliefs about dragons vary considerably through regions, but dragons in western cultures since the High Middle Ages have often been depicted as winged, horned, and capable of breathing fire. Dragons in eastern cultures are usually depicted as wingless, four-legged, serpentine creatures with above-average intelligence. Commonalities between dragons' traits are often a hybridization of feline, reptilian, mammal, and avian features. Scholars believe vast extinct or migrating crocodiles bear the closest resemblance, especially when encountered in forested or swampy areas, and are most likely the template of modern Oriental dragon imagery.";
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
