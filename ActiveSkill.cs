namespace MHWSS
{
    public class ActiveSkill
    {
        public int Level { get; set; }
        public Skill Skill { get; set; }

        public ActiveSkill(int level, Skill skill)
        {
            Level = level;
            Skill = skill;
        }

        public override bool Equals(object obj)
        {
            var activeSkill = obj as ActiveSkill;
            if (activeSkill == null)
            {
                return false;
            }
            return (Skill.Name == activeSkill.Skill.Name) && (Level == activeSkill.Level);
        }

        public override int GetHashCode()
        {
            return Skill.Name.GetHashCode() + Level;
        }

        public override string ToString()
        {
            return (Skill.SetBonus) ? Skill.Name : Skill.Name + " [" + Level + "]";
        }
    }
}
