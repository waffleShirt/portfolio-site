using Microsoft.AspNetCore.Components;

namespace Portfolio.Components
{
    /// <summary>
    /// Component renders a SkillList, which is a list of skills organised by categories. 
    /// </summary>
    public partial class SkillList
    {
        /// <summary>
        /// SkillList to render. 
        /// </summary>
        [Parameter] public Skills.SkillList SkillsList { get; set; } = new(); 
    }
}
