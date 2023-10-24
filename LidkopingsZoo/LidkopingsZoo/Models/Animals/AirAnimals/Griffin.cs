﻿using LidkopingsZoo.Models.Elements;

namespace LidkopingsZoo.Models.Animals.AirAnimals
{
    public class Griffin : Air
    {
        public override int MaxAltitude { get; set; }
        public Griffin(string name, string description, int age, int MaxAltitude) : base(name, description, age, MaxAltitude)
        {
            this.Name = name;
            this.Description = description;
            this.Age = age;
            this.SpeciesName = "Griffin";
            this.HabitatId = 1;
            this.MaxAltitude = 4000;
        }
    }
}
