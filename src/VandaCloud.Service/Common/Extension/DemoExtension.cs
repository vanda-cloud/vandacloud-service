using System.ComponentModel;
using System.Reflection;

namespace VandaCloud.Service.Common.Extension
{
    /// <summary>
    /// 
    /// </summary>
    public static class DemoExtension
    {
        /// <summary>
        /// 
        /// </summary>
        /// <param name="value"></param>
        /// <returns></returns>
        public static string GetEnumDescription(this System.Enum value)
        {
            FieldInfo field = value.GetType().GetField(value.ToString());

            DescriptionAttribute attribute = (DescriptionAttribute)System.Attribute.GetCustomAttribute(field, typeof(DescriptionAttribute));

            return attribute == null ? value.ToString() : attribute.Description;
        }
    }
}
