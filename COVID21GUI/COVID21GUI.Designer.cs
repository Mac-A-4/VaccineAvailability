
namespace COVID21GUI {
    partial class COVID21GUI {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing) {
            if (disposing && (components != null)) {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent() {
            this.ageLabel = new System.Windows.Forms.Label();
            this.ageSelect = new System.Windows.Forms.NumericUpDown();
            this.industryLabel = new System.Windows.Forms.Label();
            this.industrySelect = new System.Windows.Forms.ComboBox();
            this.countyLabel = new System.Windows.Forms.Label();
            this.countySelect = new System.Windows.Forms.ComboBox();
            this.zipList = new System.Windows.Forms.ListBox();
            this.zipInput = new System.Windows.Forms.TextBox();
            this.addButton = new System.Windows.Forms.Button();
            this.removeButton = new System.Windows.Forms.Button();
            this.outputList = new System.Windows.Forms.ListBox();
            this.searchButton = new System.Windows.Forms.Button();
            this.progressBar = new System.Windows.Forms.ProgressBar();
            this.timeLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.ageSelect)).BeginInit();
            this.SuspendLayout();
            // 
            // ageLabel
            // 
            this.ageLabel.AutoSize = true;
            this.ageLabel.Location = new System.Drawing.Point(30, 9);
            this.ageLabel.Name = "ageLabel";
            this.ageLabel.Size = new System.Drawing.Size(29, 13);
            this.ageLabel.TabIndex = 0;
            this.ageLabel.Text = "Age:";
            // 
            // ageSelect
            // 
            this.ageSelect.Location = new System.Drawing.Point(65, 7);
            this.ageSelect.Maximum = new decimal(new int[] {
            250,
            0,
            0,
            0});
            this.ageSelect.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.ageSelect.Name = "ageSelect";
            this.ageSelect.Size = new System.Drawing.Size(200, 20);
            this.ageSelect.TabIndex = 1;
            this.ageSelect.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // industryLabel
            // 
            this.industryLabel.AutoSize = true;
            this.industryLabel.Location = new System.Drawing.Point(12, 36);
            this.industryLabel.Name = "industryLabel";
            this.industryLabel.Size = new System.Drawing.Size(47, 13);
            this.industryLabel.TabIndex = 2;
            this.industryLabel.Text = "Industry:";
            // 
            // industrySelect
            // 
            this.industrySelect.FormattingEnabled = true;
            this.industrySelect.Location = new System.Drawing.Point(65, 33);
            this.industrySelect.Name = "industrySelect";
            this.industrySelect.Size = new System.Drawing.Size(200, 21);
            this.industrySelect.TabIndex = 3;
            // 
            // countyLabel
            // 
            this.countyLabel.AutoSize = true;
            this.countyLabel.Location = new System.Drawing.Point(16, 63);
            this.countyLabel.Name = "countyLabel";
            this.countyLabel.Size = new System.Drawing.Size(43, 13);
            this.countyLabel.TabIndex = 4;
            this.countyLabel.Text = "County:";
            // 
            // countySelect
            // 
            this.countySelect.FormattingEnabled = true;
            this.countySelect.Location = new System.Drawing.Point(65, 60);
            this.countySelect.Name = "countySelect";
            this.countySelect.Size = new System.Drawing.Size(200, 21);
            this.countySelect.TabIndex = 5;
            // 
            // zipList
            // 
            this.zipList.FormattingEnabled = true;
            this.zipList.Location = new System.Drawing.Point(12, 87);
            this.zipList.Name = "zipList";
            this.zipList.Size = new System.Drawing.Size(253, 173);
            this.zipList.TabIndex = 6;
            // 
            // zipInput
            // 
            this.zipInput.Location = new System.Drawing.Point(12, 266);
            this.zipInput.Name = "zipInput";
            this.zipInput.Size = new System.Drawing.Size(91, 20);
            this.zipInput.TabIndex = 7;
            // 
            // addButton
            // 
            this.addButton.Location = new System.Drawing.Point(109, 266);
            this.addButton.Name = "addButton";
            this.addButton.Size = new System.Drawing.Size(75, 20);
            this.addButton.TabIndex = 8;
            this.addButton.Text = "Add";
            this.addButton.UseVisualStyleBackColor = true;
            this.addButton.Click += new System.EventHandler(this.addButton_Click);
            // 
            // removeButton
            // 
            this.removeButton.Location = new System.Drawing.Point(190, 266);
            this.removeButton.Name = "removeButton";
            this.removeButton.Size = new System.Drawing.Size(75, 20);
            this.removeButton.TabIndex = 9;
            this.removeButton.Text = "Remove";
            this.removeButton.UseVisualStyleBackColor = true;
            this.removeButton.Click += new System.EventHandler(this.removeButton_Click);
            // 
            // outputList
            // 
            this.outputList.FormattingEnabled = true;
            this.outputList.Location = new System.Drawing.Point(271, 7);
            this.outputList.Name = "outputList";
            this.outputList.Size = new System.Drawing.Size(501, 277);
            this.outputList.TabIndex = 10;
            // 
            // searchButton
            // 
            this.searchButton.Location = new System.Drawing.Point(12, 292);
            this.searchButton.Name = "searchButton";
            this.searchButton.Size = new System.Drawing.Size(172, 23);
            this.searchButton.TabIndex = 11;
            this.searchButton.Text = "Search";
            this.searchButton.UseVisualStyleBackColor = true;
            this.searchButton.Click += new System.EventHandler(this.searchButton_Click);
            // 
            // progressBar
            // 
            this.progressBar.Location = new System.Drawing.Point(271, 292);
            this.progressBar.Name = "progressBar";
            this.progressBar.Size = new System.Drawing.Size(501, 23);
            this.progressBar.TabIndex = 12;
            // 
            // timeLabel
            // 
            this.timeLabel.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.timeLabel.Location = new System.Drawing.Point(190, 292);
            this.timeLabel.Name = "timeLabel";
            this.timeLabel.Size = new System.Drawing.Size(75, 23);
            this.timeLabel.TabIndex = 13;
            this.timeLabel.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // COVID21GUI
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(784, 322);
            this.Controls.Add(this.timeLabel);
            this.Controls.Add(this.progressBar);
            this.Controls.Add(this.searchButton);
            this.Controls.Add(this.outputList);
            this.Controls.Add(this.removeButton);
            this.Controls.Add(this.addButton);
            this.Controls.Add(this.zipInput);
            this.Controls.Add(this.zipList);
            this.Controls.Add(this.countySelect);
            this.Controls.Add(this.countyLabel);
            this.Controls.Add(this.industrySelect);
            this.Controls.Add(this.industryLabel);
            this.Controls.Add(this.ageSelect);
            this.Controls.Add(this.ageLabel);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "COVID21GUI";
            this.Text = "COVID21";
            this.Load += new System.EventHandler(this.COVID21GUI_Load);
            ((System.ComponentModel.ISupportInitialize)(this.ageSelect)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label ageLabel;
        private System.Windows.Forms.NumericUpDown ageSelect;
        private System.Windows.Forms.Label industryLabel;
        private System.Windows.Forms.ComboBox industrySelect;
        private System.Windows.Forms.Label countyLabel;
        private System.Windows.Forms.ComboBox countySelect;
        private System.Windows.Forms.ListBox zipList;
        private System.Windows.Forms.TextBox zipInput;
        private System.Windows.Forms.Button addButton;
        private System.Windows.Forms.Button removeButton;
        private System.Windows.Forms.ListBox outputList;
        private System.Windows.Forms.Button searchButton;
        private System.Windows.Forms.ProgressBar progressBar;
        private System.Windows.Forms.Label timeLabel;
    }
}

