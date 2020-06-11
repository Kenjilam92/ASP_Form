using System.ComponentModel.DataAnnotations;

namespace form.Models
{
    public class Survey
    {   
        [Required]
        [MinLength(2,ErrorMessage="Need to be longer than 2 characters")]
        [Display(Name="Name")]
        public string Name {get;set;}
        [Required]
        [Display(Name="location ")]
        public string Location {get;set;}
        [Required]
        [Display(Name="language")]
        public string Language {get;set;}
        [MinLength(20,ErrorMessage="Need to be more than 20 characters")]
        // [Display(Name="Comment")]
        public string Comment {get;set;}
    }
}