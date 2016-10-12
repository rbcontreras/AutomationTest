
namespace AppiumTestFramework_v2.Helpers
{
    internal static class EnumHelper
    {
        /// <summary>
        /// Returns a <see cref="System.String" /> that represents this instance.
        /// </summary>
        /// <param name="value">The value.</param>
        /// <returns>
        /// A <see cref="System.String" /> that represents this instance.
        /// </returns>
        internal static string ToEnumString(this DevicePlatform value)
        {
            switch (value)
            {
                case DevicePlatform.Windows:
                    return "win"; /* TODO: Need to write your own extension of Appium for this */
                case DevicePlatform.IOS:
                    return "iOS";
                case DevicePlatform.Android:
                    return "Android";
                default:
                    return "";
            }
        }
    }
}
