using System.ComponentModel.DataAnnotations;

namespace form.Models
{
    public class Survey
    {   
        // [Required]
        public string Name {get;set;}
        // [Required]
        public string Location {get;set;}
        // [Required]
        public string Language {get;set;}
        public string Comment {get;set;}
    }
}