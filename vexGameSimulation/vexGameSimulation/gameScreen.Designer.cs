namespace vexGameSimulation
{
    partial class gameScreen
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
            this.label1 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.FileReferenceTxt = new System.Windows.Forms.TextBox();
            this.saveAsNewBtn = new System.Windows.Forms.Button();
            this.saveChangesBtn = new System.Windows.Forms.Button();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.loadBtn = new System.Windows.Forms.Button();
            this.cancelBtn = new System.Windows.Forms.Button();
            this.gameNameTxt = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(35, 58);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(69, 13);
            this.label1.TabIndex = 6;
            this.label1.Text = "Game Name:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(35, 122);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(88, 13);
            this.label7.TabIndex = 12;
            this.label7.Text = "Game File Name:";
            this.label7.Click += new System.EventHandler(this.label7_Click);
            // 
            // FileReferenceTxt
            // 
            this.FileReferenceTxt.Location = new System.Drawing.Point(150, 119);
            this.FileReferenceTxt.Name = "FileReferenceTxt";
            this.FileReferenceTxt.Size = new System.Drawing.Size(239, 20);
            this.FileReferenceTxt.TabIndex = 13;
            // 
            // saveAsNewBtn
            // 
            this.saveAsNewBtn.Location = new System.Drawing.Point(38, 217);
            this.saveAsNewBtn.Name = "saveAsNewBtn";
            this.saveAsNewBtn.Size = new System.Drawing.Size(86, 23);
            this.saveAsNewBtn.TabIndex = 14;
            this.saveAsNewBtn.Text = "Save as New";
            this.saveAsNewBtn.UseVisualStyleBackColor = true;
            this.saveAsNewBtn.Click += new System.EventHandler(this.saveAsNewBtn_Click);
            // 
            // saveChangesBtn
            // 
            this.saveChangesBtn.Location = new System.Drawing.Point(178, 217);
            this.saveChangesBtn.Name = "saveChangesBtn";
            this.saveChangesBtn.Size = new System.Drawing.Size(86, 23);
            this.saveChangesBtn.TabIndex = 15;
            this.saveChangesBtn.Text = "Save Changes";
            this.saveChangesBtn.UseVisualStyleBackColor = true;
            this.saveChangesBtn.Click += new System.EventHandler(this.saveChangesBtn_Click);
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(290, 54);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(121, 21);
            this.comboBox1.TabIndex = 16;
            // 
            // loadBtn
            // 
            this.loadBtn.Location = new System.Drawing.Point(314, 81);
            this.loadBtn.Name = "loadBtn";
            this.loadBtn.Size = new System.Drawing.Size(75, 23);
            this.loadBtn.TabIndex = 17;
            this.loadBtn.Text = "Load";
            this.loadBtn.UseVisualStyleBackColor = true;
            this.loadBtn.Click += new System.EventHandler(this.loadBtn_Click);
            // 
            // cancelBtn
            // 
            this.cancelBtn.Location = new System.Drawing.Point(314, 217);
            this.cancelBtn.Name = "cancelBtn";
            this.cancelBtn.Size = new System.Drawing.Size(75, 23);
            this.cancelBtn.TabIndex = 18;
            this.cancelBtn.Text = "Cancel";
            this.cancelBtn.UseVisualStyleBackColor = true;
            this.cancelBtn.Click += new System.EventHandler(this.cancelBtn_Click);
            // 
            // gameNameTxt
            // 
            this.gameNameTxt.Location = new System.Drawing.Point(110, 55);
            this.gameNameTxt.Name = "gameNameTxt";
            this.gameNameTxt.Size = new System.Drawing.Size(125, 20);
            this.gameNameTxt.TabIndex = 19;
            // 
            // gameScreen
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(429, 260);
            this.Controls.Add(this.gameNameTxt);
            this.Controls.Add(this.cancelBtn);
            this.Controls.Add(this.loadBtn);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.saveChangesBtn);
            this.Controls.Add(this.saveAsNewBtn);
            this.Controls.Add(this.FileReferenceTxt);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label1);
            this.Name = "gameScreen";
            this.Text = "gameScreen";
            this.Load += new System.EventHandler(this.gameScreen_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox FileReferenceTxt;
        private System.Windows.Forms.Button saveAsNewBtn;
        private System.Windows.Forms.Button saveChangesBtn;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.Button loadBtn;
        private System.Windows.Forms.Button cancelBtn;
        private System.Windows.Forms.TextBox gameNameTxt;
    }
}