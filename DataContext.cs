using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.IO;
using System.Linq;

namespace MHWSS
{
    public class DataContext
    {
        public List<Skill> Skills { get; set; }
        public List<Armor> Helms { get; set; }
        public List<Armor> Body { get; set; }
        public List<Armor> Arms { get; set; }
        public List<Armor> Waist { get; set; }
        public List<Armor> Legs { get; set; }

        private readonly string applicationDataPath = System.AppDomain.CurrentDomain.BaseDirectory + @"\data\";

        private readonly string[] fileNames =
        {
            "skills.txt", "helm.txt", "body.txt", "arms.txt", "waist.txt", "legs.txt"
        };

        public DataContext()
        {
            Load();
        }

        private bool StringToBool(string str)
        {
            return (str == "0" ? false : true);
        }

        private void Load()
        {
            Skills = LoadSkills();
            Helms = LoadArmor(applicationDataPath + fileNames[1]);
            Body = LoadArmor(applicationDataPath + fileNames[2]);
            Arms = LoadArmor(applicationDataPath + fileNames[3]);
            Waist = LoadArmor(applicationDataPath + fileNames[4]);
            Legs = LoadArmor(applicationDataPath + fileNames[5]);
        }

        private List<Skill> LoadSkills()
        {
            List<Skill> skillList = new List<Skill>();
            int count = 0;
            var lines = File.ReadAllLines(applicationDataPath + fileNames[0]);
            foreach (var line in lines)
            {
                if (line.ElementAt(0) != '#')
                {
                    var fields = line.Split('|');
                    Skill skill = new Skill(count, fields[0], fields[1], StringToBool(fields[2]), Convert.ToInt32(fields[3]));
                    skillList.Add(skill);
                    ++count;
                }
            }
            return skillList;
        }

        private List<Armor> LoadArmor(string path)
        {
            List<Armor> armorList = new List<Armor>();
            int count = 0;
            var lines = File.ReadAllLines(path);
            foreach (var line in lines)
            {
                if (line.ElementAt(0) != '#')
                {
                    var fields = line.Split('|');
                    var length = fields.Length;
                    Armor armor = new Armor(count, fields[0], Convert.ToInt32(fields[1]));
                    for (int i = 2; i < length; i += 2)
                    {
                        var indexOfSkill = FindSkillIndexByName(fields[2]);
                        armor.Skills.Add(Skills[indexOfSkill].ActiveSkills[Convert.ToInt32(fields[i + 1]) - 1]);
                    }
                    armorList.Add(armor);
                    ++count;
                }
            }
            return armorList;
        }

        private int FindSkillIndexByName(string name)
        {
            var count = Skills.Count;
            for (int i = 0; i < count; ++i)
            {
                if (Skills[i].Name == name)
                {
                    return i;
                }
            }
            return -1; // Couldn't find the index of Skill.
        }

        private List<Armor> FilterGear(List<ActiveSkill> selectedSkills, List<Armor> armors)
        {
            List<Armor> filteredArmor = new List<Armor>();
            foreach (Armor armor in armors)
            {
                foreach (ActiveSkill activeSkill in selectedSkills)
                {
                    if (armor.ContainsSkill(activeSkill.Skill))
                    {
                        filteredArmor.Add(armor);
                    }
                }
            }
            if (filteredArmor.Count == 0)
            {
                return armors;
            }
            return filteredArmor;
        }

        private BindingList<ArmorSet> GenerateArmorSetCandidates(List<Armor> helms, List<Armor> bodys, List<Armor> arms, List<Armor> waists, List<Armor> legs)
        {
            BindingList<ArmorSet> armorSetCandidates = new BindingList<ArmorSet>();

            foreach (Armor helm in helms)
            {
                foreach (Armor body in bodys)
                {
                    foreach (Armor arm in arms)
                    {
                        foreach (Armor waist in waists)
                        {
                            foreach (Armor leg in legs)
                            {
                                armorSetCandidates.Add(new ArmorSet(helm, body, arm, waist, leg));
                            }
                        }
                    }
                }
            }

            return armorSetCandidates;
        }

        private void VerifyArmorSetCandidates(BindingList<ArmorSet> armorSetCandidates, List<ActiveSkill> selectedSkills)
        {
            int index = 0;
            while (index < armorSetCandidates.Count)
            {
                if (armorSetCandidates[index].VerifyArmorSet(selectedSkills))
                {
                    ++index;
                }
                else
                {
                    armorSetCandidates.RemoveAt(index);
                }
            }
        }

        public BindingList<ArmorSet> SetSearch(List<ActiveSkill> selectedSkills)
        {
            List<Armor> filteredHelms = FilterGear(selectedSkills, Helms);
            List<Armor> filteredBody = FilterGear(selectedSkills, Body);
            List<Armor> filteredArms = FilterGear(selectedSkills, Arms);
            List<Armor> filteredWaist = FilterGear(selectedSkills, Waist);
            List<Armor> filteredLegs = FilterGear(selectedSkills, Legs);

            BindingList<ArmorSet> armorSetCandidates = GenerateArmorSetCandidates(filteredHelms, filteredBody, filteredArms, filteredWaist, filteredLegs);
            VerifyArmorSetCandidates(armorSetCandidates, selectedSkills);
            return armorSetCandidates;
        }
    }
}
