using LidkopingsZoo.Models.Visitation;

namespace LidkopingsZoo.Models.ViewModels
{
    public class ToursViewModel
    {
        public string visitTime { get; set; }
        public string visitDate { get; set; }
        public Guide Guide { get; set; }
        public string species { get; set; }
        public int visitors { get; set; }
        public List<List<string>> Animals { get; set; }
    }
}
