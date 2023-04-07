namespace PhanHe1
{
    partial class fCreateUser
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnCreate = new System.Windows.Forms.Button();
            this.panel3 = new System.Windows.Forms.Panel();
            this.txbIDEmp = new System.Windows.Forms.TextBox();
            this.txtIDEmp = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.txbPassWord = new System.Windows.Forms.TextBox();
            this.txtPass = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.panel3.SuspendLayout();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.btnCreate);
            this.panel1.Controls.Add(this.panel3);
            this.panel1.Controls.Add(this.panel2);
            this.panel1.Location = new System.Drawing.Point(3, 2);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(562, 240);
            this.panel1.TabIndex = 0;
            // 
            // btnCreate
            // 
            this.btnCreate.Font = new System.Drawing.Font("Arial", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCreate.Location = new System.Drawing.Point(188, 161);
            this.btnCreate.Name = "btnCreate";
            this.btnCreate.Size = new System.Drawing.Size(170, 59);
            this.btnCreate.TabIndex = 2;
            this.btnCreate.Text = "Tạo người dùng";
            this.btnCreate.UseVisualStyleBackColor = true;
            this.btnCreate.Click += new System.EventHandler(this.btnCreate_Click);
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.txbIDEmp);
            this.panel3.Controls.Add(this.txtIDEmp);
            this.panel3.Location = new System.Drawing.Point(6, 10);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(553, 66);
            this.panel3.TabIndex = 0;
            // 
            // txbIDEmp
            // 
            this.txbIDEmp.Location = new System.Drawing.Point(206, 23);
            this.txbIDEmp.Name = "txbIDEmp";
            this.txbIDEmp.Size = new System.Drawing.Size(332, 22);
            this.txbIDEmp.TabIndex = 0;
            // 
            // txtIDEmp
            // 
            this.txtIDEmp.AutoSize = true;
            this.txtIDEmp.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtIDEmp.Location = new System.Drawing.Point(21, 23);
            this.txtIDEmp.Name = "txtIDEmp";
            this.txtIDEmp.Size = new System.Drawing.Size(162, 24);
            this.txtIDEmp.TabIndex = 0;
            this.txtIDEmp.Text = "Mã người dùng:";
            this.txtIDEmp.Click += new System.EventHandler(this.label1_Click);
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.txbPassWord);
            this.panel2.Controls.Add(this.txtPass);
            this.panel2.Location = new System.Drawing.Point(9, 82);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(553, 66);
            this.panel2.TabIndex = 0;
            // 
            // txbPassWord
            // 
            this.txbPassWord.Location = new System.Drawing.Point(203, 26);
            this.txbPassWord.Name = "txbPassWord";
            this.txbPassWord.Size = new System.Drawing.Size(335, 22);
            this.txbPassWord.TabIndex = 0;
            this.txbPassWord.UseSystemPasswordChar = true;
            // 
            // txtPass
            // 
            this.txtPass.AutoSize = true;
            this.txtPass.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPass.Location = new System.Drawing.Point(21, 26);
            this.txtPass.Name = "txtPass";
            this.txtPass.Size = new System.Drawing.Size(104, 24);
            this.txtPass.TabIndex = 0;
            this.txtPass.Text = "Mật khẩu:";
            this.txtPass.Click += new System.EventHandler(this.label1_Click);
            // 
            // fCreateUser
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(571, 231);
            this.Controls.Add(this.panel1);
            this.Name = "fCreateUser";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "fCreateUser";
            this.Load += new System.EventHandler(this.fCreateUser_Load);
            this.panel1.ResumeLayout(false);
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label txtPass;
        private System.Windows.Forms.Button btnCreate;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.TextBox txbPassWord;
        private System.Windows.Forms.Label txtIDEmp;
        private System.Windows.Forms.TextBox txbIDEmp;
    }
}