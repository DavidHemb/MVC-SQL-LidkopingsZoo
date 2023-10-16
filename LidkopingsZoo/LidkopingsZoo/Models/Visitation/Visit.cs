﻿namespace LidkopingsZoo.Models.Visitation
{
    public class Visit
    {
        public List<Visitor> Visitors { get; set; }
        public List<Animal> Animals { get; set; }
        DateTime VisitTime { get; set; }
        public List<Guide> Guides { get; set; }
    }
}