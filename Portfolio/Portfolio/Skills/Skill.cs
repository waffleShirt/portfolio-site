using System.ComponentModel;

namespace Portfolio.Skills
{
    /// <summary>
    /// Skill DTO. 
    /// </summary>
    public class Skill
    {
        /// <summary>
        /// Enum defines proficiency levels for a Skill. Skills have a description
        /// attribute that allows the enum value to be converted to a string value. 
        /// </summary>
        public enum Level
        {
            [Description("Beginner")]
            Beginner,
            [Description("Intermediate")]
            Intermediate,
            [Description("Advanced")]
            Advanced,
            [Description("Expert")]
            Expert
        }

        /// <summary>
        /// Skill name.
        /// </summary>
        public string Name { get; set; } = string.Empty;

        /// <summary>
        /// Proficiency level. 
        /// </summary>
        public Level Proficiency { get; set; } = Level.Beginner;

        /// <summary>
        /// Description of skill. 
        /// </summary>
        public string Description { get; set; } = string.Empty;

        /// <summary>
        /// Icon to display alongside the skill to draw more attention to it. The icon can
        /// be a string in SVG format, or the class name for an icon from a service like
        /// FontAwesome or DevIcon. 
        /// </summary>
        public string Icon { get; set; } = string.Empty; 
    }
}
