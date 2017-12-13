using System;
using System.IO;
using System.Reflection;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MHWSS
{
    class Data
    {
        private List<Skill> _skillList;
        private List<ActiveSkill> _selectedSkillList;

        private static String _skillFileResource = "MHWSS.skills.txt";
        private static String _helmFileResource = "MHWSS.helm.txt";
        private static String _bodyFileResource = "MHWSS.body.txt";
        private static String _armFileResource = "MHWSS.arms.txt";
        private static String _waistFileResource = "MHWSS.waist.txt";
        private static String _legFileResource = "MHWSS.legs.txt";

        public static bool ConvertToBool(string input)
        {
            if (input == "0")
            {
                return false;
            }
            return true;
        }

        public static int ConvertToInt(string input)
        {
            return int.Parse(input);
        }

        public Data()
        {
            _skillList = new List<Skill>();
            _selectedSkillList = new List<ActiveSkill>();
            LoadData();
        }
        
        public void LoadData()
        {
            LoadSkills();
            LoadGear();
        }

        private void LoadSkills()
        {
            int id = 0;
            Assembly assembly = Assembly.GetExecutingAssembly();
            StreamReader reader = new StreamReader(assembly.GetManifestResourceStream(_skillFileResource));
            while (reader.Peek() >= 0)
            {
                string str;
                string[] strArray;
                str = reader.ReadLine();

                if (str.ElementAt(0) != '#')
                {
                    strArray = str.Split('|');
                    Skill skill = new Skill(id, strArray[0], strArray[1], ConvertToBool(strArray[2]), ConvertToInt(strArray[3]));

                    _skillList.Add(skill);
                    id += 1;
                }
            }
        }

        private void LoadGear()
        {

        }

        public List<Skill> GetSkillList()
        {
            return _skillList;
        }

        public List<ActiveSkill> GetSelectedSkillList()
        {
            return _selectedSkillList;
        }

        public void AddToSelectedSkillList(ActiveSkill activeSkill)
        {
            _selectedSkillList.Add(activeSkill);
        }
    }
}
