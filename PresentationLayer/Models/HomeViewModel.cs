using System;
using System.ComponentModel.DataAnnotations;

namespace PresentationLayer.Models
{
    public class HomeViewModel
    {
        [Display(Name = "Displayed Text: ")]
        public string Text { get; set; }

        public string SecondText { get; set; }

        public string ThridText { get; set; }

        [Display(Name = "Domain Time: ")]
        public DateTime Time { get; set; }

    }
}
