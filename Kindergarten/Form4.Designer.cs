namespace Kindergarten
{
    partial class Form4
    {
        private System.ComponentModel.IContainer components = null;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows Forms

        private void InitializeComponent()
        {
            this.panelHeader = new System.Windows.Forms.Panel();
            this.labelHeader = new System.Windows.Forms.Label();
            this.labelName = new System.Windows.Forms.Label();
            this.textBoxName = new System.Windows.Forms.TextBox();
            this.labelAge = new System.Windows.Forms.Label();
            this.comboBoxAge = new System.Windows.Forms.ComboBox();
            this.labelMax = new System.Windows.Forms.Label();
            this.numericUpDownMax = new System.Windows.Forms.NumericUpDown();
            this.labelTeacher = new System.Windows.Forms.Label();
            this.comboBoxTeacher = new System.Windows.Forms.ComboBox();
            this.buttonSave = new System.Windows.Forms.Button();
            this.buttonCancel = new System.Windows.Forms.Button();
            this.panelHeader.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownMax)).BeginInit();
            this.SuspendLayout();
            // 
            // panelHeader
            // 
            this.panelHeader.BackColor = System.Drawing.Color.FromArgb(242, 140, 56);
            this.panelHeader.Controls.Add(this.labelHeader);
            this.panelHeader.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelHeader.Location = new System.Drawing.Point(0, 0);
            this.panelHeader.Name = "panelHeader";
            this.panelHeader.Size = new System.Drawing.Size(100, 54);
            // 
            // labelHeader
            // 
            this.labelHeader.AutoSize = true;
            this.labelHeader.Font = new System.Drawing.Font("Segoe UI", 13F, System.Drawing.FontStyle.Bold);
            this.labelHeader.ForeColor = System.Drawing.Color.White;
            this.labelHeader.Location = new System.Drawing.Point(18, 14);
            this.labelHeader.Name = "labelHeader";
            this.labelHeader.Text = "Form4";
            // 
            // labelName
            // 
            this.labelName.AutoSize = true;
            this.labelName.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.labelName.ForeColor = System.Drawing.Color.FromArgb(52, 58, 64);
            this.labelName.Location = new System.Drawing.Point(22, 70);
            this.labelName.Name = "labelName";
            this.labelName.Text = "Название группы";
            // 
            // textBoxName
            // 
            this.textBoxName.Font = new System.Drawing.Font("Segoe UI", 11F);
            this.textBoxName.Location = new System.Drawing.Point(24, 92);
            this.textBoxName.Name = "textBoxName";
            this.textBoxName.Size = new System.Drawing.Size(340, 27);
            this.textBoxName.TabIndex = 0;
            this.textBoxName.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            // 
            // labelAge
            // 
            this.labelAge.AutoSize = true;
            this.labelAge.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.labelAge.ForeColor = System.Drawing.Color.FromArgb(52, 58, 64);
            this.labelAge.Location = new System.Drawing.Point(22, 132);
            this.labelAge.Name = "labelAge";
            this.labelAge.Text = "Возрастная категория";
            // 
            // comboBoxAge
            // 
            this.comboBoxAge.Font = new System.Drawing.Font("Segoe UI", 11F);
            this.comboBoxAge.Location = new System.Drawing.Point(24, 154);
            this.comboBoxAge.Name = "comboBoxAge";
            this.comboBoxAge.Size = new System.Drawing.Size(340, 27);
            this.comboBoxAge.TabIndex = 1;
            this.comboBoxAge.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.comboBoxAge.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            // 
            // labelMax
            // 
            this.labelMax.AutoSize = true;
            this.labelMax.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.labelMax.ForeColor = System.Drawing.Color.FromArgb(52, 58, 64);
            this.labelMax.Location = new System.Drawing.Point(22, 194);
            this.labelMax.Name = "labelMax";
            this.labelMax.Text = "Количество мест";
            // 
            // numericUpDownMax
            // 
            this.numericUpDownMax.Font = new System.Drawing.Font("Segoe UI", 11F);
            this.numericUpDownMax.Location = new System.Drawing.Point(24, 216);
            this.numericUpDownMax.Name = "numericUpDownMax";
            this.numericUpDownMax.Size = new System.Drawing.Size(120, 27);
            this.numericUpDownMax.TabIndex = 2;
            this.numericUpDownMax.Minimum = new decimal(new int[] { 5, 0, 0, 0 });
            this.numericUpDownMax.Maximum = new decimal(new int[] { 30, 0, 0, 0 });
            this.numericUpDownMax.Value = new decimal(new int[] { 20, 0, 0, 0 });
            // 
            // labelTeacher
            // 
            this.labelTeacher.AutoSize = true;
            this.labelTeacher.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.labelTeacher.ForeColor = System.Drawing.Color.FromArgb(52, 58, 64);
            this.labelTeacher.Location = new System.Drawing.Point(22, 256);
            this.labelTeacher.Name = "labelTeacher";
            this.labelTeacher.Text = "Воспитатель";
            // 
            // comboBoxTeacher
            // 
            this.comboBoxTeacher.Font = new System.Drawing.Font("Segoe UI", 11F);
            this.comboBoxTeacher.Location = new System.Drawing.Point(24, 278);
            this.comboBoxTeacher.Name = "comboBoxTeacher";
            this.comboBoxTeacher.Size = new System.Drawing.Size(340, 27);
            this.comboBoxTeacher.TabIndex = 3;
            this.comboBoxTeacher.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.comboBoxTeacher.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            // 
            // buttonSave
            // 
            this.buttonSave.BackColor = System.Drawing.Color.FromArgb(42, 157, 143);
            this.buttonSave.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttonSave.FlatAppearance.BorderSize = 0;
            this.buttonSave.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonSave.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.buttonSave.ForeColor = System.Drawing.Color.White;
            this.buttonSave.Location = new System.Drawing.Point(24, 326);
            this.buttonSave.Name = "buttonSave";
            this.buttonSave.Size = new System.Drawing.Size(164, 40);
            this.buttonSave.TabIndex = 4;
            this.buttonSave.Text = "Сохранить";
            this.buttonSave.UseVisualStyleBackColor = false;
            this.buttonSave.Click += new System.EventHandler(this.buttonSave_Click);
            // 
            // buttonCancel
            // 
            this.buttonCancel.BackColor = System.Drawing.Color.FromArgb(233, 236, 239);
            this.buttonCancel.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttonCancel.FlatAppearance.BorderSize = 0;
            this.buttonCancel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonCancel.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.buttonCancel.ForeColor = System.Drawing.Color.FromArgb(52, 58, 64);
            this.buttonCancel.Location = new System.Drawing.Point(200, 326);
            this.buttonCancel.Name = "buttonCancel";
            this.buttonCancel.Size = new System.Drawing.Size(164, 40);
            this.buttonCancel.TabIndex = 5;
            this.buttonCancel.Text = "Отмена";
            this.buttonCancel.UseVisualStyleBackColor = false;
            this.buttonCancel.Click += new System.EventHandler(this.buttonCancel_Click);
            // 
            // Form4
            // 
            this.AcceptButton = this.buttonSave;
            this.CancelButton = this.buttonCancel;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(255, 250, 244);
            this.ClientSize = new System.Drawing.Size(388, 386);
            this.Controls.Add(this.buttonCancel);
            this.Controls.Add(this.buttonSave);
            this.Controls.Add(this.comboBoxTeacher);
            this.Controls.Add(this.labelTeacher);
            this.Controls.Add(this.numericUpDownMax);
            this.Controls.Add(this.labelMax);
            this.Controls.Add(this.comboBoxAge);
            this.Controls.Add(this.labelAge);
            this.Controls.Add(this.textBoxName);
            this.Controls.Add(this.labelName);
            this.Controls.Add(this.panelHeader);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.Name = "Form4";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Form4";
            this.MinimizeBox = false;
            this.Load += new System.EventHandler(this.Form4_Load);
            this.panelHeader.ResumeLayout(false);
            this.panelHeader.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownMax)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();
        }

        #endregion

        private System.Windows.Forms.Panel panelHeader;
        private System.Windows.Forms.Label labelHeader;
        private System.Windows.Forms.Label labelName;
        private System.Windows.Forms.TextBox textBoxName;
        private System.Windows.Forms.Label labelAge;
        private System.Windows.Forms.ComboBox comboBoxAge;
        private System.Windows.Forms.Label labelMax;
        private System.Windows.Forms.NumericUpDown numericUpDownMax;
        private System.Windows.Forms.Label labelTeacher;
        private System.Windows.Forms.ComboBox comboBoxTeacher;
        private System.Windows.Forms.Button buttonSave;
        private System.Windows.Forms.Button buttonCancel;
    }
}
