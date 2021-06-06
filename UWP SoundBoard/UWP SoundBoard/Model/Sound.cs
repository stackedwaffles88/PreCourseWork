﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UWP_SoundBoard.Model
{
    public enum SoundCategory
    {
        Animals,
        Cartoons,
        Taunts,
        Warnings
    }
    public class Sound
    {
        public string Name { get; set; }
        public SoundCategory Category { get; set; }
        public string Audio { get; set; }
        public string ImageFile { get; set; }

    }
}
