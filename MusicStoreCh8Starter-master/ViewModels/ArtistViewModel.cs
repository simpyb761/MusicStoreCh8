﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using MusicStore.Models;


namespace MusicStore.ViewModels
{
    public class ArtistViewModel
    {
        public List<Artist> Artists { get; set; } = new List<Artist>();
        public List<Album> Albums { get; set; } = new List<Album>();
    }
}
