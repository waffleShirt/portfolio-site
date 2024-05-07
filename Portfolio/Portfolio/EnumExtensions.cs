using System.ComponentModel;

namespace Portfolio
{
    /// <summary>
    /// Provides extension methods for enum types. 
    /// </summary>
    public static class EnumExtensions
    {
        /// <summary>
        /// Returns a DescriptionAttribute string for an enum value. Credit to https://stackoverflow.com/a/630900
        /// for providing this solution. 
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <param name="val"></param>
        /// <returns></returns>
        public static string ToDescriptionString<T>(this T val)
        {
            DescriptionAttribute[] attributes = (DescriptionAttribute[])val
               .GetType()
               .GetField(val.ToString())
               .GetCustomAttributes(typeof(DescriptionAttribute), false);
            return attributes.Length > 0 ? attributes[0].Description : string.Empty;
        }

        /// <summary>
        /// Returns an enum from a description attribute. If no description is matched, enum index 0 is returned. 
        /// Credit to https://stackoverflow.com/a/3422440 for this solution.
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <param name="val"></param>
        /// <param name="description"></param>
        /// <returns></returns>
        public static T? ToEnumFromDescription<T>(this T val, string description)
        {
            T? result = Enum.GetValues(typeof(T))
               .Cast<T>()
               .FirstOrDefault(v => v.ToDescriptionString() == description);

            return result;
        }
    }
}
