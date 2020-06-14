namespace _1845317_My_second_app
{
    partial class FrmOperators
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
            this.txtq = new System.Windows.Forms.TextBox();
            this.txtr = new System.Windows.Forms.TextBox();
            this.txtp = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.btnSolve = new System.Windows.Forms.Button();
            this.LblRes = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.txtq);
            this.groupBox1.Controls.Add(this.txtr);
            this.groupBox1.Controls.Add(this.txtp);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(25, 32);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(178, 135);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "groupBox1";
            // 
            // txtq
            // 
            this.txtq.Location = new System.Drawing.Point(72, 62);
            this.txtq.Name = "txtq";
            this.txtq.Size = new System.Drawing.Size(100, 22);
            this.txtq.TabIndex = 7;
            // 
            // txtr
            // 
            this.txtr.Location = new System.Drawing.Point(72, 96);
            this.txtr.Name = "txtr";
            this.txtr.Size = new System.Drawing.Size(100, 22);
            this.txtr.TabIndex = 8;
            // 
            // txtp
            // 
            this.txtp.Location = new System.Drawing.Point(72, 31);
            this.txtp.Name = "txtp";
            this.txtp.Size = new System.Drawing.Size(100, 22);
            this.txtp.TabIndex = 6;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(6, 67);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(16, 17);
            this.label2.TabIndex = 1;
            this.label2.Text = "q";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(6, 96);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(13, 17);
            this.label3.TabIndex = 2;
            this.label3.Text = "r";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(7, 31);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(16, 17);
            this.label1.TabIndex = 0;
            this.label1.Text = "p";
            // 
            // btnSolve
            // 
            this.btnSolve.Location = new System.Drawing.Point(151, 189);
            this.btnSolve.Name = "btnSolve";
            this.btnSolve.Size = new System.Drawing.Size(144, 35);
            this.btnSolve.TabIndex = 1;
            this.btnSolve.Text = "Solve";
            this.btnSolve.UseVisualStyleBackColor = true;
            this.btnSolve.Click += new System.EventHandler(this.btnSolve_Click);
            // 
            // LblRes
            // 
            this.LblRes.AutoSize = true;
            this.LblRes.Location = new System.Drawing.Point(424, 32);
            this.LblRes.Name = "LblRes";
            this.LblRes.Size = new System.Drawing.Size(67, 17);
            this.LblRes.TabIndex = 2;
            this.LblRes.Text = "Result in ";
            // 
            // FrmOperators
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.LblRes);
            this.Controls.Add(this.btnSolve);
            this.Controls.Add(this.groupBox1);
            this.Name = "FrmOperators";
            this.Text = "Operators";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox txtq;
        private System.Windows.Forms.TextBox txtr;
        private System.Windows.Forms.TextBox txtp;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnSolve;
        private System.Windows.Forms.Label LblRes;
    }
}