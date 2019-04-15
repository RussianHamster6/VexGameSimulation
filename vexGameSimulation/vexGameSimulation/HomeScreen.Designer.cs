namespace vexGameSimulation
{
    partial class HomeScreen
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
            this.loadEditRobotBtn = new System.Windows.Forms.Button();
            this.selectEditGameBtn = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.currentGameTxt = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.robotTxt = new System.Windows.Forms.Label();
            this.runBtn = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.timeTxt = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // loadEditRobotBtn
            // 
            this.loadEditRobotBtn.Location = new System.Drawing.Point(12, 94);
            this.loadEditRobotBtn.Name = "loadEditRobotBtn";
            this.loadEditRobotBtn.Size = new System.Drawing.Size(412, 23);
            this.loadEditRobotBtn.TabIndex = 0;
            this.loadEditRobotBtn.Text = "Load/ Edit Robot";
            this.loadEditRobotBtn.UseVisualStyleBackColor = true;
            this.loadEditRobotBtn.Click += new System.EventHandler(this.button1_Click);
            // 
            // selectEditGameBtn
            // 
            this.selectEditGameBtn.Location = new System.Drawing.Point(12, 123);
            this.selectEditGameBtn.Name = "selectEditGameBtn";
            this.selectEditGameBtn.Size = new System.Drawing.Size(412, 23);
            this.selectEditGameBtn.TabIndex = 1;
            this.selectEditGameBtn.Text = "Select/ Edit Game";
            this.selectEditGameBtn.UseVisualStyleBackColor = true;
            this.selectEditGameBtn.Click += new System.EventHandler(this.button2_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(32, 175);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(75, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "Current Game:";
            // 
            // currentGameTxt
            // 
            this.currentGameTxt.AutoSize = true;
            this.currentGameTxt.Location = new System.Drawing.Point(114, 175);
            this.currentGameTxt.Name = "currentGameTxt";
            this.currentGameTxt.Size = new System.Drawing.Size(0, 13);
            this.currentGameTxt.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(252, 175);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(76, 13);
            this.label2.TabIndex = 4;
            this.label2.Text = "Current Robot:";
            // 
            // robotTxt
            // 
            this.robotTxt.AutoSize = true;
            this.robotTxt.Location = new System.Drawing.Point(326, 175);
            this.robotTxt.Name = "robotTxt";
            this.robotTxt.Size = new System.Drawing.Size(0, 13);
            this.robotTxt.TabIndex = 5;
            this.robotTxt.Click += new System.EventHandler(this.label3_Click);
            // 
            // runBtn
            // 
            this.runBtn.Location = new System.Drawing.Point(255, 206);
            this.runBtn.Name = "runBtn";
            this.runBtn.Size = new System.Drawing.Size(157, 131);
            this.runBtn.TabIndex = 6;
            this.runBtn.Text = "Run Game";
            this.runBtn.UseVisualStyleBackColor = true;
            this.runBtn.Click += new System.EventHandler(this.runBtn_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 262);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(183, 13);
            this.label3.TabIndex = 7;
            this.label3.Text = "Amount of Simulation Time (Seconds)";
            // 
            // timeTxt
            // 
            this.timeTxt.Location = new System.Drawing.Point(198, 259);
            this.timeTxt.Name = "timeTxt";
            this.timeTxt.Size = new System.Drawing.Size(51, 20);
            this.timeTxt.TabIndex = 8;
            this.timeTxt.Text = "105";
            // 
            // HomeScreen
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(442, 349);
            this.Controls.Add(this.timeTxt);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.runBtn);
            this.Controls.Add(this.robotTxt);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.currentGameTxt);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.selectEditGameBtn);
            this.Controls.Add(this.loadEditRobotBtn);
            this.Name = "HomeScreen";
            this.Text = "VexRobotics Simulator";
            this.Load += new System.EventHandler(this.HomeScreen_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button loadEditRobotBtn;
        private System.Windows.Forms.Button selectEditGameBtn;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label currentGameTxt;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label robotTxt;
        private System.Windows.Forms.Button runBtn;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox timeTxt;
    }
}

