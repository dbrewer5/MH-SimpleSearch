using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MHWSS
{
    public struct ActiveSkill
    {
        public Skill _skill;
        public int _points;
        public ActiveSkill(Skill skill, int points)
        {
            _skill = skill;
            _points = points;
        }
        public override string ToString()
        {
            return String.Format("{0} [{1}]", this._skill.GetName(), this._points);
        }
    }

    public class Skill
    {
        private int _id;

        private string _name;

        private string _description;

        private bool _setBonus;

        private int _levels;

        public Skill() { }

        public Skill(int id, string name, string description, bool setBonus, int levels)
        {
            _id = id;
            _name = name;
            _description = description;
            _setBonus = setBonus;
            _levels = levels;
        }

        public string GetName()
        {
            return _name;
        }

        public void SetName(string name)
        {
            _name = name;
        }

        public string GetDescription()
        {
            return _description;
        }

        public void SetDescription(string description)
        {
            _description = description;
        }

        public int GetLevels()
        {
            return _levels;
        }

        public void SetLevels(int levels)
        {
            _levels = levels;
        }

        public bool GetSetBonus()
        {
            return _setBonus;
        }

        public void SetSetBonus(bool setBonus)
        {
            _setBonus = setBonus;
        }

        public override string ToString()
        {
            return String.Format("{0}", this._name);
        }
    }
}
