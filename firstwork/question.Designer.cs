namespace firstwork
{
    partial class question
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.lblA = new System.Windows.Forms.Label();
            this.lblop = new System.Windows.Forms.Label();
            this.lblB = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.txtresult = new System.Windows.Forms.TextBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.lstresult = new System.Windows.Forms.ListBox();
            this.btnNew = new System.Windows.Forms.Button();
            this.btnJudge = new System.Windows.Forms.Button();
            this.btngrade = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.lblgrade = new System.Windows.Forms.Label();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.txtgradebb = new System.Windows.Forms.TextBox();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.lblgrade);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.btnJudge);
            this.groupBox1.Controls.Add(this.btnNew);
            this.groupBox1.Controls.Add(this.txtresult);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.lblB);
            this.groupBox1.Controls.Add(this.lblop);
            this.groupBox1.Controls.Add(this.lblA);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(285, 158);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "我来出题";
            // 
            // lblA
            // 
            this.lblA.AutoSize = true;
            this.lblA.Location = new System.Drawing.Point(20, 32);
            this.lblA.Name = "lblA";
            this.lblA.Size = new System.Drawing.Size(41, 12);
            this.lblA.TabIndex = 0;
            this.lblA.Text = "label1";
            //this.lblA.Click += new System.EventHandler(this.srA_Click);
            // 
            // lblop
            // 
            this.lblop.AutoSize = true;
            this.lblop.Location = new System.Drawing.Point(67, 32);
            this.lblop.Name = "lblop";
            this.lblop.Size = new System.Drawing.Size(41, 12);
            this.lblop.TabIndex = 1;
            this.lblop.Text = "label2";
            // 
            // lblB
            // 
            this.lblB.AutoSize = true;
            this.lblB.Location = new System.Drawing.Point(128, 32);
            this.lblB.Name = "lblB";
            this.lblB.Size = new System.Drawing.Size(41, 12);
            this.lblB.TabIndex = 2;
            this.lblB.Text = "label3";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(175, 32);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(11, 12);
            this.label4.TabIndex = 3;
            this.label4.Text = "=";
            // 
            // txtresult
            // 
            this.txtresult.Location = new System.Drawing.Point(202, 29);
            this.txtresult.Name = "txtresult";
            this.txtresult.Size = new System.Drawing.Size(56, 21);
            this.txtresult.TabIndex = 4;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.lstresult);
            this.groupBox2.Location = new System.Drawing.Point(12, 168);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(476, 226);
            this.groupBox2.TabIndex = 5;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "判定结果";
            // 
            // lstresult
            // 
            this.lstresult.FormattingEnabled = true;
            this.lstresult.ItemHeight = 12;
            this.lstresult.Location = new System.Drawing.Point(33, 37);
            this.lstresult.Name = "lstresult";
            this.lstresult.Size = new System.Drawing.Size(420, 172);
            this.lstresult.TabIndex = 0;
            // 
            // btnNew
            // 
            this.btnNew.Location = new System.Drawing.Point(22, 70);
            this.btnNew.Name = "btnNew";
            this.btnNew.Size = new System.Drawing.Size(75, 23);
            this.btnNew.TabIndex = 5;
            this.btnNew.Text = "出题";
            this.btnNew.UseVisualStyleBackColor = true;
            this.btnNew.Click += new System.EventHandler(this.btnNew_Click);
            // 
            // btnJudge
            // 
            this.btnJudge.Location = new System.Drawing.Point(109, 70);
            this.btnJudge.Name = "btnJudge";
            this.btnJudge.Size = new System.Drawing.Size(75, 23);
            this.btnJudge.TabIndex = 6;
            this.btnJudge.Text = "判定";
            this.btnJudge.UseVisualStyleBackColor = true;
            this.btnJudge.Click += new System.EventHandler(this.btnJudge_Click);
            // 
            // btngrade
            // 
            this.btngrade.Location = new System.Drawing.Point(51, 20);
            this.btngrade.Name = "btngrade";
            this.btngrade.Size = new System.Drawing.Size(75, 23);
            this.btngrade.TabIndex = 7;
            this.btngrade.Text = "成绩报表";
            this.btngrade.UseVisualStyleBackColor = true;
            this.btngrade.Click += new System.EventHandler(this.btngrade_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(20, 123);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(47, 12);
            this.label1.TabIndex = 8;
            this.label1.Text = "得分为:";
            // 
            // lblgrade
            // 
            this.lblgrade.AutoSize = true;
            this.lblgrade.Location = new System.Drawing.Point(79, 123);
            this.lblgrade.Name = "lblgrade";
            this.lblgrade.Size = new System.Drawing.Size(41, 12);
            this.lblgrade.TabIndex = 9;
            this.lblgrade.Text = "label1";
            //this.lblgrade.Click += new System.EventHandler(this.label2_Click);
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.txtgradebb);
            this.groupBox3.Controls.Add(this.btngrade);
            this.groupBox3.Location = new System.Drawing.Point(303, 12);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(185, 158);
            this.groupBox3.TabIndex = 6;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "成绩报表";
            // 
            // txtgradebb
            // 
            this.txtgradebb.Location = new System.Drawing.Point(20, 73);
            this.txtgradebb.Multiline = true;
            this.txtgradebb.Name = "txtgradebb";
            this.txtgradebb.Size = new System.Drawing.Size(142, 62);
            this.txtgradebb.TabIndex = 11;
            // 
            // question
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(500, 419);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Name = "question";
            this.Text = "question";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btnJudge;
        private System.Windows.Forms.Button btnNew;
        private System.Windows.Forms.TextBox txtresult;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label lblB;
        private System.Windows.Forms.Label lblop;
        private System.Windows.Forms.Label lblA;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.ListBox lstresult;
        private System.Windows.Forms.Button btngrade;
        private System.Windows.Forms.Label lblgrade;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.TextBox txtgradebb;
    }
}