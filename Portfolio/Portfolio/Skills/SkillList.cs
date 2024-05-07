namespace Portfolio.Skills
{
    /// <summary>
    /// A SkillList is a list of SkillSection objects, which themselves contain a
    /// logically grouped list of Skills and a title for the group. 
    /// </summary>
    public class SkillList
    {
        /// <summary>
        /// List of SkillSection objects. 
        /// </summary>
        public List<SkillSection> SkillSections { get; set; } = new();
    }
}
