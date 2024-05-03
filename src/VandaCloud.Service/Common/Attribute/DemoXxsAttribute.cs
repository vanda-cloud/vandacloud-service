using System.ComponentModel.DataAnnotations;
using System.Text.RegularExpressions;

namespace VandaCloud.Service.Common.Attribute
{
    /// <summary>
    /// 
    /// </summary>
    [AttributeUsage(AttributeTargets.Property | AttributeTargets.Field, AllowMultiple = false)]
    public partial class DemoXxsAttribute : ValidationAttribute
    {
        /// <summary>
        /// 
        /// </summary>
        public DemoXxsAttribute() : base("The {0} field contains a potential XSS attack.")
        {

        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="value"></param>
        /// <returns></returns>
        public override bool IsValid(object value) => !XSSRegex().IsMatch(value?.ToString() ?? "");

        private static Regex XSSRegex()
        {
            return new Regex("<[^>]*>");
        }
    }
}
