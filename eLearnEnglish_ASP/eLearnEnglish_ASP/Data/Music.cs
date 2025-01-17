﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace eLearnEnglish_ASP.Data
{
    public class Music
    {
        public int Id { get; set; }
        public string Title { get; set; }

        public string Author { get; set; }
        public string Description { get; set; }
        public string Genre { get; set; }
        public string Difficulty { get; set; }

        public string CoverImageUrl { get; set; }
        public DateTime? CreatedOn { get; set; }
        public DateTime? UpdatedOn { get; set; }
        
        public string MusicUrl { get; set; }
    }
}
