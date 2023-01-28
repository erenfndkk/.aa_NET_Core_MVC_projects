using System.ComponentModel.DataAnnotations;

namespace agriculturePresentation.Models
{
    public class serviceAddViewModel
    {
        [Display(Name ="Title")]
        [Required(ErrorMessage ="title can not be empty")]
        public string Title { get; set; }

        [Display(Name = "Image")]
        [Required(ErrorMessage = "Image can not be empty")]
        public string Image { get; set; }

        [Display(Name = "Description")]
        [Required(ErrorMessage = "Description can not be empty")]
        public string Description { get; set; }
    }
}
