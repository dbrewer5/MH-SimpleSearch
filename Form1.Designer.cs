namespace MHWSS
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.mainLayoutTable = new System.Windows.Forms.TableLayoutPanel();
            this.AllSkillsGroupBox = new System.Windows.Forms.GroupBox();
            this.AllSkillsListBox = new System.Windows.Forms.ListBox();
            this.skillLevelsGroupBox = new System.Windows.Forms.GroupBox();
            this.skillLevelsLayoutTable = new System.Windows.Forms.TableLayoutPanel();
            this.AddSkillButton = new System.Windows.Forms.Button();
            this.SkillLevelsListBox = new System.Windows.Forms.ListBox();
            this.selectedSkillsGroupBox = new System.Windows.Forms.GroupBox();
            this.SelectedSkillsLayoutTable = new System.Windows.Forms.TableLayoutPanel();
            this.selectedSkillButtonLayoutTable = new System.Windows.Forms.TableLayoutPanel();
            this.RemoveSkillButton = new System.Windows.Forms.Button();
            this.SearchButton = new System.Windows.Forms.Button();
            this.SelectedSkillListBox = new System.Windows.Forms.ListBox();
            this.SearchResultGroupBox = new System.Windows.Forms.GroupBox();
            this.MenuItems = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.viewToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.optionsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.SearchResultTextBox = new System.Windows.Forms.TextBox();
            this.mainLayoutTable.SuspendLayout();
            this.AllSkillsGroupBox.SuspendLayout();
            this.skillLevelsGroupBox.SuspendLayout();
            this.skillLevelsLayoutTable.SuspendLayout();
            this.selectedSkillsGroupBox.SuspendLayout();
            this.SelectedSkillsLayoutTable.SuspendLayout();
            this.selectedSkillButtonLayoutTable.SuspendLayout();
            this.SearchResultGroupBox.SuspendLayout();
            this.MenuItems.SuspendLayout();
            this.SuspendLayout();
            // 
            // mainLayoutTable
            // 
            this.mainLayoutTable.ColumnCount = 4;
            this.mainLayoutTable.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.mainLayoutTable.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.mainLayoutTable.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.mainLayoutTable.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 40F));
            this.mainLayoutTable.Controls.Add(this.AllSkillsGroupBox, 0, 0);
            this.mainLayoutTable.Controls.Add(this.skillLevelsGroupBox, 1, 0);
            this.mainLayoutTable.Controls.Add(this.selectedSkillsGroupBox, 2, 0);
            this.mainLayoutTable.Controls.Add(this.SearchResultGroupBox, 3, 0);
            this.mainLayoutTable.Dock = System.Windows.Forms.DockStyle.Fill;
            this.mainLayoutTable.Location = new System.Drawing.Point(0, 24);
            this.mainLayoutTable.Name = "mainLayoutTable";
            this.mainLayoutTable.Padding = new System.Windows.Forms.Padding(3);
            this.mainLayoutTable.RowCount = 1;
            this.mainLayoutTable.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.mainLayoutTable.Size = new System.Drawing.Size(953, 293);
            this.mainLayoutTable.TabIndex = 0;
            this.mainLayoutTable.Paint += new System.Windows.Forms.PaintEventHandler(this.MainLayoutTable_Paint);
            // 
            // AllSkillsGroupBox
            // 
            this.AllSkillsGroupBox.Controls.Add(this.AllSkillsListBox);
            this.AllSkillsGroupBox.Dock = System.Windows.Forms.DockStyle.Fill;
            this.AllSkillsGroupBox.Location = new System.Drawing.Point(6, 6);
            this.AllSkillsGroupBox.Name = "AllSkillsGroupBox";
            this.AllSkillsGroupBox.Padding = new System.Windows.Forms.Padding(5);
            this.AllSkillsGroupBox.Size = new System.Drawing.Size(183, 281);
            this.AllSkillsGroupBox.TabIndex = 0;
            this.AllSkillsGroupBox.TabStop = false;
            this.AllSkillsGroupBox.Text = "All Skills";
            this.AllSkillsGroupBox.Enter += new System.EventHandler(this.AllSkillsGroupBox_Enter);
            // 
            // AllSkillsListBox
            // 
            this.AllSkillsListBox.Dock = System.Windows.Forms.DockStyle.Fill;
            this.AllSkillsListBox.FormattingEnabled = true;
            this.AllSkillsListBox.Location = new System.Drawing.Point(5, 18);
            this.AllSkillsListBox.Name = "AllSkillsListBox";
            this.AllSkillsListBox.Size = new System.Drawing.Size(173, 258);
            this.AllSkillsListBox.TabIndex = 0;
            this.AllSkillsListBox.SelectedIndexChanged += new System.EventHandler(this.AllSkillsListBox_SelectedIndexChanged);
            // 
            // skillLevelsGroupBox
            // 
            this.skillLevelsGroupBox.Controls.Add(this.skillLevelsLayoutTable);
            this.skillLevelsGroupBox.Dock = System.Windows.Forms.DockStyle.Fill;
            this.skillLevelsGroupBox.Location = new System.Drawing.Point(195, 6);
            this.skillLevelsGroupBox.Name = "skillLevelsGroupBox";
            this.skillLevelsGroupBox.Padding = new System.Windows.Forms.Padding(5);
            this.skillLevelsGroupBox.Size = new System.Drawing.Size(183, 281);
            this.skillLevelsGroupBox.TabIndex = 3;
            this.skillLevelsGroupBox.TabStop = false;
            this.skillLevelsGroupBox.Text = "Skill Levels";
            // 
            // skillLevelsLayoutTable
            // 
            this.skillLevelsLayoutTable.ColumnCount = 1;
            this.skillLevelsLayoutTable.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.skillLevelsLayoutTable.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.skillLevelsLayoutTable.Controls.Add(this.AddSkillButton, 0, 1);
            this.skillLevelsLayoutTable.Controls.Add(this.SkillLevelsListBox, 0, 0);
            this.skillLevelsLayoutTable.Dock = System.Windows.Forms.DockStyle.Fill;
            this.skillLevelsLayoutTable.Location = new System.Drawing.Point(5, 18);
            this.skillLevelsLayoutTable.Margin = new System.Windows.Forms.Padding(0);
            this.skillLevelsLayoutTable.Name = "skillLevelsLayoutTable";
            this.skillLevelsLayoutTable.RowCount = 2;
            this.skillLevelsLayoutTable.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 90F));
            this.skillLevelsLayoutTable.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 10F));
            this.skillLevelsLayoutTable.Size = new System.Drawing.Size(173, 258);
            this.skillLevelsLayoutTable.TabIndex = 0;
            // 
            // AddSkillButton
            // 
            this.AddSkillButton.Dock = System.Windows.Forms.DockStyle.Fill;
            this.AddSkillButton.Location = new System.Drawing.Point(0, 232);
            this.AddSkillButton.Margin = new System.Windows.Forms.Padding(0);
            this.AddSkillButton.Name = "AddSkillButton";
            this.AddSkillButton.Size = new System.Drawing.Size(173, 26);
            this.AddSkillButton.TabIndex = 1;
            this.AddSkillButton.Text = "Add Skill to Selected";
            this.AddSkillButton.UseVisualStyleBackColor = true;
            this.AddSkillButton.Click += new System.EventHandler(this.AddSkillButton_Click);
            // 
            // SkillLevelsListBox
            // 
            this.SkillLevelsListBox.Dock = System.Windows.Forms.DockStyle.Fill;
            this.SkillLevelsListBox.FormattingEnabled = true;
            this.SkillLevelsListBox.Location = new System.Drawing.Point(3, 3);
            this.SkillLevelsListBox.Name = "SkillLevelsListBox";
            this.SkillLevelsListBox.Size = new System.Drawing.Size(167, 226);
            this.SkillLevelsListBox.TabIndex = 2;
            // 
            // selectedSkillsGroupBox
            // 
            this.selectedSkillsGroupBox.Controls.Add(this.SelectedSkillsLayoutTable);
            this.selectedSkillsGroupBox.Dock = System.Windows.Forms.DockStyle.Fill;
            this.selectedSkillsGroupBox.Location = new System.Drawing.Point(384, 6);
            this.selectedSkillsGroupBox.Name = "selectedSkillsGroupBox";
            this.selectedSkillsGroupBox.Padding = new System.Windows.Forms.Padding(5);
            this.selectedSkillsGroupBox.Size = new System.Drawing.Size(183, 281);
            this.selectedSkillsGroupBox.TabIndex = 4;
            this.selectedSkillsGroupBox.TabStop = false;
            this.selectedSkillsGroupBox.Text = "Selected Skills";
            // 
            // SelectedSkillsLayoutTable
            // 
            this.SelectedSkillsLayoutTable.ColumnCount = 1;
            this.SelectedSkillsLayoutTable.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.SelectedSkillsLayoutTable.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.SelectedSkillsLayoutTable.Controls.Add(this.selectedSkillButtonLayoutTable, 0, 1);
            this.SelectedSkillsLayoutTable.Controls.Add(this.SelectedSkillListBox, 0, 0);
            this.SelectedSkillsLayoutTable.Dock = System.Windows.Forms.DockStyle.Fill;
            this.SelectedSkillsLayoutTable.Location = new System.Drawing.Point(5, 18);
            this.SelectedSkillsLayoutTable.Margin = new System.Windows.Forms.Padding(0);
            this.SelectedSkillsLayoutTable.Name = "SelectedSkillsLayoutTable";
            this.SelectedSkillsLayoutTable.RowCount = 2;
            this.SelectedSkillsLayoutTable.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 90F));
            this.SelectedSkillsLayoutTable.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 10F));
            this.SelectedSkillsLayoutTable.Size = new System.Drawing.Size(173, 258);
            this.SelectedSkillsLayoutTable.TabIndex = 0;
            // 
            // selectedSkillButtonLayoutTable
            // 
            this.selectedSkillButtonLayoutTable.ColumnCount = 2;
            this.selectedSkillButtonLayoutTable.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.selectedSkillButtonLayoutTable.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.selectedSkillButtonLayoutTable.Controls.Add(this.RemoveSkillButton, 0, 0);
            this.selectedSkillButtonLayoutTable.Controls.Add(this.SearchButton, 1, 0);
            this.selectedSkillButtonLayoutTable.Dock = System.Windows.Forms.DockStyle.Fill;
            this.selectedSkillButtonLayoutTable.Location = new System.Drawing.Point(0, 232);
            this.selectedSkillButtonLayoutTable.Margin = new System.Windows.Forms.Padding(0);
            this.selectedSkillButtonLayoutTable.Name = "selectedSkillButtonLayoutTable";
            this.selectedSkillButtonLayoutTable.RowCount = 1;
            this.selectedSkillButtonLayoutTable.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.selectedSkillButtonLayoutTable.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.selectedSkillButtonLayoutTable.Size = new System.Drawing.Size(173, 26);
            this.selectedSkillButtonLayoutTable.TabIndex = 1;
            // 
            // RemoveSkillButton
            // 
            this.RemoveSkillButton.Dock = System.Windows.Forms.DockStyle.Fill;
            this.RemoveSkillButton.Location = new System.Drawing.Point(0, 0);
            this.RemoveSkillButton.Margin = new System.Windows.Forms.Padding(0);
            this.RemoveSkillButton.Name = "RemoveSkillButton";
            this.RemoveSkillButton.Size = new System.Drawing.Size(86, 26);
            this.RemoveSkillButton.TabIndex = 0;
            this.RemoveSkillButton.Text = "Remove Skill";
            this.RemoveSkillButton.UseVisualStyleBackColor = true;
            this.RemoveSkillButton.Click += new System.EventHandler(this.RemoveSkillButton_Click);
            // 
            // SearchButton
            // 
            this.SearchButton.Dock = System.Windows.Forms.DockStyle.Fill;
            this.SearchButton.Location = new System.Drawing.Point(86, 0);
            this.SearchButton.Margin = new System.Windows.Forms.Padding(0);
            this.SearchButton.Name = "SearchButton";
            this.SearchButton.Size = new System.Drawing.Size(87, 26);
            this.SearchButton.TabIndex = 1;
            this.SearchButton.Text = "Search";
            this.SearchButton.UseVisualStyleBackColor = true;
            this.SearchButton.Click += new System.EventHandler(this.SearchButton_Click);
            // 
            // SelectedSkillListBox
            // 
            this.SelectedSkillListBox.Dock = System.Windows.Forms.DockStyle.Fill;
            this.SelectedSkillListBox.FormattingEnabled = true;
            this.SelectedSkillListBox.Location = new System.Drawing.Point(3, 3);
            this.SelectedSkillListBox.Name = "SelectedSkillListBox";
            this.SelectedSkillListBox.Size = new System.Drawing.Size(167, 226);
            this.SelectedSkillListBox.TabIndex = 2;
            this.SelectedSkillListBox.SelectedIndexChanged += new System.EventHandler(this.SelectedSkillListBox_SelectedIndexChanged);
            // 
            // SearchResultGroupBox
            // 
            this.SearchResultGroupBox.Controls.Add(this.SearchResultTextBox);
            this.SearchResultGroupBox.Dock = System.Windows.Forms.DockStyle.Fill;
            this.SearchResultGroupBox.Location = new System.Drawing.Point(573, 6);
            this.SearchResultGroupBox.Name = "SearchResultGroupBox";
            this.SearchResultGroupBox.Padding = new System.Windows.Forms.Padding(5);
            this.SearchResultGroupBox.Size = new System.Drawing.Size(374, 281);
            this.SearchResultGroupBox.TabIndex = 5;
            this.SearchResultGroupBox.TabStop = false;
            this.SearchResultGroupBox.Text = "Search Results";
            this.SearchResultGroupBox.Enter += new System.EventHandler(this.SearchResultGroupBox_Enter);
            // 
            // MenuItems
            // 
            this.MenuItems.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem,
            this.viewToolStripMenuItem,
            this.optionsToolStripMenuItem});
            this.MenuItems.Location = new System.Drawing.Point(0, 0);
            this.MenuItems.Name = "MenuItems";
            this.MenuItems.Size = new System.Drawing.Size(953, 24);
            this.MenuItems.TabIndex = 1;
            this.MenuItems.Text = "MenuItems";
            this.MenuItems.ItemClicked += new System.Windows.Forms.ToolStripItemClickedEventHandler(this.MenuItems_ItemClicked);
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(37, 20);
            this.fileToolStripMenuItem.Text = "File";
            // 
            // viewToolStripMenuItem
            // 
            this.viewToolStripMenuItem.Name = "viewToolStripMenuItem";
            this.viewToolStripMenuItem.Size = new System.Drawing.Size(44, 20);
            this.viewToolStripMenuItem.Text = "View";
            // 
            // optionsToolStripMenuItem
            // 
            this.optionsToolStripMenuItem.Name = "optionsToolStripMenuItem";
            this.optionsToolStripMenuItem.Size = new System.Drawing.Size(61, 20);
            this.optionsToolStripMenuItem.Text = "Options";
            // 
            // SearchResultTextBox
            // 
            this.SearchResultTextBox.AcceptsReturn = true;
            this.SearchResultTextBox.AcceptsTab = true;
            this.SearchResultTextBox.BackColor = System.Drawing.SystemColors.Window;
            this.SearchResultTextBox.Dock = System.Windows.Forms.DockStyle.Fill;
            this.SearchResultTextBox.Location = new System.Drawing.Point(5, 18);
            this.SearchResultTextBox.Multiline = true;
            this.SearchResultTextBox.Name = "SearchResultTextBox";
            this.SearchResultTextBox.ReadOnly = true;
            this.SearchResultTextBox.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.SearchResultTextBox.Size = new System.Drawing.Size(364, 258);
            this.SearchResultTextBox.TabIndex = 0;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(953, 317);
            this.Controls.Add(this.mainLayoutTable);
            this.Controls.Add(this.MenuItems);
            this.MainMenuStrip = this.MenuItems;
            this.Name = "Form1";
            this.Text = "Form1";
            this.mainLayoutTable.ResumeLayout(false);
            this.AllSkillsGroupBox.ResumeLayout(false);
            this.skillLevelsGroupBox.ResumeLayout(false);
            this.skillLevelsLayoutTable.ResumeLayout(false);
            this.selectedSkillsGroupBox.ResumeLayout(false);
            this.SelectedSkillsLayoutTable.ResumeLayout(false);
            this.selectedSkillButtonLayoutTable.ResumeLayout(false);
            this.SearchResultGroupBox.ResumeLayout(false);
            this.SearchResultGroupBox.PerformLayout();
            this.MenuItems.ResumeLayout(false);
            this.MenuItems.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel mainLayoutTable;
        private System.Windows.Forms.GroupBox AllSkillsGroupBox;
        private System.Windows.Forms.ListBox AllSkillsListBox;
        private System.Windows.Forms.GroupBox skillLevelsGroupBox;
        private System.Windows.Forms.TableLayoutPanel skillLevelsLayoutTable;
        private System.Windows.Forms.GroupBox selectedSkillsGroupBox;
        private System.Windows.Forms.TableLayoutPanel SelectedSkillsLayoutTable;
        private System.Windows.Forms.Button AddSkillButton;
        private System.Windows.Forms.TableLayoutPanel selectedSkillButtonLayoutTable;
        private System.Windows.Forms.Button RemoveSkillButton;
        private System.Windows.Forms.Button SearchButton;
        private System.Windows.Forms.MenuStrip MenuItems;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem viewToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem optionsToolStripMenuItem;
        private System.Windows.Forms.ListBox SkillLevelsListBox;
        private System.Windows.Forms.ListBox SelectedSkillListBox;
        private System.Windows.Forms.GroupBox SearchResultGroupBox;
        private System.Windows.Forms.TextBox SearchResultTextBox;
    }
}

