namespace Level_Editor
{
    partial class EditorForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(EditorForm));
            this.mapGroupBox = new System.Windows.Forms.GroupBox();
            this.tileSelectGroupBox = new System.Windows.Forms.GroupBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.collectibleColor = new System.Windows.Forms.Button();
            this.currentTileGroupBox = new System.Windows.Forms.GroupBox();
            this.saveButton = new System.Windows.Forms.Button();
            this.loadButton = new System.Windows.Forms.Button();
            this.gridButton = new System.Windows.Forms.Button();
            this.label8 = new System.Windows.Forms.Label();
            this.currentTile = new System.Windows.Forms.PictureBox();
            this.finishColor = new System.Windows.Forms.Button();
            this.eraser = new System.Windows.Forms.Button();
            this.playerColor = new System.Windows.Forms.Button();
            this.groundColor = new System.Windows.Forms.Button();
            this.platformColor = new System.Windows.Forms.Button();
            this.enemyColor = new System.Windows.Forms.Button();
            this.tileSelectGroupBox.SuspendLayout();
            this.currentTileGroupBox.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.currentTile)).BeginInit();
            this.SuspendLayout();
            // 
            // mapGroupBox
            // 
            this.mapGroupBox.BackColor = System.Drawing.Color.Transparent;
            this.mapGroupBox.Location = new System.Drawing.Point(137, 105);
            this.mapGroupBox.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.mapGroupBox.Name = "mapGroupBox";
            this.mapGroupBox.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.mapGroupBox.Size = new System.Drawing.Size(1176, 825);
            this.mapGroupBox.TabIndex = 1;
            this.mapGroupBox.TabStop = false;
            this.mapGroupBox.Text = "Map";
            // 
            // tileSelectGroupBox
            // 
            this.tileSelectGroupBox.BackColor = System.Drawing.Color.Transparent;
            this.tileSelectGroupBox.Controls.Add(this.label8);
            this.tileSelectGroupBox.Controls.Add(this.finishColor);
            this.tileSelectGroupBox.Controls.Add(this.label7);
            this.tileSelectGroupBox.Controls.Add(this.eraser);
            this.tileSelectGroupBox.Controls.Add(this.label6);
            this.tileSelectGroupBox.Controls.Add(this.label5);
            this.tileSelectGroupBox.Controls.Add(this.label4);
            this.tileSelectGroupBox.Controls.Add(this.label3);
            this.tileSelectGroupBox.Controls.Add(this.label2);
            this.tileSelectGroupBox.Controls.Add(this.playerColor);
            this.tileSelectGroupBox.Controls.Add(this.label1);
            this.tileSelectGroupBox.Controls.Add(this.groundColor);
            this.tileSelectGroupBox.Controls.Add(this.platformColor);
            this.tileSelectGroupBox.Controls.Add(this.collectibleColor);
            this.tileSelectGroupBox.Controls.Add(this.enemyColor);
            this.tileSelectGroupBox.Location = new System.Drawing.Point(15, 105);
            this.tileSelectGroupBox.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tileSelectGroupBox.Name = "tileSelectGroupBox";
            this.tileSelectGroupBox.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tileSelectGroupBox.Size = new System.Drawing.Size(117, 704);
            this.tileSelectGroupBox.TabIndex = 71;
            this.tileSelectGroupBox.TabStop = false;
            this.tileSelectGroupBox.Text = "Tile Selector";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(34, 677);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(50, 17);
            this.label7.TabIndex = 18;
            this.label7.Text = "Eraser";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(32, 475);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(56, 17);
            this.label6.TabIndex = 16;
            this.label6.Text = "Ground";
            this.label6.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(22, 371);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(72, 17);
            this.label5.TabIndex = 15;
            this.label5.Text = "Collectible";
            this.label5.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(31, 263);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(60, 17);
            this.label4.TabIndex = 14;
            this.label4.Text = "Platform";
            this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(32, 263);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(60, 17);
            this.label3.TabIndex = 14;
            this.label3.Text = "Platform";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(35, 167);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(51, 17);
            this.label2.TabIndex = 13;
            this.label2.Text = "Enemy";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(36, 72);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(48, 17);
            this.label1.TabIndex = 12;
            this.label1.Text = "Player";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // collectibleColor
            // 
            this.collectibleColor.BackColor = System.Drawing.Color.Goldenrod;
            this.collectibleColor.Location = new System.Drawing.Point(34, 318);
            this.collectibleColor.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.collectibleColor.Name = "collectibleColor";
            this.collectibleColor.Size = new System.Drawing.Size(51, 50);
            this.collectibleColor.TabIndex = 8;
            this.collectibleColor.UseVisualStyleBackColor = false;
            // 
            // currentTileGroupBox
            // 
            this.currentTileGroupBox.BackColor = System.Drawing.Color.Transparent;
            this.currentTileGroupBox.Controls.Add(this.currentTile);
            this.currentTileGroupBox.Location = new System.Drawing.Point(14, 813);
            this.currentTileGroupBox.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.currentTileGroupBox.Name = "currentTileGroupBox";
            this.currentTileGroupBox.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.currentTileGroupBox.Size = new System.Drawing.Size(117, 117);
            this.currentTileGroupBox.TabIndex = 72;
            this.currentTileGroupBox.TabStop = false;
            this.currentTileGroupBox.Text = "Tile Selected";
            // 
            // saveButton
            // 
            this.saveButton.Location = new System.Drawing.Point(15, 9);
            this.saveButton.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.saveButton.Name = "saveButton";
            this.saveButton.Size = new System.Drawing.Size(89, 90);
            this.saveButton.TabIndex = 73;
            this.saveButton.Text = "Save File";
            this.saveButton.UseVisualStyleBackColor = true;
            this.saveButton.Click += new System.EventHandler(this.saveButton_Click);
            // 
            // loadButton
            // 
            this.loadButton.Location = new System.Drawing.Point(110, 9);
            this.loadButton.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.loadButton.Name = "loadButton";
            this.loadButton.Size = new System.Drawing.Size(92, 90);
            this.loadButton.TabIndex = 74;
            this.loadButton.Text = "Load File";
            this.loadButton.UseVisualStyleBackColor = true;
            this.loadButton.Click += new System.EventHandler(this.loadButton_Click);
            // 
            // gridButton
            // 
            this.gridButton.Location = new System.Drawing.Point(208, 9);
            this.gridButton.Name = "gridButton";
            this.gridButton.Size = new System.Drawing.Size(91, 90);
            this.gridButton.TabIndex = 76;
            this.gridButton.Text = "Turn Grid Off";
            this.gridButton.UseVisualStyleBackColor = true;
            this.gridButton.Click += new System.EventHandler(this.gridButton_Click);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(22, 576);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(81, 17);
            this.label8.TabIndex = 20;
            this.label8.Text = "Finish Point";
            this.label8.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // currentTile
            // 
            this.currentTile.BackColor = System.Drawing.Color.White;
            this.currentTile.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.currentTile.Location = new System.Drawing.Point(29, 32);
            this.currentTile.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.currentTile.Name = "currentTile";
            this.currentTile.Size = new System.Drawing.Size(60, 60);
            this.currentTile.TabIndex = 2;
            this.currentTile.TabStop = false;
            // 
            // finishColor
            // 
            this.finishColor.BackColor = System.Drawing.Color.Purple;
            this.finishColor.BackgroundImage = global::Level_Editor.Properties.Resources.Pillow_Chan;
            this.finishColor.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.finishColor.Location = new System.Drawing.Point(34, 524);
            this.finishColor.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.finishColor.Name = "finishColor";
            this.finishColor.Size = new System.Drawing.Size(51, 50);
            this.finishColor.TabIndex = 19;
            this.finishColor.UseVisualStyleBackColor = false;
            // 
            // eraser
            // 
            this.eraser.BackColor = System.Drawing.Color.White;
            this.eraser.BackgroundImage = global::Level_Editor.Properties.Resources.Background_Brick;
            this.eraser.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.eraser.Location = new System.Drawing.Point(34, 625);
            this.eraser.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.eraser.Name = "eraser";
            this.eraser.Size = new System.Drawing.Size(51, 50);
            this.eraser.TabIndex = 17;
            this.eraser.UseVisualStyleBackColor = false;
            // 
            // playerColor
            // 
            this.playerColor.BackColor = System.Drawing.Color.Green;
            this.playerColor.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("playerColor.BackgroundImage")));
            this.playerColor.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.playerColor.Location = new System.Drawing.Point(34, 19);
            this.playerColor.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.playerColor.Name = "playerColor";
            this.playerColor.Size = new System.Drawing.Size(51, 50);
            this.playerColor.TabIndex = 6;
            this.playerColor.UseVisualStyleBackColor = false;
            // 
            // groundColor
            // 
            this.groundColor.BackColor = System.Drawing.Color.SaddleBrown;
            this.groundColor.BackgroundImage = global::Level_Editor.Properties.Resources.Brick_Wall_Bottom;
            this.groundColor.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.groundColor.Location = new System.Drawing.Point(34, 422);
            this.groundColor.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.groundColor.Name = "groundColor";
            this.groundColor.Size = new System.Drawing.Size(51, 50);
            this.groundColor.TabIndex = 9;
            this.groundColor.UseVisualStyleBackColor = false;
            // 
            // platformColor
            // 
            this.platformColor.BackColor = System.Drawing.Color.DeepSkyBlue;
            this.platformColor.BackgroundImage = global::Level_Editor.Properties.Resources.Brick_Wall_Top;
            this.platformColor.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.platformColor.Location = new System.Drawing.Point(33, 210);
            this.platformColor.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.platformColor.Name = "platformColor";
            this.platformColor.Size = new System.Drawing.Size(51, 50);
            this.platformColor.TabIndex = 10;
            this.platformColor.UseVisualStyleBackColor = false;
            // 
            // enemyColor
            // 
            this.enemyColor.BackColor = System.Drawing.Color.Red;
            this.enemyColor.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("enemyColor.BackgroundImage")));
            this.enemyColor.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.enemyColor.Location = new System.Drawing.Point(33, 114);
            this.enemyColor.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.enemyColor.Name = "enemyColor";
            this.enemyColor.Size = new System.Drawing.Size(51, 50);
            this.enemyColor.TabIndex = 7;
            this.enemyColor.UseVisualStyleBackColor = false;
            // 
            // EditorForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1325, 1055);
            this.Controls.Add(this.gridButton);
            this.Controls.Add(this.loadButton);
            this.Controls.Add(this.saveButton);
            this.Controls.Add(this.currentTileGroupBox);
            this.Controls.Add(this.tileSelectGroupBox);
            this.Controls.Add(this.mapGroupBox);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "EditorForm";
            this.Text = " ";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.EditorForm_FormClosing);
            this.Load += new System.EventHandler(this.EditorForm_Load);
            this.tileSelectGroupBox.ResumeLayout(false);
            this.tileSelectGroupBox.PerformLayout();
            this.currentTileGroupBox.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.currentTile)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.GroupBox mapGroupBox;
        private System.Windows.Forms.GroupBox tileSelectGroupBox;
        private System.Windows.Forms.GroupBox currentTileGroupBox;
        private System.Windows.Forms.PictureBox currentTile;
        private System.Windows.Forms.Button saveButton;
        private System.Windows.Forms.Button loadButton;
        private System.Windows.Forms.Button playerColor;
        private System.Windows.Forms.Button groundColor;
        private System.Windows.Forms.Button platformColor;
        private System.Windows.Forms.Button collectibleColor;
        private System.Windows.Forms.Button enemyColor;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Button eraser;
        private System.Windows.Forms.Button gridButton;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Button finishColor;
    }
}