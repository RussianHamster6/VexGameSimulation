namespace vexGameSimulation
{
    partial class robotScreen
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
            this.components = new System.ComponentModel.Container();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.robotNameTxt = new System.Windows.Forms.TextBox();
            this.gameList = new System.Windows.Forms.ComboBox();
            this.RobotList = new System.Windows.Forms.ComboBox();
            this.loadBtn = new System.Windows.Forms.Button();
            this.saveAsNewBtn = new System.Windows.Forms.Button();
            this.saveChangesBtn = new System.Windows.Forms.Button();
            this.cancelBtn = new System.Windows.Forms.Button();
            this.label9 = new System.Windows.Forms.Label();
            this.robotSpeedTxt = new System.Windows.Forms.TextBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.ActionNameTxt = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CanAcBePerformed = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.probOfSuccess = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.timeTaken = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.robottableBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.vexgamesimDataSet = new vexGameSimulation.vexgamesimDataSet();
            this.robottableTableAdapter = new vexGameSimulation.vexgamesimDataSetTableAdapters.robottableTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.robottableBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.vexgamesimDataSet)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(55, 65);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(70, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Robot Name:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(55, 90);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(70, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Robot Game:";
            // 
            // robotNameTxt
            // 
            this.robotNameTxt.Location = new System.Drawing.Point(131, 62);
            this.robotNameTxt.Name = "robotNameTxt";
            this.robotNameTxt.Size = new System.Drawing.Size(143, 20);
            this.robotNameTxt.TabIndex = 7;
            // 
            // gameList
            // 
            this.gameList.FormattingEnabled = true;
            this.gameList.Location = new System.Drawing.Point(131, 90);
            this.gameList.Name = "gameList";
            this.gameList.Size = new System.Drawing.Size(143, 21);
            this.gameList.TabIndex = 8;
            // 
            // RobotList
            // 
            this.RobotList.FormattingEnabled = true;
            this.RobotList.Location = new System.Drawing.Point(440, 61);
            this.RobotList.Name = "RobotList";
            this.RobotList.Size = new System.Drawing.Size(121, 21);
            this.RobotList.TabIndex = 14;
            // 
            // loadBtn
            // 
            this.loadBtn.Location = new System.Drawing.Point(464, 95);
            this.loadBtn.Name = "loadBtn";
            this.loadBtn.Size = new System.Drawing.Size(75, 23);
            this.loadBtn.TabIndex = 15;
            this.loadBtn.Text = "Load";
            this.loadBtn.UseVisualStyleBackColor = true;
            this.loadBtn.Click += new System.EventHandler(this.loadBtn_Click);
            // 
            // saveAsNewBtn
            // 
            this.saveAsNewBtn.Location = new System.Drawing.Point(55, 291);
            this.saveAsNewBtn.Name = "saveAsNewBtn";
            this.saveAsNewBtn.Size = new System.Drawing.Size(97, 23);
            this.saveAsNewBtn.TabIndex = 16;
            this.saveAsNewBtn.Text = "Save as New";
            this.saveAsNewBtn.UseVisualStyleBackColor = true;
            this.saveAsNewBtn.Click += new System.EventHandler(this.saveAsNewBtn_Click);
            // 
            // saveChangesBtn
            // 
            this.saveChangesBtn.Location = new System.Drawing.Point(177, 291);
            this.saveChangesBtn.Name = "saveChangesBtn";
            this.saveChangesBtn.Size = new System.Drawing.Size(97, 23);
            this.saveChangesBtn.TabIndex = 17;
            this.saveChangesBtn.Text = "Save Changes";
            this.saveChangesBtn.UseVisualStyleBackColor = true;
            this.saveChangesBtn.Click += new System.EventHandler(this.saveChangesBtn_Click);
            // 
            // cancelBtn
            // 
            this.cancelBtn.Location = new System.Drawing.Point(466, 291);
            this.cancelBtn.Name = "cancelBtn";
            this.cancelBtn.Size = new System.Drawing.Size(75, 23);
            this.cancelBtn.TabIndex = 18;
            this.cancelBtn.Text = "Cancel";
            this.cancelBtn.UseVisualStyleBackColor = true;
            this.cancelBtn.Click += new System.EventHandler(this.button1_Click);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(293, 65);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(97, 13);
            this.label9.TabIndex = 25;
            this.label9.Text = "Robot Speed (m/s)";
            // 
            // robotSpeedTxt
            // 
            this.robotSpeedTxt.Location = new System.Drawing.Point(396, 62);
            this.robotSpeedTxt.Name = "robotSpeedTxt";
            this.robotSpeedTxt.Size = new System.Drawing.Size(38, 20);
            this.robotSpeedTxt.TabIndex = 26;
            this.robotSpeedTxt.TextChanged += new System.EventHandler(this.robotSpeedTxt_TextChanged);
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ActionNameTxt,
            this.CanAcBePerformed,
            this.probOfSuccess,
            this.timeTaken});
            this.dataGridView1.Location = new System.Drawing.Point(95, 124);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(444, 150);
            this.dataGridView1.TabIndex = 27;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // ActionNameTxt
            // 
            this.ActionNameTxt.HeaderText = "Action Name";
            this.ActionNameTxt.Name = "ActionNameTxt";
            this.ActionNameTxt.ReadOnly = true;
            // 
            // CanAcBePerformed
            // 
            this.CanAcBePerformed.HeaderText = "Can Action Be Performed";
            this.CanAcBePerformed.Name = "CanAcBePerformed";
            // 
            // probOfSuccess
            // 
            this.probOfSuccess.HeaderText = "Probability of Success";
            this.probOfSuccess.Name = "probOfSuccess";
            // 
            // timeTaken
            // 
            this.timeTaken.HeaderText = "Time Taken for action to complete (s)";
            this.timeTaken.Name = "timeTaken";
            // 
            // robottableBindingSource
            // 
            this.robottableBindingSource.DataMember = "robottable";
            this.robottableBindingSource.DataSource = this.vexgamesimDataSet;
            // 
            // vexgamesimDataSet
            // 
            this.vexgamesimDataSet.DataSetName = "vexgamesimDataSet";
            this.vexgamesimDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // robottableTableAdapter
            // 
            this.robottableTableAdapter.ClearBeforeFill = true;
            // 
            // robotScreen
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(584, 326);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.robotSpeedTxt);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.cancelBtn);
            this.Controls.Add(this.saveChangesBtn);
            this.Controls.Add(this.saveAsNewBtn);
            this.Controls.Add(this.loadBtn);
            this.Controls.Add(this.RobotList);
            this.Controls.Add(this.gameList);
            this.Controls.Add(this.robotNameTxt);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "robotScreen";
            this.Text = "robotScreen";
            this.Load += new System.EventHandler(this.robotScreen_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.robottableBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.vexgamesimDataSet)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox robotNameTxt;
        private System.Windows.Forms.ComboBox gameList;
        private System.Windows.Forms.ComboBox RobotList;
        private System.Windows.Forms.Button loadBtn;
        private System.Windows.Forms.Button saveAsNewBtn;
        private System.Windows.Forms.Button saveChangesBtn;
        private System.Windows.Forms.Button cancelBtn;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox robotSpeedTxt;
        private System.Windows.Forms.DataGridView dataGridView1;
        private vexgamesimDataSet vexgamesimDataSet;
        private System.Windows.Forms.BindingSource robottableBindingSource;
        private vexgamesimDataSetTableAdapters.robottableTableAdapter robottableTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn ActionNameTxt;
        private System.Windows.Forms.DataGridViewCheckBoxColumn CanAcBePerformed;
        private System.Windows.Forms.DataGridViewTextBoxColumn probOfSuccess;
        private System.Windows.Forms.DataGridViewTextBoxColumn timeTaken;
    }
}