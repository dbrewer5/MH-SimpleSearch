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
            this.allSkillsGroupBox = new System.Windows.Forms.GroupBox();
            this.allSkillsListBox = new System.Windows.Forms.ListBox();
            this.skillLevelsGroupBox = new System.Windows.Forms.GroupBox();
            this.selectedSkillsGroupBox = new System.Windows.Forms.GroupBox();
            this.skillLevelsLayoutTable = new System.Windows.Forms.TableLayoutPanel();
            this.selectedSkillsLayoutTable = new System.Windows.Forms.TableLayoutPanel();
            this.skillLevelsListBox = new System.Windows.Forms.ListBox();
            this.selectedSkillsListBox = new System.Windows.Forms.ListBox();
            this.addSkillButton = new System.Windows.Forms.Button();
            this.selectedSkillButtonLayoutTable = new System.Windows.Forms.TableLayoutPanel();
            this.removeSkillButton = new System.Windows.Forms.Button();
            this.SearchButton = new System.Windows.Forms.Button();
            this.mainLayoutTable.SuspendLayout();
            this.allSkillsGroupBox.SuspendLayout();
            this.skillLevelsGroupBox.SuspendLayout();
            this.selectedSkillsGroupBox.SuspendLayout();
            this.skillLevelsLayoutTable.SuspendLayout();
            this.selectedSkillsLayoutTable.SuspendLayout();
            this.selectedSkillButtonLayoutTable.SuspendLayout();
            this.SuspendLayout();
            // 
            // mainLayoutTable
            // 
            this.mainLayoutTable.ColumnCount = 4;
            this.mainLayoutTable.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 10F));
            this.mainLayoutTable.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 30F));
            this.mainLayoutTable.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 30F));
            this.mainLayoutTable.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 30F));
            this.mainLayoutTable.Controls.Add(this.allSkillsGroupBox, 1, 0);
            this.mainLayoutTable.Controls.Add(this.skillLevelsGroupBox, 2, 0);
            this.mainLayoutTable.Controls.Add(this.selectedSkillsGroupBox, 3, 0);
            this.mainLayoutTable.Dock = System.Windows.Forms.DockStyle.Fill;
            this.mainLayoutTable.Location = new System.Drawing.Point(0, 0);
            this.mainLayoutTable.Name = "mainLayoutTable";
            this.mainLayoutTable.Padding = new System.Windows.Forms.Padding(3);
            this.mainLayoutTable.RowCount = 1;
            this.mainLayoutTable.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.mainLayoutTable.Size = new System.Drawing.Size(644, 317);
            this.mainLayoutTable.TabIndex = 0;
            // 
            // allSkillsGroupBox
            // 
            this.allSkillsGroupBox.Controls.Add(this.allSkillsListBox);
            this.allSkillsGroupBox.Dock = System.Windows.Forms.DockStyle.Fill;
            this.allSkillsGroupBox.Location = new System.Drawing.Point(69, 6);
            this.allSkillsGroupBox.Name = "allSkillsGroupBox";
            this.allSkillsGroupBox.Padding = new System.Windows.Forms.Padding(5);
            this.allSkillsGroupBox.Size = new System.Drawing.Size(185, 305);
            this.allSkillsGroupBox.TabIndex = 0;
            this.allSkillsGroupBox.TabStop = false;
            this.allSkillsGroupBox.Text = "All Skills";
            // 
            // allSkillsListBox
            // 
            this.allSkillsListBox.Dock = System.Windows.Forms.DockStyle.Fill;
            this.allSkillsListBox.FormattingEnabled = true;
            this.allSkillsListBox.Location = new System.Drawing.Point(5, 18);
            this.allSkillsListBox.Name = "allSkillsListBox";
            this.allSkillsListBox.Size = new System.Drawing.Size(175, 282);
            this.allSkillsListBox.TabIndex = 0;
            this.allSkillsListBox.SelectedIndexChanged += new System.EventHandler(this.allSkillsListBox_SelectedIndexChanged);
            // 
            // skillLevelsGroupBox
            // 
            this.skillLevelsGroupBox.Controls.Add(this.skillLevelsLayoutTable);
            this.skillLevelsGroupBox.Dock = System.Windows.Forms.DockStyle.Fill;
            this.skillLevelsGroupBox.Location = new System.Drawing.Point(260, 6);
            this.skillLevelsGroupBox.Name = "skillLevelsGroupBox";
            this.skillLevelsGroupBox.Padding = new System.Windows.Forms.Padding(5);
            this.skillLevelsGroupBox.Size = new System.Drawing.Size(185, 305);
            this.skillLevelsGroupBox.TabIndex = 3;
            this.skillLevelsGroupBox.TabStop = false;
            this.skillLevelsGroupBox.Text = "Skill Levels";
            // 
            // selectedSkillsGroupBox
            // 
            this.selectedSkillsGroupBox.Controls.Add(this.selectedSkillsLayoutTable);
            this.selectedSkillsGroupBox.Dock = System.Windows.Forms.DockStyle.Fill;
            this.selectedSkillsGroupBox.Location = new System.Drawing.Point(451, 6);
            this.selectedSkillsGroupBox.Name = "selectedSkillsGroupBox";
            this.selectedSkillsGroupBox.Padding = new System.Windows.Forms.Padding(5);
            this.selectedSkillsGroupBox.Size = new System.Drawing.Size(187, 305);
            this.selectedSkillsGroupBox.TabIndex = 4;
            this.selectedSkillsGroupBox.TabStop = false;
            this.selectedSkillsGroupBox.Text = "Selected Skills";
            // 
            // skillLevelsLayoutTable
            // 
            this.skillLevelsLayoutTable.ColumnCount = 1;
            this.skillLevelsLayoutTable.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.skillLevelsLayoutTable.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.skillLevelsLayoutTable.Controls.Add(this.skillLevelsListBox, 0, 0);
            this.skillLevelsLayoutTable.Controls.Add(this.addSkillButton, 0, 1);
            this.skillLevelsLayoutTable.Dock = System.Windows.Forms.DockStyle.Fill;
            this.skillLevelsLayoutTable.Location = new System.Drawing.Point(5, 18);
            this.skillLevelsLayoutTable.Margin = new System.Windows.Forms.Padding(0);
            this.skillLevelsLayoutTable.Name = "skillLevelsLayoutTable";
            this.skillLevelsLayoutTable.RowCount = 2;
            this.skillLevelsLayoutTable.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 90F));
            this.skillLevelsLayoutTable.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 10F));
            this.skillLevelsLayoutTable.Size = new System.Drawing.Size(175, 282);
            this.skillLevelsLayoutTable.TabIndex = 0;
            // 
            // selectedSkillsLayoutTable
            // 
            this.selectedSkillsLayoutTable.ColumnCount = 1;
            this.selectedSkillsLayoutTable.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.selectedSkillsLayoutTable.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.selectedSkillsLayoutTable.Controls.Add(this.selectedSkillsListBox, 0, 0);
            this.selectedSkillsLayoutTable.Controls.Add(this.selectedSkillButtonLayoutTable, 0, 1);
            this.selectedSkillsLayoutTable.Dock = System.Windows.Forms.DockStyle.Fill;
            this.selectedSkillsLayoutTable.Location = new System.Drawing.Point(5, 18);
            this.selectedSkillsLayoutTable.Margin = new System.Windows.Forms.Padding(0);
            this.selectedSkillsLayoutTable.Name = "selectedSkillsLayoutTable";
            this.selectedSkillsLayoutTable.RowCount = 2;
            this.selectedSkillsLayoutTable.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 90F));
            this.selectedSkillsLayoutTable.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 10F));
            this.selectedSkillsLayoutTable.Size = new System.Drawing.Size(177, 282);
            this.selectedSkillsLayoutTable.TabIndex = 0;
            // 
            // skillLevelsListBox
            // 
            this.skillLevelsListBox.Dock = System.Windows.Forms.DockStyle.Fill;
            this.skillLevelsListBox.FormattingEnabled = true;
            this.skillLevelsListBox.Location = new System.Drawing.Point(0, 0);
            this.skillLevelsListBox.Margin = new System.Windows.Forms.Padding(0);
            this.skillLevelsListBox.Name = "skillLevelsListBox";
            this.skillLevelsListBox.Size = new System.Drawing.Size(175, 253);
            this.skillLevelsListBox.TabIndex = 0;
            this.skillLevelsListBox.SelectedIndexChanged += new System.EventHandler(this.skillLevelsListBox_SelectedIndexChanged);
            // 
            // selectedSkillsListBox
            // 
            this.selectedSkillsListBox.Dock = System.Windows.Forms.DockStyle.Fill;
            this.selectedSkillsListBox.FormattingEnabled = true;
            this.selectedSkillsListBox.Location = new System.Drawing.Point(0, 0);
            this.selectedSkillsListBox.Margin = new System.Windows.Forms.Padding(0);
            this.selectedSkillsListBox.Name = "selectedSkillsListBox";
            this.selectedSkillsListBox.Size = new System.Drawing.Size(177, 253);
            this.selectedSkillsListBox.TabIndex = 0;
            this.selectedSkillsListBox.SelectedIndexChanged += new System.EventHandler(this.selectedSkillsListBox_SelectedIndexChanged);
            // 
            // addSkillButton
            // 
            this.addSkillButton.Dock = System.Windows.Forms.DockStyle.Fill;
            this.addSkillButton.Location = new System.Drawing.Point(0, 253);
            this.addSkillButton.Margin = new System.Windows.Forms.Padding(0);
            this.addSkillButton.Name = "addSkillButton";
            this.addSkillButton.Size = new System.Drawing.Size(175, 29);
            this.addSkillButton.TabIndex = 1;
            this.addSkillButton.Text = "Add Skill to Selected";
            this.addSkillButton.UseVisualStyleBackColor = true;
            this.addSkillButton.Click += new System.EventHandler(this.addSkillButton_Click);
            // 
            // selectedSkillButtonLayoutTable
            // 
            this.selectedSkillButtonLayoutTable.ColumnCount = 2;
            this.selectedSkillButtonLayoutTable.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.selectedSkillButtonLayoutTable.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.selectedSkillButtonLayoutTable.Controls.Add(this.removeSkillButton, 0, 0);
            this.selectedSkillButtonLayoutTable.Controls.Add(this.SearchButton, 1, 0);
            this.selectedSkillButtonLayoutTable.Dock = System.Windows.Forms.DockStyle.Fill;
            this.selectedSkillButtonLayoutTable.Location = new System.Drawing.Point(0, 253);
            this.selectedSkillButtonLayoutTable.Margin = new System.Windows.Forms.Padding(0);
            this.selectedSkillButtonLayoutTable.Name = "selectedSkillButtonLayoutTable";
            this.selectedSkillButtonLayoutTable.RowCount = 1;
            this.selectedSkillButtonLayoutTable.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.selectedSkillButtonLayoutTable.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.selectedSkillButtonLayoutTable.Size = new System.Drawing.Size(177, 29);
            this.selectedSkillButtonLayoutTable.TabIndex = 1;
            // 
            // removeSkillButton
            // 
            this.removeSkillButton.Dock = System.Windows.Forms.DockStyle.Fill;
            this.removeSkillButton.Location = new System.Drawing.Point(0, 0);
            this.removeSkillButton.Margin = new System.Windows.Forms.Padding(0);
            this.removeSkillButton.Name = "removeSkillButton";
            this.removeSkillButton.Size = new System.Drawing.Size(88, 29);
            this.removeSkillButton.TabIndex = 0;
            this.removeSkillButton.Text = "Remove Skill";
            this.removeSkillButton.UseVisualStyleBackColor = true;
            this.removeSkillButton.Click += new System.EventHandler(this.removeSkillButton_Click);
            // 
            // SearchButton
            // 
            this.SearchButton.Dock = System.Windows.Forms.DockStyle.Fill;
            this.SearchButton.Location = new System.Drawing.Point(88, 0);
            this.SearchButton.Margin = new System.Windows.Forms.Padding(0);
            this.SearchButton.Name = "SearchButton";
            this.SearchButton.Size = new System.Drawing.Size(89, 29);
            this.SearchButton.TabIndex = 1;
            this.SearchButton.Text = "Search";
            this.SearchButton.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(644, 317);
            this.Controls.Add(this.mainLayoutTable);
            this.Name = "Form1";
            this.Text = "Form1";
            this.mainLayoutTable.ResumeLayout(false);
            this.allSkillsGroupBox.ResumeLayout(false);
            this.skillLevelsGroupBox.ResumeLayout(false);
            this.selectedSkillsGroupBox.ResumeLayout(false);
            this.skillLevelsLayoutTable.ResumeLayout(false);
            this.selectedSkillsLayoutTable.ResumeLayout(false);
            this.selectedSkillButtonLayoutTable.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel mainLayoutTable;
        private System.Windows.Forms.GroupBox allSkillsGroupBox;
        private System.Windows.Forms.ListBox allSkillsListBox;
        private System.Windows.Forms.GroupBox skillLevelsGroupBox;
        private System.Windows.Forms.TableLayoutPanel skillLevelsLayoutTable;
        private System.Windows.Forms.ListBox skillLevelsListBox;
        private System.Windows.Forms.GroupBox selectedSkillsGroupBox;
        private System.Windows.Forms.TableLayoutPanel selectedSkillsLayoutTable;
        private System.Windows.Forms.ListBox selectedSkillsListBox;
        private System.Windows.Forms.Button addSkillButton;
        private System.Windows.Forms.TableLayoutPanel selectedSkillButtonLayoutTable;
        private System.Windows.Forms.Button removeSkillButton;
        private System.Windows.Forms.Button SearchButton;
    }
}

