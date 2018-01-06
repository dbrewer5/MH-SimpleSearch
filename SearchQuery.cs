using System.ComponentModel;

namespace MHWSS
{
    public class SearchQuery
    {
        public BindingList<ActiveSkill> SelectedSkills { get; set; }
        public int WeaponSlots { get; set; }

        public SearchQuery()
        {
            SelectedSkills = new BindingList<ActiveSkill>();
        }

        public int AddSearchSkill(ActiveSkill activeSkill)
        {
            int index = IndexToInsert(activeSkill);
            SelectedSkills.Insert(index, activeSkill);
            return index;
        }

        public void RemoveSelectedSkillByIndex(int index)
        {
            if (index != -1) // Index exists
            {
                SelectedSkills.RemoveAt(index);
            }
        }

        private int IndexToInsert(ActiveSkill activeSkill)
        {
            int index = 0;
            while (index < SelectedSkills.Count)
            {
                if (SelectedSkills[index].Skill == activeSkill.Skill)
                {
                    SelectedSkills.RemoveAt(index);
                    break;
                }
                ++index;
            }
            return index;
        }
    }
}
