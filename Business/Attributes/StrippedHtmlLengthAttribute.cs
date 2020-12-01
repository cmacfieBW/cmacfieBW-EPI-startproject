using EPiServer.Core;
using System;
using System.ComponentModel.DataAnnotations;
using EPiServer.Find.Helpers.Text;

namespace StartProjectGuide.Business.Attributes
{
    /// <summary>
    ///     Used for setting number of accepted attributes in content area
    /// </summary>
    [AttributeUsage(AttributeTargets.Property)]
    public class StrippedHtmlLengthAttribute : ValidationAttribute
    {
        private readonly int _maxLength;

        public StrippedHtmlLengthAttribute(int maxLength)
        {
            _maxLength = maxLength;
        }

        /// <summary>
        ///     Validates that correct number of items is used in content area
        /// </summary>
        /// <param name="value"></param>
        /// <param name="validationContext"></param>
        /// <returns></returns>
        protected override ValidationResult IsValid(object value, ValidationContext validationContext)
        {
            var htmlValue = value as XhtmlString;

            if (htmlValue == null)
            {
                return null;
            }

            var stringLength = htmlValue.ToHtmlString().StripHtml().Length;

            if (stringLength > _maxLength)
            {
                return new ValidationResult(
                    $"The property \"{validationContext.DisplayName}\" must not be longer than {_maxLength} characters");
            }

            return null;
        }
    }
}