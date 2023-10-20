namespace LidkopingsZoo.Models.ViewModels
{
    public class HomeViewModel
    {
        public List<int> AnimalsIds { get; set; }
        public List<int> GuidesIds { get; set; }
        public List<int> GuideAnimalsIds { get; set; }

        public List<List<string>> Animals { get; set; }
    }
}
