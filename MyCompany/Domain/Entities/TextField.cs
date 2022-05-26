using System.ComponentModel.DataAnnotations;
namespace MyCompany.Domain.Entities
{
    public class TextField : EntityBase
    {
        [Required]
        public string CodeWord { get; set; }
        [Display(Name = "Page name(title)")]
        public override string Title { get; set; } = "Information Page";

        [Display(Name = "Page content")]
        public override string Text { get; set; } = "Content add with admin";


    }
}
