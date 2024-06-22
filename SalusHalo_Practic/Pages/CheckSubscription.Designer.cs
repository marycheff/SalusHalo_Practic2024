namespace SalusHalo_Practic
{
    partial class CheckSubscription
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.lbSubId = new System.Windows.Forms.Label();
            this.lbVisitor = new System.Windows.Forms.Label();
            this.lbEndDate = new System.Windows.Forms.Label();
            this.lbNumOfSessions = new System.Windows.Forms.Label();
            this.lbNumOfVisits = new System.Windows.Forms.Label();
            this.lbRemainingVisits = new System.Windows.Forms.Label();
            this.lbStatus = new System.Windows.Forms.Label();
            this.borderedPanel1 = new BorderedPanel();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.date = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.time = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.label15 = new System.Windows.Forms.Label();
            this.borderedPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Georgia", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(16)))), ((int)(((byte)(133)))), ((int)(((byte)(179)))));
            this.label1.Location = new System.Drawing.Point(20, 32);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(202, 23);
            this.label1.TabIndex = 0;
            this.label1.Text = "Номер абонемента";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Georgia", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(16)))), ((int)(((byte)(133)))), ((int)(((byte)(179)))));
            this.label2.Location = new System.Drawing.Point(20, 71);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(128, 23);
            this.label2.TabIndex = 1;
            this.label2.Text = "Посетитель";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Georgia", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(16)))), ((int)(((byte)(133)))), ((int)(((byte)(179)))));
            this.label3.Location = new System.Drawing.Point(20, 110);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(143, 23);
            this.label3.TabIndex = 2;
            this.label3.Text = "Действует до";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Georgia", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(16)))), ((int)(((byte)(133)))), ((int)(((byte)(179)))));
            this.label4.Location = new System.Drawing.Point(20, 149);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(215, 23);
            this.label4.TabIndex = 3;
            this.label4.Text = "Количество сеансов";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Georgia", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label5.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(16)))), ((int)(((byte)(133)))), ((int)(((byte)(179)))));
            this.label5.Location = new System.Drawing.Point(20, 188);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(131, 23);
            this.label5.TabIndex = 4;
            this.label5.Text = "Посещений";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Georgia", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label6.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(16)))), ((int)(((byte)(133)))), ((int)(((byte)(179)))));
            this.label6.Location = new System.Drawing.Point(20, 227);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(102, 23);
            this.label6.TabIndex = 5;
            this.label6.Text = "Осталось";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Georgia", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label7.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(16)))), ((int)(((byte)(133)))), ((int)(((byte)(179)))));
            this.label7.Location = new System.Drawing.Point(20, 266);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(76, 23);
            this.label7.TabIndex = 6;
            this.label7.Text = "Статус";
            // 
            // lbSubId
            // 
            this.lbSubId.AutoSize = true;
            this.lbSubId.Font = new System.Drawing.Font("Georgia", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lbSubId.ForeColor = System.Drawing.Color.Gray;
            this.lbSubId.Location = new System.Drawing.Point(271, 32);
            this.lbSubId.Name = "lbSubId";
            this.lbSubId.Size = new System.Drawing.Size(43, 23);
            this.lbSubId.TabIndex = 7;
            this.lbSubId.Text = "123";
            // 
            // lbVisitor
            // 
            this.lbVisitor.AutoSize = true;
            this.lbVisitor.Font = new System.Drawing.Font("Georgia", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lbVisitor.ForeColor = System.Drawing.Color.Gray;
            this.lbVisitor.Location = new System.Drawing.Point(271, 71);
            this.lbVisitor.Name = "lbVisitor";
            this.lbVisitor.Size = new System.Drawing.Size(257, 23);
            this.lbVisitor.TabIndex = 8;
            this.lbVisitor.Text = "Иванов Иван Иванович";
            // 
            // lbEndDate
            // 
            this.lbEndDate.AutoSize = true;
            this.lbEndDate.Font = new System.Drawing.Font("Georgia", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lbEndDate.ForeColor = System.Drawing.Color.Gray;
            this.lbEndDate.Location = new System.Drawing.Point(271, 110);
            this.lbEndDate.Name = "lbEndDate";
            this.lbEndDate.Size = new System.Drawing.Size(113, 23);
            this.lbEndDate.TabIndex = 9;
            this.lbEndDate.Text = "10.10.2010";
            // 
            // lbNumOfSessions
            // 
            this.lbNumOfSessions.AutoSize = true;
            this.lbNumOfSessions.Font = new System.Drawing.Font("Georgia", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lbNumOfSessions.ForeColor = System.Drawing.Color.Gray;
            this.lbNumOfSessions.Location = new System.Drawing.Point(271, 149);
            this.lbNumOfSessions.Name = "lbNumOfSessions";
            this.lbNumOfSessions.Size = new System.Drawing.Size(21, 23);
            this.lbNumOfSessions.TabIndex = 10;
            this.lbNumOfSessions.Text = "5";
            // 
            // lbNumOfVisits
            // 
            this.lbNumOfVisits.AutoSize = true;
            this.lbNumOfVisits.Font = new System.Drawing.Font("Georgia", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lbNumOfVisits.ForeColor = System.Drawing.Color.Gray;
            this.lbNumOfVisits.Location = new System.Drawing.Point(271, 188);
            this.lbNumOfVisits.Name = "lbNumOfVisits";
            this.lbNumOfVisits.Size = new System.Drawing.Size(43, 23);
            this.lbNumOfVisits.TabIndex = 11;
            this.lbNumOfVisits.Text = "123";
            // 
            // lbRemainingVisits
            // 
            this.lbRemainingVisits.AutoSize = true;
            this.lbRemainingVisits.Font = new System.Drawing.Font("Georgia", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lbRemainingVisits.ForeColor = System.Drawing.Color.Gray;
            this.lbRemainingVisits.Location = new System.Drawing.Point(271, 227);
            this.lbRemainingVisits.Name = "lbRemainingVisits";
            this.lbRemainingVisits.Size = new System.Drawing.Size(21, 23);
            this.lbRemainingVisits.TabIndex = 12;
            this.lbRemainingVisits.Text = "5";
            // 
            // lbStatus
            // 
            this.lbStatus.AutoSize = true;
            this.lbStatus.Font = new System.Drawing.Font("Georgia", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lbStatus.ForeColor = System.Drawing.Color.Gray;
            this.lbStatus.Location = new System.Drawing.Point(271, 266);
            this.lbStatus.Name = "lbStatus";
            this.lbStatus.Size = new System.Drawing.Size(43, 23);
            this.lbStatus.TabIndex = 13;
            this.lbStatus.Text = "123";
            // 
            // borderedPanel1
            // 
            this.borderedPanel1.Controls.Add(this.dataGridView1);
            this.borderedPanel1.Controls.Add(this.label15);
            this.borderedPanel1.Location = new System.Drawing.Point(658, 32);
            this.borderedPanel1.Name = "borderedPanel1";
            this.borderedPanel1.Size = new System.Drawing.Size(367, 312);
            this.borderedPanel1.TabIndex = 14;
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.AllowUserToResizeColumns = false;
            this.dataGridView1.AllowUserToResizeRows = false;
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView1.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.DisplayedCells;
            this.dataGridView1.BackgroundColor = System.Drawing.Color.White;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.date,
            this.time});
            this.dataGridView1.Location = new System.Drawing.Point(14, 39);
            this.dataGridView1.Margin = new System.Windows.Forms.Padding(0);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersVisible = false;
            this.dataGridView1.Size = new System.Drawing.Size(338, 259);
            this.dataGridView1.TabIndex = 2;
            // 
            // date
            // 
            this.date.HeaderText = "Дата";
            this.date.Name = "date";
            // 
            // time
            // 
            this.time.HeaderText = "Время";
            this.time.Name = "time";
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Font = new System.Drawing.Font("Georgia", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label15.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(16)))), ((int)(((byte)(133)))), ((int)(((byte)(179)))));
            this.label15.Location = new System.Drawing.Point(85, 10);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(207, 23);
            this.label15.TabIndex = 1;
            this.label15.Text = "Список посещений";
            // 
            // CheckSubscription
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.BackColor = System.Drawing.Color.White;
            this.Controls.Add(this.borderedPanel1);
            this.Controls.Add(this.lbStatus);
            this.Controls.Add(this.lbRemainingVisits);
            this.Controls.Add(this.lbNumOfVisits);
            this.Controls.Add(this.lbNumOfSessions);
            this.Controls.Add(this.lbEndDate);
            this.Controls.Add(this.lbVisitor);
            this.Controls.Add(this.lbSubId);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Georgia", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Margin = new System.Windows.Forms.Padding(0);
            this.Name = "CheckSubscription";
            this.Size = new System.Drawing.Size(1036, 368);
            this.borderedPanel1.ResumeLayout(false);
            this.borderedPanel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label lbSubId;
        private System.Windows.Forms.Label lbVisitor;
        private System.Windows.Forms.Label lbEndDate;
        private System.Windows.Forms.Label lbNumOfSessions;
        private System.Windows.Forms.Label lbNumOfVisits;
        private System.Windows.Forms.Label lbRemainingVisits;
        private System.Windows.Forms.Label lbStatus;
        private BorderedPanel borderedPanel1;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridViewTextBoxColumn date;
        private System.Windows.Forms.DataGridViewTextBoxColumn time;
    }
}
