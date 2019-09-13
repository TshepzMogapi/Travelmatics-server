using System.ComponentModel.DataAnnotations;

namespace Travelmatics.Users.Dto
{
    public class ChangeUserLanguageDto
    {
        [Required]
        public string LanguageName { get; set; }
    }
}