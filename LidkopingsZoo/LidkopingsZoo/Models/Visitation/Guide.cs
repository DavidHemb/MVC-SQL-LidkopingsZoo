﻿namespace LidkopingsZoo.Models.Visitation
{
    public class Guide
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public ICollection<Animal> Animals { get; set; }
    }
}
