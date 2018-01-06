using System.Collections.Generic;

namespace MHWSS
{
    public class Skill
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public bool SetBonus { get; set; }
        public int MaxLevel { get; set; }
        public List<ActiveSkill> ActiveSkills { get; set; }

        public Skill(int id, string name, string description, bool setBonus, int maxLevel)
        {
            Id = id;
            Name = name;
            Description = description;
            SetBonus = setBonus;
            MaxLevel = maxLevel;
            ActiveSkills = new List<ActiveSkill>();
            FormActiveSkillList();
        }

        private void FormActiveSkillList()
        {
            if (SetBonus)
            {
                ActiveSkills.Add(new ActiveSkill(MaxLevel, this));
            }
            else
            {
                for (int i = 0; i < MaxLevel; ++i)
                {
                    ActiveSkills.Add(new ActiveSkill(i + 1, this));
                }
            }
        }

        public override string ToString()
        {
            return Name;
        }
    }
}
