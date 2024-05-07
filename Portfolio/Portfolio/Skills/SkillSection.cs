namespace Portfolio.Skills
{
    /// <summary>
    /// A SkillSection is a logically grouped list of Skills and a title for the group. 
    /// </summary>
    public class SkillSection
    {
        /// <summary>
        /// Title of skills group. 
        /// </summary>
        public string SectionTitle { get; set; } = string.Empty;

        /// <summary>
        /// List of Skill objects. 
        /// </summary>
        public List<Skill> SkillList { get; set; } = new(); 
    }
}
