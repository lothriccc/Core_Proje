using EntityLayer.Concrete;
using FluentValidation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer.ValidationRules
{
	public class ServiceValidator:AbstractValidator<Service>
	{
		public ServiceValidator() 
		{
			RuleFor(x => x.Title).NotEmpty().WithMessage("Hizmet Adı Boş Geçilemez");
			RuleFor(x => x.Title).MinimumLength(5).WithMessage("Hizmet Adı En Az 5 Karakter Olmaı ");
			RuleFor(x => x.Title).MaximumLength(30).WithMessage("Hizmet Adı En Fazla 100 Karakter Olmalı");
		}

	}
}
