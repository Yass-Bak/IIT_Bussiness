using System.ComponentModel.DataAnnotations;

namespace ProjetPFA.ViewModel
{
    public class RoleFormViewModel
    {
        [Required, StringLength(256)]
        public string Name { get; set; }
    }
}