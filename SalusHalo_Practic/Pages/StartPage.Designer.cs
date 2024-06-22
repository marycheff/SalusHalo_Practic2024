namespace SalusHalo_Practic
{
    partial class StartPage
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(StartPage));
            this.panel3 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.preferentialPanel = new System.Windows.Forms.Panel();
            this.adultsChildrenPanel = new System.Windows.Forms.Panel();
            this.adultsPanel = new System.Windows.Forms.Panel();
            this.childrenPanel = new System.Windows.Forms.Panel();
            this.panel3.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(16)))), ((int)(((byte)(123)))), ((int)(((byte)(196)))));
            this.panel3.Controls.Add(this.label1);
            this.panel3.Location = new System.Drawing.Point(-8, 294);
            this.panel3.Margin = new System.Windows.Forms.Padding(0);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(1044, 74);
            this.panel3.TabIndex = 3;
            // 
            // label1
            // 
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(36, 0);
            this.label1.Margin = new System.Windows.Forms.Padding(0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(983, 73);
            this.label1.TabIndex = 0;
            this.label1.Text = resources.GetString("label1.Text");
            // 
            // preferentialPanel
            // 
            this.preferentialPanel.BackgroundImage = global::SalusHalo_Practic.Properties.Resources.Льготный_1;
            this.preferentialPanel.Cursor = System.Windows.Forms.Cursors.Hand;
            this.preferentialPanel.Location = new System.Drawing.Point(810, 47);
            this.preferentialPanel.Name = "preferentialPanel";
            this.preferentialPanel.Size = new System.Drawing.Size(200, 200);
            this.preferentialPanel.TabIndex = 7;
            this.preferentialPanel.Click += new System.EventHandler(this.preferentialPanel_Click);
            // 
            // adultsChildrenPanel
            // 
            this.adultsChildrenPanel.BackgroundImage = global::SalusHalo_Practic.Properties.Resources.Взрослый_ребенок_1;
            this.adultsChildrenPanel.Cursor = System.Windows.Forms.Cursors.Hand;
            this.adultsChildrenPanel.Location = new System.Drawing.Point(549, 47);
            this.adultsChildrenPanel.Name = "adultsChildrenPanel";
            this.adultsChildrenPanel.Size = new System.Drawing.Size(200, 200);
            this.adultsChildrenPanel.TabIndex = 6;
            this.adultsChildrenPanel.Click += new System.EventHandler(this.adultsChildrenPanel_Click);
            // 
            // adultsPanel
            // 
            this.adultsPanel.BackgroundImage = global::SalusHalo_Practic.Properties.Resources.взрослый_1;
            this.adultsPanel.Cursor = System.Windows.Forms.Cursors.Hand;
            this.adultsPanel.Location = new System.Drawing.Point(288, 47);
            this.adultsPanel.Name = "adultsPanel";
            this.adultsPanel.Size = new System.Drawing.Size(200, 200);
            this.adultsPanel.TabIndex = 5;
            this.adultsPanel.Click += new System.EventHandler(this.adultsPanel_Click);
            // 
            // childrenPanel
            // 
            this.childrenPanel.BackgroundImage = global::SalusHalo_Practic.Properties.Resources.Дети_1;
            this.childrenPanel.Cursor = System.Windows.Forms.Cursors.Hand;
            this.childrenPanel.Location = new System.Drawing.Point(27, 47);
            this.childrenPanel.Name = "childrenPanel";
            this.childrenPanel.Size = new System.Drawing.Size(200, 200);
            this.childrenPanel.TabIndex = 4;
            this.childrenPanel.Click += new System.EventHandler(this.childrenPanel_Click);
            // 
            // StartPage
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.BackColor = System.Drawing.Color.White;
            this.Controls.Add(this.preferentialPanel);
            this.Controls.Add(this.adultsChildrenPanel);
            this.Controls.Add(this.adultsPanel);
            this.Controls.Add(this.childrenPanel);
            this.Controls.Add(this.panel3);
            this.Font = new System.Drawing.Font("Georgia", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Margin = new System.Windows.Forms.Padding(0);
            this.Name = "StartPage";
            this.Size = new System.Drawing.Size(1036, 368);
            this.panel3.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel childrenPanel;
        private System.Windows.Forms.Panel adultsPanel;
        private System.Windows.Forms.Panel adultsChildrenPanel;
        private System.Windows.Forms.Panel preferentialPanel;
    }
}
