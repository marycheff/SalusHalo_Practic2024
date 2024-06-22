namespace SalusHalo_Practic
{
    partial class SearchSubscription
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
            this.btnSearchSub = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.textSubNum = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.borderedPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // borderedPanel1
            // 
            this.borderedPanel1.Controls.Add(this.btnSearchSub);
            this.borderedPanel1.Controls.Add(this.panel1);
            this.borderedPanel1.Controls.Add(this.textSubNum);
            this.borderedPanel1.Controls.Add(this.label1);
            this.borderedPanel1.Location = new System.Drawing.Point(353, 77);
            this.borderedPanel1.Name = "borderedPanel1";
            this.borderedPanel1.Size = new System.Drawing.Size(330, 214);
            this.borderedPanel1.TabIndex = 1;
            // 
            // btnSearchSub
            // 
            this.btnSearchSub.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(14)))), ((int)(((byte)(128)))), ((int)(((byte)(186)))));
            this.btnSearchSub.FlatAppearance.BorderSize = 0;
            this.btnSearchSub.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSearchSub.Font = new System.Drawing.Font("Georgia", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btnSearchSub.ForeColor = System.Drawing.Color.White;
            this.btnSearchSub.Location = new System.Drawing.Point(90, 161);
            this.btnSearchSub.Margin = new System.Windows.Forms.Padding(0);
            this.btnSearchSub.Name = "btnSearchSub";
            this.btnSearchSub.Size = new System.Drawing.Size(160, 33);
            this.btnSearchSub.TabIndex = 8;
            this.btnSearchSub.Text = "Найти";
            this.btnSearchSub.UseVisualStyleBackColor = false;
            this.btnSearchSub.Click += new System.EventHandler(this.btnSearchSub_Click);
            // 
            // panel1
            // 
            this.panel1.BackgroundImage = global::SalusHalo_Practic.Properties.Resources.line2;
            this.panel1.Location = new System.Drawing.Point(51, 110);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(228, 10);
            this.panel1.TabIndex = 2;
            // 
            // textSubNum
            // 
            this.textSubNum.BackColor = System.Drawing.SystemColors.Window;
            this.textSubNum.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textSubNum.ForeColor = System.Drawing.Color.DimGray;
            this.textSubNum.Location = new System.Drawing.Point(54, 83);
            this.textSubNum.Margin = new System.Windows.Forms.Padding(0);
            this.textSubNum.Name = "textSubNum";
            this.textSubNum.Size = new System.Drawing.Size(219, 22);
            this.textSubNum.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Georgia", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(14)))), ((int)(((byte)(128)))), ((int)(((byte)(186)))));
            this.label1.Location = new System.Drawing.Point(71, 16);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(202, 23);
            this.label1.TabIndex = 0;
            this.label1.Text = "Номер абонемента";
            // 
            // SearchSubscription
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.BackColor = System.Drawing.Color.White;
            this.Controls.Add(this.borderedPanel1);
            this.Font = new System.Drawing.Font("Georgia", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Margin = new System.Windows.Forms.Padding(0);
            this.Name = "SearchSubscription";
            this.Size = new System.Drawing.Size(1036, 368);
            this.borderedPanel1.ResumeLayout(false);
            this.borderedPanel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private BorderedPanel borderedPanel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.TextBox textSubNum;
        private System.Windows.Forms.Button btnSearchSub;
    }
}
