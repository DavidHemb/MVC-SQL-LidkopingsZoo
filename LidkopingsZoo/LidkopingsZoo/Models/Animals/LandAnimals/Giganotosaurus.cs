using LidkopingsZoo.Models.Elements;

namespace LidkopingsZoo.Models.Animals.LandAnimals
{
    public class Giganotosaurus : Land
    {
        public override int Speed { get; set; }
        public Giganotosaurus(int Speed, string name, string description) : base(Speed, name, description)
        {
            this.Speed = 50;
            this.Name = "Giganotosaurus";
            this.Description = "Giganotosaurus (/ˌɡɪɡəˌnoʊtəˈsɔːrəs/ GIG-ə-NOH-tə-SOR-əs[2]) is a genus of theropod dinosaur that lived in what is now Argentina, during the early Cenomanian age of the Late Cretaceous period, approximately 99.6 to 95 million years ago. The holotype specimen was discovered in the Candeleros Formation of Patagonia in 1993 and is almost 70% complete. The animal was named Giganotosaurus carolinii in 1995; the genus name translates to \"giant southern lizard\", and the specific name honors the discoverer, Ruben Carolini. A dentary bone, a tooth, and some tracks, discovered before the holotype, were later assigned to this animal. The genus attracted much interest and became part of a scientific debate about the maximum sizes of theropod dinosaurs.";
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
