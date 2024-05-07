using Microsoft.AspNetCore.Components;

namespace Portfolio.Components
{
    /// <summary>
    /// Component displays a skill with a name, a proficiency level, and a description.
    /// An icon can also be displayed to the left of the skill to make it standout more.
    /// Consider using icons like those available at https://devicon.dev/. 
    /// </summary>
    public partial class Skill
    {
        /// <summary>
        /// Name of skill. 
        /// </summary>
        [Parameter] public string Name { get; set; } = string.Empty;

        /// <summary>
        /// Proficiency level of skill. 
        /// </summary>
        [Parameter] public string Proficiency { get; set; } = string.Empty;

        /// <summary>
        /// Description of skill. 
        /// </summary>
        [Parameter] public string Description { get; set; } = string.Empty;

        /// <summary>
        /// Icon to display next to the skill. 
        /// </summary>
        [Parameter] public string Icon { get; set; } = string.Empty;
    }
}
