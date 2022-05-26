using System;
using System.ComponentModel.DataAnnotations;
namespace MyCompany.Domain.Entities
{
    public class ServiceItem : EntityBase
    {
        [Required(ErrorMessage = "Adding service name")]
        [Display(Name = "sevice name ")]
        public override string Title { get; set; }

        [Display(Name = "service short description")]
        public override string Subtitle { get; set; }

        [Display(Name = "service long description")]
        public override string Text { get; set; }

    }
}
