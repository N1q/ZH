namespace CollegeTroops
{
    partial class newTroop
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
            this.cb_name = new System.Windows.Forms.ComboBox();
            this.b_cancel = new System.Windows.Forms.Button();
            this.b_done = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.cb_gender = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.title = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.n_age = new System.Windows.Forms.NumericUpDown();
            this.label5 = new System.Windows.Forms.Label();
            this.cb_familyStatus = new System.Windows.Forms.ComboBox();
            this.ch_haveKids = new System.Windows.Forms.CheckBox();
            this.cb_duty = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.cb_knowledge = new System.Windows.Forms.ComboBox();
            this.label6 = new System.Windows.Forms.Label();
            this.n_oklad = new System.Windows.Forms.NumericUpDown();
            this.label7 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.n_age)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.n_oklad)).BeginInit();
            this.SuspendLayout();
            // 
            // cb_name
            // 
            this.cb_name.FormattingEnabled = true;
            this.cb_name.Location = new System.Drawing.Point(13, 83);
            this.cb_name.Name = "cb_name";
            this.cb_name.Size = new System.Drawing.Size(256, 24);
            this.cb_name.TabIndex = 27;
            // 
            // b_cancel
            // 
            this.b_cancel.Location = new System.Drawing.Point(15, 361);
            this.b_cancel.Name = "b_cancel";
            this.b_cancel.Size = new System.Drawing.Size(68, 24);
            this.b_cancel.TabIndex = 26;
            this.b_cancel.Text = "Отмена";
            this.b_cancel.UseVisualStyleBackColor = true;
            this.b_cancel.Click += new System.EventHandler(this.b_cancel_Click);
            // 
            // b_done
            // 
            this.b_done.Location = new System.Drawing.Point(201, 361);
            this.b_done.Name = "b_done";
            this.b_done.Size = new System.Drawing.Size(68, 24);
            this.b_done.TabIndex = 25;
            this.b_done.Text = "Готово";
            this.b_done.UseVisualStyleBackColor = true;
            this.b_done.Click += new System.EventHandler(this.b_done_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(10, 109);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(34, 17);
            this.label2.TabIndex = 24;
            this.label2.Text = "Пол";
            // 
            // cb_gender
            // 
            this.cb_gender.FormattingEnabled = true;
            this.cb_gender.Items.AddRange(new object[] {
            "М",
            "Ж"});
            this.cb_gender.Location = new System.Drawing.Point(13, 129);
            this.cb_gender.Name = "cb_gender";
            this.cb_gender.Size = new System.Drawing.Size(39, 24);
            this.cb_gender.TabIndex = 23;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(10, 63);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(42, 17);
            this.label3.TabIndex = 21;
            this.label3.Text = "ФИО";
            // 
            // title
            // 
            this.title.AutoSize = true;
            this.title.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.title.Location = new System.Drawing.Point(8, 17);
            this.title.Name = "title";
            this.title.Size = new System.Drawing.Size(261, 29);
            this.title.TabIndex = 19;
            this.title.Text = "Добавить сотрудника";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(55, 109);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(62, 17);
            this.label4.TabIndex = 29;
            this.label4.Text = "Возраст";
            // 
            // n_age
            // 
            this.n_age.Location = new System.Drawing.Point(58, 129);
            this.n_age.Name = "n_age";
            this.n_age.Size = new System.Drawing.Size(59, 22);
            this.n_age.TabIndex = 30;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(120, 109);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(151, 17);
            this.label5.TabIndex = 32;
            this.label5.Text = "Семейное положение";
            // 
            // cb_familyStatus
            // 
            this.cb_familyStatus.FormattingEnabled = true;
            this.cb_familyStatus.Items.AddRange(new object[] {
            "Женат/Замужем",
            "Не женат/не замужем"});
            this.cb_familyStatus.Location = new System.Drawing.Point(123, 129);
            this.cb_familyStatus.Name = "cb_familyStatus";
            this.cb_familyStatus.Size = new System.Drawing.Size(146, 24);
            this.cb_familyStatus.TabIndex = 31;
            // 
            // ch_haveKids
            // 
            this.ch_haveKids.AutoSize = true;
            this.ch_haveKids.Location = new System.Drawing.Point(13, 159);
            this.ch_haveKids.Name = "ch_haveKids";
            this.ch_haveKids.Size = new System.Drawing.Size(95, 21);
            this.ch_haveKids.TabIndex = 33;
            this.ch_haveKids.Text = "Есть дети";
            this.ch_haveKids.UseVisualStyleBackColor = true;
            // 
            // cb_duty
            // 
            this.cb_duty.FormattingEnabled = true;
            this.cb_duty.Location = new System.Drawing.Point(13, 202);
            this.cb_duty.Name = "cb_duty";
            this.cb_duty.Size = new System.Drawing.Size(256, 24);
            this.cb_duty.TabIndex = 35;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(10, 182);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(81, 17);
            this.label1.TabIndex = 34;
            this.label1.Text = "Должность";
            // 
            // cb_knowledge
            // 
            this.cb_knowledge.FormattingEnabled = true;
            this.cb_knowledge.Location = new System.Drawing.Point(15, 250);
            this.cb_knowledge.Name = "cb_knowledge";
            this.cb_knowledge.Size = new System.Drawing.Size(254, 24);
            this.cb_knowledge.TabIndex = 37;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(12, 230);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(114, 17);
            this.label6.TabIndex = 36;
            this.label6.Text = "Ученая степень";
            // 
            // n_oklad
            // 
            this.n_oklad.Location = new System.Drawing.Point(68, 301);
            this.n_oklad.Maximum = new decimal(new int[] {
            10000000,
            0,
            0,
            0});
            this.n_oklad.Name = "n_oklad";
            this.n_oklad.Size = new System.Drawing.Size(201, 22);
            this.n_oklad.TabIndex = 38;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(12, 301);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(50, 17);
            this.label7.TabIndex = 39;
            this.label7.Text = "Оклад";
            // 
            // newTroop
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(287, 397);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.n_oklad);
            this.Controls.Add(this.cb_knowledge);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.cb_duty);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.ch_haveKids);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.cb_familyStatus);
            this.Controls.Add(this.n_age);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.cb_name);
            this.Controls.Add(this.b_cancel);
            this.Controls.Add(this.b_done);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.cb_gender);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.title);
            this.Name = "newTroop";
            this.Text = "newTroop";
            this.Load += new System.EventHandler(this.newTroop_Load);
            ((System.ComponentModel.ISupportInitialize)(this.n_age)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.n_oklad)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox cb_name;
        public System.Windows.Forms.Button b_cancel;
        public System.Windows.Forms.Button b_done;
        public System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox cb_gender;
        public System.Windows.Forms.Label label3;
        public System.Windows.Forms.Label title;
        public System.Windows.Forms.Label label4;
        private System.Windows.Forms.NumericUpDown n_age;
        public System.Windows.Forms.Label label5;
        private System.Windows.Forms.ComboBox cb_familyStatus;
        private System.Windows.Forms.CheckBox ch_haveKids;
        private System.Windows.Forms.ComboBox cb_duty;
        public System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cb_knowledge;
        public System.Windows.Forms.Label label6;
        private System.Windows.Forms.NumericUpDown n_oklad;
        public System.Windows.Forms.Label label7;
    }
}