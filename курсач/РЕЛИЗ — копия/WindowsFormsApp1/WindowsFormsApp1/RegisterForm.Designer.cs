namespace WindowsFormsApp1
{
    partial class RegisterForm
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
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txtLogin1 = new System.Windows.Forms.TextBox();
            this.txtPassword2 = new System.Windows.Forms.TextBox();
            this.txtPassword3 = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txtAdminCode = new System.Windows.Forms.TextBox();
            this.btnReg = new System.Windows.Forms.Button();
            this.btnCancel = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(45, 22);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(38, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Логин";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(45, 72);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(45, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Пароль";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(45, 129);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(100, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Повторите пароль";
            // 
            // txtLogin1
            // 
            this.txtLogin1.Location = new System.Drawing.Point(188, 15);
            this.txtLogin1.Name = "txtLogin1";
            this.txtLogin1.Size = new System.Drawing.Size(100, 20);
            this.txtLogin1.TabIndex = 3;
            // 
            // txtPassword2
            // 
            this.txtPassword2.Location = new System.Drawing.Point(188, 69);
            this.txtPassword2.Name = "txtPassword2";
            this.txtPassword2.Size = new System.Drawing.Size(100, 20);
            this.txtPassword2.TabIndex = 4;
            // 
            // txtPassword3
            // 
            this.txtPassword3.Location = new System.Drawing.Point(188, 126);
            this.txtPassword3.Name = "txtPassword3";
            this.txtPassword3.Size = new System.Drawing.Size(100, 20);
            this.txtPassword3.TabIndex = 5;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(353, 22);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(113, 13);
            this.label4.TabIndex = 6;
            this.label4.Text = "Код администратора";
            // 
            // txtAdminCode
            // 
            this.txtAdminCode.Location = new System.Drawing.Point(484, 19);
            this.txtAdminCode.Name = "txtAdminCode";
            this.txtAdminCode.Size = new System.Drawing.Size(100, 20);
            this.txtAdminCode.TabIndex = 7;
            // 
            // btnReg
            // 
            this.btnReg.Location = new System.Drawing.Point(150, 180);
            this.btnReg.Name = "btnReg";
            this.btnReg.Size = new System.Drawing.Size(86, 23);
            this.btnReg.TabIndex = 8;
            this.btnReg.Text = "Регистрация";
            this.btnReg.UseVisualStyleBackColor = true;
            this.btnReg.Click += new System.EventHandler(this.btnReg_Click);
            // 
            // btnCancel
            // 
            this.btnCancel.Location = new System.Drawing.Point(391, 180);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(75, 23);
            this.btnCancel.TabIndex = 9;
            this.btnCancel.Text = "Отмена";
            this.btnCancel.UseVisualStyleBackColor = true;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // RegisterForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(635, 275);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.btnReg);
            this.Controls.Add(this.txtAdminCode);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txtPassword3);
            this.Controls.Add(this.txtPassword2);
            this.Controls.Add(this.txtLogin1);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "RegisterForm";
            this.Text = "Регистрация";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtLogin1;
        private System.Windows.Forms.TextBox txtPassword2;
        private System.Windows.Forms.TextBox txtPassword3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtAdminCode;
        private System.Windows.Forms.Button btnReg;
        private System.Windows.Forms.Button btnCancel;
    }
}