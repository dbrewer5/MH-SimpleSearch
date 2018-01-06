using System.Collections.Generic;

namespace MHWSS
{
    public class Armor
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public int Slots { get; set; }
        public List<ActiveSkill> Skills { get; set; }

        public Armor(int id, string name, int slots)
        {
            Id = id;
            Name = name;
            Slots = slots;
            Skills = new List<ActiveSkill>();
        }

        public bool ContainsSkill(Skill skill)
        {
            foreach (ActiveSkill activeSkill in Skills)
            {
                if (activeSkill.Skill == skill)
                {
                    return true;
                }
            }
            return false;
        }

        public override string ToString()
        {
            return Name + " [" + SlotsToString() + "]";
        }

        private string SlotsToString()
        {
            string slotString = "- - -";
            switch (Slots)
            {
                case 1:
                    slotString = "- - O";
                    break;
                case 2:
                    slotString = "- O O";
                    break;
                case 3:
                    slotString = "O O O";
                    break;
            }
            return slotString;
        }
    }
}
