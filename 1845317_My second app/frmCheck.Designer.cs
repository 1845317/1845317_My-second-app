namespace _1845317_My_second_app
{
    partial class frmCheck
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
            this.btnBack = new System.Windows.Forms.Button();
            this.btnShow = new System.Windows.Forms.Button();
            this.chkCoffe = new System.Windows.Forms.CheckBox();
            this.chkDonut = new System.Windows.Forms.CheckBox();
            this.chkBrowne = new System.Windows.Forms.CheckBox();
            this.SuspendLayout();
            // 
            // btnBack
            // 
            this.btnBack.Location = new System.Drawing.Point(648, 381);
            this.btnBack.Name = "btnBack";
            this.btnBack.Size = new System.Drawing.Size(94, 57);
            this.btnBack.TabIndex = 0;
            this.btnBack.Text = "Back";
            this.btnBack.UseVisualStyleBackColor = true;
            this.btnBack.Click += new System.EventHandler(this.btnBack_Click);
            // 
            // btnShow
            // 
            this.btnShow.Location = new System.Drawing.Point(50, 37);
            this.btnShow.Name = "btnShow";
            this.btnShow.Size = new System.Drawing.Size(95, 35);
            this.btnShow.TabIndex = 1;
            this.btnShow.Text = "Show";
            this.btnShow.UseVisualStyleBackColor = true;
            // 
            // chkCoffe
            // 
            this.chkCoffe.AutoSize = true;
            this.chkCoffe.Location = new System.Drawing.Point(46, 131);
            this.chkCoffe.Name = "chkCoffe";
            this.chkCoffe.Size = new System.Drawing.Size(63, 21);
            this.chkCoffe.TabIndex = 2;
            this.chkCoffe.Text = "Coffe";
            this.chkCoffe.UseVisualStyleBackColor = true;
            // 
            // chkDonut
            // 
            this.chkDonut.AutoSize = true;
            this.chkDonut.Location = new System.Drawing.Point(50, 176);
            this.chkDonut.Name = "chkDonut";
            this.chkDonut.Size = new System.Drawing.Size(68, 21);
            this.chkDonut.TabIndex = 3;
            this.chkDonut.Text = "Donut";
            this.chkDonut.UseVisualStyleBackColor = true;
            // 
            // chkBrowne
            // 
            this.chkBrowne.AutoSize = true;
            this.chkBrowne.Location = new System.Drawing.Point(50, 215);
            this.chkBrowne.Name = "chkBrowne";
            this.chkBrowne.Size = new System.Drawing.Size(77, 21);
            this.chkBrowne.TabIndex = 4;
            this.chkBrowne.Text = "Browne";
            this.chkBrowne.UseVisualStyleBackColor = true;
            // 
            // frmCheck
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.chkBrowne);
            this.Controls.Add(this.chkDonut);
            this.Controls.Add(this.chkCoffe);
            this.Controls.Add(this.btnShow);
            this.Controls.Add(this.btnBack);
            this.Name = "frmCheck";
            this.Text = "Check Box";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnBack;
        private System.Windows.Forms.Button btnShow;
        private System.Windows.Forms.CheckBox chkCoffe;
        private System.Windows.Forms.CheckBox chkDonut;
        private System.Windows.Forms.CheckBox chkBrowne;
    }
}