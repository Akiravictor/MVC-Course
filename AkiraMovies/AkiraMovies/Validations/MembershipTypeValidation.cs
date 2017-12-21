using AkiraMovies.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace AkiraMovies.Validations
{
	public class MembershipTypeValidation : ValidationAttribute
	{
		protected override ValidationResult IsValid(object value, ValidationContext validationContext)
		{
			var customer = (CustomerModels)validationContext.ObjectInstance;

			if (customer.MembershipTypeId == (byte)MembershipTypeEnum.Unknow || customer.MembershipTypeId == (byte)MembershipTypeEnum.PayAsYouGo)
				return ValidationResult.Success;

			if (customer.Birthdate == null)
			{
				return new ValidationResult("Birthdate is required.");
			}

			var age = DateTime.Today.Year - customer.Birthdate.Value.Year;

			return (age >= 18) ? ValidationResult.Success : new ValidationResult("Customer must have at least 18 years old to select a membership.");
		}

	}
}