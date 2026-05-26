using EntityLayer.Concrete;
using FluentValidation;
using System;
using System.Collections.Generic;
using System.Text;

namespace BusinessLayer.ValidationRules
{
    public class GuideValidator : AbstractValidator<Guide>
    {
        public GuideValidator()
        {
            RuleFor(x=>x.Name).NotEmpty().WithMessage("Lütfen rehber adını giriniz!");
            RuleFor(x=>x.Description).NotEmpty().WithMessage("Lütfen rehber açıklamasını giriniz!");
            RuleFor(x=>x.Image).NotEmpty().WithMessage("Lütfen rehber fotoğrafını giriniz!");
        }
    }
}
