using System.ComponentModel.DataAnnotations;

namespace JsonBasedLocalization.Dto
{
    public class CreateTestDto
    {
        [Required(ErrorMessage = "required")]
        public string Name { get; set; }
    }
}
