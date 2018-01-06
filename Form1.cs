using System;
using System.ComponentModel;
using System.Linq;
using System.Windows.Forms;

namespace MHWSS
{
    public partial class Form1 : Form
    {
        public DataContext Context { get; set; }
        public SearchQuery SearchQuery { get; set; }
        public BindingList<ArmorSet> SearchResult { get; set; }

        public Form1()
        {
            InitializeComponent();

            Context = new DataContext();
            SearchQuery = new SearchQuery();

            AllSkillsListBox.DataSource = Context.Skills;
            SelectedSkillListBox.DataSource = SearchQuery.SelectedSkills;
        }

        private void AllSkillsListBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            SkillLevelsListBox.BeginUpdate();
            SkillLevelsListBox.DataSource = ((Skill)AllSkillsListBox.SelectedItem).ActiveSkills;
            SkillLevelsListBox.EndUpdate();
        }

        private void SelectedSkillsListBox_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void AddSkillButton_Click(object sender, EventArgs e)
        {
            SelectedSkillListBox.BeginUpdate();
            SelectedSkillListBox.SelectedIndex = SearchQuery.AddSearchSkill((ActiveSkill)SkillLevelsListBox.SelectedItem);
            SelectedSkillListBox.EndUpdate();
        }

        private void RemoveSkillButton_Click(object sender, EventArgs e)
        {
            SelectedSkillListBox.BeginUpdate();
            SearchQuery.RemoveSelectedSkillByIndex(SelectedSkillListBox.SelectedIndex);
            SelectedSkillListBox.EndUpdate();
        }

        private void MainLayoutTable_Paint(object sender, PaintEventArgs e)
        {

        }

        private void AllSkillsGroupBox_Enter(object sender, EventArgs e)
        {

        }

        private void AboutToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void SearchButton_Click(object sender, EventArgs e)
        {
            SearchResultTextBox.Clear();
            SearchResult = null;
            SearchResult = Context.SetSearch(SearchQuery.SelectedSkills.ToList());
            SearchResultTextBox.Text = String.Join("\n-----------------------------------------------" + Environment.NewLine, SearchResult);
        }

        private void SelectedSkillListBox_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void MenuItems_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }

        private void SearchResultGroupBox_Enter(object sender, EventArgs e)
        {

        }
    }
}
