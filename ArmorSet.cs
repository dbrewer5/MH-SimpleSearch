using System.Collections.Generic;

namespace MHWSS
{
    public class ArmorSet
    {
        public Armor Helm { get; set; }
        public Armor Body { get; set; }
        public Armor Arms { get; set; }
        public Armor Waist { get; set; }
        public Armor Legs { get; set; }

        public List<ActiveSkill> ActiveSkills;

        public ArmorSet(Armor Helm, Armor Body, Armor Arms, Armor Waist, Armor Legs)
        {
            this.Helm = Helm;
            this.Body = Body;
            this.Arms = Arms;
            this.Waist = Waist;
            this.Legs = Legs;

            FormActiveSkills();
        }

        private void FormActiveSkills()
        {
            Dictionary<Skill, int> skillBuffer = new Dictionary<Skill, int>();

            foreach (ActiveSkill activeSkill in Helm.Skills)
            {
                if (skillBuffer.ContainsKey(activeSkill.Skill))
                {
                    skillBuffer[activeSkill.Skill] += activeSkill.Level;
                }
                else
                {
                    skillBuffer[activeSkill.Skill] = activeSkill.Level;
                }
            }

            foreach (ActiveSkill activeSkill in Body.Skills)
            {
                if (skillBuffer.ContainsKey(activeSkill.Skill))
                {
                    skillBuffer[activeSkill.Skill] += activeSkill.Level;
                }
                else
                {
                    skillBuffer[activeSkill.Skill] = activeSkill.Level;
                }
            }

            foreach (ActiveSkill activeSkill in Arms.Skills)
            {
                if (skillBuffer.ContainsKey(activeSkill.Skill))
                {
                    skillBuffer[activeSkill.Skill] += activeSkill.Level;
                }
                else
                {
                    skillBuffer[activeSkill.Skill] = activeSkill.Level;
                }
            }

            foreach (ActiveSkill activeSkill in Waist.Skills)
            {
                if (skillBuffer.ContainsKey(activeSkill.Skill))
                {
                    skillBuffer[activeSkill.Skill] += activeSkill.Level;
                }
                else
                {
                    skillBuffer[activeSkill.Skill] = activeSkill.Level;
                }
            }

            foreach (ActiveSkill activeSkill in Legs.Skills)
            {
                if (skillBuffer.ContainsKey(activeSkill.Skill))
                {
                    skillBuffer[activeSkill.Skill] += activeSkill.Level;
                }
                else
                {
                    skillBuffer[activeSkill.Skill] = activeSkill.Level;
                }
            }

            ActiveSkills = ConvertToActiveSkills(skillBuffer);
        }

        public bool VerifyArmorSet(List<ActiveSkill> selectedSkills)
        {
            foreach (ActiveSkill selectedSkill in selectedSkills)
            {
                if (!(ActiveSkills.Contains(selectedSkill)))
                {
                    return false;
                }
            }
            return true;
        }

        private List<ActiveSkill> ConvertToActiveSkills(Dictionary<Skill, int> skillBuffer)
        {
            List<ActiveSkill> activeSkills = new List<ActiveSkill>();
            foreach (KeyValuePair<Skill, int> entry in skillBuffer)
            {
                activeSkills.Add(entry.Key.ActiveSkills[entry.Value - 1]);
            }
            return activeSkills;
        }

        public override string ToString()
        {
            string result = Helm + "\r\n" + Body + "\r\n" + Arms + "\r\n" + Waist + "\r\n" + Legs + "\r\n\r\n";
            result += "Skills: \r\n";
            foreach (ActiveSkill activeSkill in ActiveSkills)
            {
                result += activeSkill + "\r\n";
            }
            return result;
        }
    }
}
