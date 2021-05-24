﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace eLearnEnglish_ASP.Models
{
    public class VideoModel
    {
        public int Id { get; set; }
        [StringLength(100, MinimumLength = 5)]
        [Required(ErrorMessage = "Please enter the name of the song")]
        public string Title { get; set; }
        [StringLength(500)]
        public string Description { get; set; }
        [Display(Name = "Choose the cover photo of your book")]

        // public IFormFile CoverPhoto { get; set; }
        public string CoverImageUrl { get; set; }
        [Display(Name = "Choose the music URL")]

        public string VideoUrl { get; set; }
    }
}