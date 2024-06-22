namespace SalusHalo_Practic
{
    partial class AuthPage
    {
        /// <summary> 
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором компонентов

        /// <summary> 
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.borderedPanel1 = new BorderedPanel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.textPassword = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.btnAuth = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.textLogin = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.borderedPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // borderedPanel1
            // 
            this.borderedPanel1.Controls.Add(this.panel2);
            this.borderedPanel1.Controls.Add(this.textPassword);
            this.borderedPanel1.Controls.Add(this.label2);
            this.borderedPanel1.Controls.Add(this.btnAuth);
            this.borderedPanel1.Controls.Add(this.panel1);
            this.borderedPanel1.Controls.Add(this.textLogin);
            this.borderedPanel1.Controls.Add(this.label1);
            this.borderedPanel1.Location = new System.Drawing.Point(353, 48);
            this.borderedPanel1.Name = "borderedPanel1";
            this.borderedPanel1.Size = new System.Drawing.Size(330, 272);
            this.borderedPanel1.TabIndex = 2;
            // 
            // panel2
            // 
            this.panel2.BackgroundImage = global::SalusHalo_Practic.Properties.Resources.line2;
            this.panel2.Location = new System.Drawing.Point(43, 164);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(228, 10);
            this.panel2.TabIndex = 11;
            // 
            // textPassword
            // 
            this.textPassword.BackColor = System.Drawing.SystemColors.Window;
            this.textPassword.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textPassword.ForeColor = System.Drawing.Color.DimGray;
            this.textPassword.Location = new System.Drawing.Point(46, 137);
            this.textPassword.Margin = new System.Windows.Forms.Padding(0);
            this.textPassword.Name = "textPassword";
            this.textPassword.PasswordChar = '•';
            this.textPassword.Size = new System.Drawing.Size(219, 22);
            this.textPassword.TabIndex = 2;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Georgia", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(14)))), ((int)(((byte)(128)))), ((int)(((byte)(186)))));
            this.label2.Location = new System.Drawing.Point(42, 109);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(86, 23);
            this.label2.TabIndex = 9;
            this.label2.Text = "Пароль";
            // 
            // btnAuth
            // 
            this.btnAuth.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(14)))), ((int)(((byte)(128)))), ((int)(((byte)(186)))));
            this.btnAuth.FlatAppearance.BorderSize = 0;
            this.btnAuth.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAuth.Font = new System.Drawing.Font("Georgia", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btnAuth.ForeColor = System.Drawing.Color.White;
            this.btnAuth.Location = new System.Drawing.Point(85, 217);
            this.btnAuth.Margin = new System.Windows.Forms.Padding(0);
            this.btnAuth.Name = "btnAuth";
            this.btnAuth.Size = new System.Drawing.Size(160, 33);
            this.btnAuth.TabIndex = 3;
            this.btnAuth.Text = "Вход";
            this.btnAuth.UseVisualStyleBackColor = false;
            this.btnAuth.Click += new System.EventHandler(this.btnAuth_Click);
            // 
            // panel1
            // 
            this.panel1.BackgroundImage = global::SalusHalo_Practic.Properties.Resources.line2;
            this.panel1.Location = new System.Drawing.Point(43, 67);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(228, 10);
            this.panel1.TabIndex = 2;
            // 
            // textLogin
            // 
            this.textLogin.BackColor = System.Drawing.SystemColors.Window;
            this.textLogin.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textLogin.ForeColor = System.Drawing.Color.DimGray;
            this.textLogin.Location = new System.Drawing.Point(46, 40);
            this.textLogin.Margin = new System.Windows.Forms.Padding(0);
            this.textLogin.Name = "textLogin";
            this.textLogin.Size = new System.Drawing.Size(219, 22);
            this.textLogin.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Georgia", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(14)))), ((int)(((byte)(128)))), ((int)(((byte)(186)))));
            this.label1.Location = new System.Drawing.Point(42, 12);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(74, 23);
            this.label1.TabIndex = 0;
            this.label1.Text = "Логин";
            // 
            // AuthPage
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.BackColor = System.Drawing.Color.White;
            this.Controls.Add(this.borderedPanel1);
            this.Font = new System.Drawing.Font("Georgia", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Name = "AuthPage";
            this.Size = new System.Drawing.Size(1036, 368);
            this.borderedPanel1.ResumeLayout(false);
            this.borderedPanel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private BorderedPanel borderedPanel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.TextBox textPassword;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnAuth;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.TextBox textLogin;
        private System.Windows.Forms.Label label1;
    }
}
