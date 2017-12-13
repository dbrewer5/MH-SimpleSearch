using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MHWSS
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            Data data = new Data();
            allSkillsListBox.DataSource = data.GetSkillList();
        }

        private void allSkillsListBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            Skill skill = allSkillsListBox.SelectedItem as Skill;
            List<ActiveSkill> activeSkills = new List<ActiveSkill>();
            for (int i = 1; i <= skill.GetLevels(); ++i)
            {
                ActiveSkill activeSkill;
                activeSkill._skill = skill;
                activeSkill._points = i;
                activeSkills.Add(activeSkill);
            }
            skillLevelsListBox.DataSource = activeSkills;
        }

        private void skillLevelsListBox_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void selectedSkillsListBox_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void addSkillButton_Click(object sender, EventArgs e)
        {
            ActiveSkill selectedActiveSkill = (ActiveSkill)skillLevelsListBox.SelectedItem;
            foreach (ActiveSkill current in selectedSkillsListBox.Items)
            {
                if (current._skill.GetName() == selectedActiveSkill._skill.GetName())
                {
                    selectedSkillsListBox.Items.Remove(current);
                    break;
                }
            }
            selectedSkillsListBox.Items.Add(skillLevelsListBox.SelectedItem);
        }

        private void removeSkillButton_Click(object sender, EventArgs e)
        {
            selectedSkillsListBox.Items.Remove(selectedSkillsListBox.SelectedItem);
        }
    }
}
