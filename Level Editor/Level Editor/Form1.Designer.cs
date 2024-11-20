namespace Level_Editor
{
    partial class LevelEditor
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
            this.loadMapButton = new System.Windows.Forms.Button();
            this.newMapGroupBox = new System.Windows.Forms.GroupBox();
            this.heightText = new System.Windows.Forms.TextBox();
            this.widthText = new System.Windows.Forms.TextBox();
            this.heightLabel = new System.Windows.Forms.Label();
            this.widthLabel = new System.Windows.Forms.Label();
            this.createMapButton = new System.Windows.Forms.Button();
            this.newMapGroupBox.SuspendLayout();
            this.SuspendLayout();
            // 
            // loadMapButton
            // 
            this.loadMapButton.Location = new System.Drawing.Point(12, 12);
            this.loadMapButton.Name = "loadMapButton";
            this.loadMapButton.Size = new System.Drawing.Size(298, 80);
            this.loadMapButton.TabIndex = 0;
            this.loadMapButton.Text = "Load Map";
            this.loadMapButton.UseVisualStyleBackColor = true;
            this.loadMapButton.UseWaitCursor = true;
            this.loadMapButton.Click += new System.EventHandler(this.loadMapButton_Click);
            // 
            // newMapGroupBox
            // 
            this.newMapGroupBox.Controls.Add(this.heightText);
            this.newMapGroupBox.Controls.Add(this.widthText);
            this.newMapGroupBox.Controls.Add(this.heightLabel);
            this.newMapGroupBox.Controls.Add(this.widthLabel);
            this.newMapGroupBox.Controls.Add(this.createMapButton);
            this.newMapGroupBox.Location = new System.Drawing.Point(12, 98);
            this.newMapGroupBox.Name = "newMapGroupBox";
            this.newMapGroupBox.Size = new System.Drawing.Size(298, 276);
            this.newMapGroupBox.TabIndex = 1;
            this.newMapGroupBox.TabStop = false;
            this.newMapGroupBox.Text = "Create New Map";
            this.newMapGroupBox.UseWaitCursor = true;
            // 
            // heightText
            // 
            this.heightText.Location = new System.Drawing.Point(121, 118);
            this.heightText.Name = "heightText";
            this.heightText.Size = new System.Drawing.Size(162, 22);
            this.heightText.TabIndex = 4;
            this.heightText.Text = "10";
            this.heightText.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.heightText.UseWaitCursor = true;
            // 
            // widthText
            // 
            this.widthText.Location = new System.Drawing.Point(121, 52);
            this.widthText.Name = "widthText";
            this.widthText.Size = new System.Drawing.Size(162, 22);
            this.widthText.TabIndex = 3;
            this.widthText.Text = "10";
            this.widthText.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.widthText.UseWaitCursor = true;
            // 
            // heightLabel
            // 
            this.heightLabel.AutoSize = true;
            this.heightLabel.Location = new System.Drawing.Point(12, 118);
            this.heightLabel.Name = "heightLabel";
            this.heightLabel.Size = new System.Drawing.Size(103, 17);
            this.heightLabel.TabIndex = 2;
            this.heightLabel.Text = "Height (in tiles)";
            this.heightLabel.UseWaitCursor = true;
            // 
            // widthLabel
            // 
            this.widthLabel.AutoSize = true;
            this.widthLabel.Location = new System.Drawing.Point(12, 55);
            this.widthLabel.Name = "widthLabel";
            this.widthLabel.Size = new System.Drawing.Size(98, 17);
            this.widthLabel.TabIndex = 1;
            this.widthLabel.Text = "Width (in tiles)";
            this.widthLabel.UseWaitCursor = true;
            // 
            // createMapButton
            // 
            this.createMapButton.Location = new System.Drawing.Point(15, 181);
            this.createMapButton.Name = "createMapButton";
            this.createMapButton.Size = new System.Drawing.Size(268, 76);
            this.createMapButton.TabIndex = 0;
            this.createMapButton.Text = "Create Map";
            this.createMapButton.UseVisualStyleBackColor = true;
            this.createMapButton.UseWaitCursor = true;
            this.createMapButton.Click += new System.EventHandler(this.createMapButton_Click);
            // 
            // LevelEditor
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(322, 386);
            this.Controls.Add(this.newMapGroupBox);
            this.Controls.Add(this.loadMapButton);
            this.Name = "LevelEditor";
            this.Text = "Level Editor";
            this.UseWaitCursor = true;
            this.newMapGroupBox.ResumeLayout(false);
            this.newMapGroupBox.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button loadMapButton;
        private System.Windows.Forms.GroupBox newMapGroupBox;
        private System.Windows.Forms.TextBox heightText;
        private System.Windows.Forms.TextBox widthText;
        private System.Windows.Forms.Label heightLabel;
        private System.Windows.Forms.Label widthLabel;
        private System.Windows.Forms.Button createMapButton;
    }
}

