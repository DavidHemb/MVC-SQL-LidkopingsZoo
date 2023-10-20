﻿using LidkopingsZoo.Models;
using LidkopingsZoo.Models.Visitation;

namespace LidkopingsZoo.Models.ViewModels
{
    public class GuideAnimalsVievModel
    {
        public Guide guide { get; set; }
        public Animal animal { get; set; }
        public List<Animal> animals { get; set; }

    }
}
