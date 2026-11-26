namespace Kindergarten
{
    partial class Form3
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
            this.labelFio = new System.Windows.Forms.Label();
            this.textBoxFio = new System.Windows.Forms.TextBox();
            this.labelBirth = new System.Windows.Forms.Label();
            this.dateTimePickerBirth = new System.Windows.Forms.DateTimePicker();
            this.labelGender = new System.Windows.Forms.Label();
            this.comboBoxGender = new System.Windows.Forms.ComboBox();
            this.labelGroup = new System.Windows.Forms.Label();
            this.comboBoxGroup = new System.Windows.Forms.ComboBox();
            this.labelParentFio = new System.Windows.Forms.Label();
            this.textBoxParentFio = new System.Windows.Forms.TextBox();
            this.labelParentPhone = new System.Windows.Forms.Label();
            this.textBoxParentPhone = new System.Windows.Forms.TextBox();
            this.buttonSave = new System.Windows.Forms.Button();
            this.buttonCancel = new System.Windows.Forms.Button();
            this.panelHeader.SuspendLayout();
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
            this.labelHeader.Text = "Form3";
            // 
            // labelFio
            // 
            this.labelFio.AutoSize = true;
            this.labelFio.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.labelFio.ForeColor = System.Drawing.Color.FromArgb(52, 58, 64);
            this.labelFio.Location = new System.Drawing.Point(22, 70);
            this.labelFio.Name = "labelFio";
            this.labelFio.Text = "ФИО ребёнка";
            // 
            // textBoxFio
            // 
            this.textBoxFio.Font = new System.Drawing.Font("Segoe UI", 11F);
            this.textBoxFio.Location = new System.Drawing.Point(24, 92);
            this.textBoxFio.Name = "textBoxFio";
            this.textBoxFio.Size = new System.Drawing.Size(340, 27);
            this.textBoxFio.TabIndex = 0;
            this.textBoxFio.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            // 
            // labelBirth
            // 
            this.labelBirth.AutoSize = true;
            this.labelBirth.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.labelBirth.ForeColor = System.Drawing.Color.FromArgb(52, 58, 64);
            this.labelBirth.Location = new System.Drawing.Point(22, 132);
            this.labelBirth.Name = "labelBirth";
            this.labelBirth.Text = "Дата рождения";
            // 
            // dateTimePickerBirth
            // 
            this.dateTimePickerBirth.Font = new System.Drawing.Font("Segoe UI", 11F);
            this.dateTimePickerBirth.Location = new System.Drawing.Point(24, 154);
            this.dateTimePickerBirth.Name = "dateTimePickerBirth";
            this.dateTimePickerBirth.Size = new System.Drawing.Size(340, 27);
            this.dateTimePickerBirth.TabIndex = 1;
            this.dateTimePickerBirth.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            // 
            // labelGender
            // 
            this.labelGender.AutoSize = true;
            this.labelGender.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.labelGender.ForeColor = System.Drawing.Color.FromArgb(52, 58, 64);
            this.labelGender.Location = new System.Drawing.Point(22, 194);
            this.labelGender.Name = "labelGender";
            this.labelGender.Text = "Пол";
            // 
            // comboBoxGender
            // 
            this.comboBoxGender.Font = new System.Drawing.Font("Segoe UI", 11F);
            this.comboBoxGender.Location = new System.Drawing.Point(24, 216);
            this.comboBoxGender.Name = "comboBoxGender";
            this.comboBoxGender.Size = new System.Drawing.Size(340, 27);
            this.comboBoxGender.TabIndex = 2;
            this.comboBoxGender.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.comboBoxGender.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            // 
            // labelGroup
            // 
            this.labelGroup.AutoSize = true;
            this.labelGroup.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.labelGroup.ForeColor = System.Drawing.Color.FromArgb(52, 58, 64);
            this.labelGroup.Location = new System.Drawing.Point(22, 256);
            this.labelGroup.Name = "labelGroup";
            this.labelGroup.Text = "Группа";
            // 
            // comboBoxGroup
            // 
            this.comboBoxGroup.Font = new System.Drawing.Font("Segoe UI", 11F);
            this.comboBoxGroup.Location = new System.Drawing.Point(24, 278);
            this.comboBoxGroup.Name = "comboBoxGroup";
            this.comboBoxGroup.Size = new System.Drawing.Size(340, 27);
            this.comboBoxGroup.TabIndex = 3;
            this.comboBoxGroup.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.comboBoxGroup.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            // 
            // labelParentFio
            // 
            this.labelParentFio.AutoSize = true;
            this.labelParentFio.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.labelParentFio.ForeColor = System.Drawing.Color.FromArgb(52, 58, 64);
            this.labelParentFio.Location = new System.Drawing.Point(22, 318);
            this.labelParentFio.Name = "labelParentFio";
            this.labelParentFio.Text = "ФИО родителя";
            // 
            // textBoxParentFio
            // 
            this.textBoxParentFio.Font = new System.Drawing.Font("Segoe UI", 11F);
            this.textBoxParentFio.Location = new System.Drawing.Point(24, 340);
            this.textBoxParentFio.Name = "textBoxParentFio";
            this.textBoxParentFio.Size = new System.Drawing.Size(340, 27);
            this.textBoxParentFio.TabIndex = 4;
            this.textBoxParentFio.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            // 
            // labelParentPhone
            // 
            this.labelParentPhone.AutoSize = true;
            this.labelParentPhone.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.labelParentPhone.ForeColor = System.Drawing.Color.FromArgb(52, 58, 64);
            this.labelParentPhone.Location = new System.Drawing.Point(22, 380);
            this.labelParentPhone.Name = "labelParentPhone";
            this.labelParentPhone.Text = "Телефон родителя";
            // 
            // textBoxParentPhone
            // 
            this.textBoxParentPhone.Font = new System.Drawing.Font("Segoe UI", 11F);
            this.textBoxParentPhone.Location = new System.Drawing.Point(24, 402);
            this.textBoxParentPhone.Name = "textBoxParentPhone";
            this.textBoxParentPhone.Size = new System.Drawing.Size(340, 27);
            this.textBoxParentPhone.TabIndex = 5;
            this.textBoxParentPhone.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            // 
            // buttonSave
            // 
            this.buttonSave.BackColor = System.Drawing.Color.FromArgb(42, 157, 143);
            this.buttonSave.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttonSave.FlatAppearance.BorderSize = 0;
            this.buttonSave.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonSave.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.buttonSave.ForeColor = System.Drawing.Color.White;
            this.buttonSave.Location = new System.Drawing.Point(24, 450);
            this.buttonSave.Name = "buttonSave";
            this.buttonSave.Size = new System.Drawing.Size(164, 40);
            this.buttonSave.TabIndex = 6;
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
            this.buttonCancel.Location = new System.Drawing.Point(200, 450);
            this.buttonCancel.Name = "buttonCancel";
            this.buttonCancel.Size = new System.Drawing.Size(164, 40);
            this.buttonCancel.TabIndex = 7;
            this.buttonCancel.Text = "Отмена";
            this.buttonCancel.UseVisualStyleBackColor = false;
            this.buttonCancel.Click += new System.EventHandler(this.buttonCancel_Click);
            // 
            // Form3
            // 
            this.AcceptButton = this.buttonSave;
            this.CancelButton = this.buttonCancel;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(255, 250, 244);
            this.ClientSize = new System.Drawing.Size(388, 510);
            this.Controls.Add(this.buttonCancel);
            this.Controls.Add(this.buttonSave);
            this.Controls.Add(this.textBoxParentPhone);
            this.Controls.Add(this.labelParentPhone);
            this.Controls.Add(this.textBoxParentFio);
            this.Controls.Add(this.labelParentFio);
            this.Controls.Add(this.comboBoxGroup);
            this.Controls.Add(this.labelGroup);
            this.Controls.Add(this.comboBoxGender);
            this.Controls.Add(this.labelGender);
            this.Controls.Add(this.dateTimePickerBirth);
            this.Controls.Add(this.labelBirth);
            this.Controls.Add(this.textBoxFio);
            this.Controls.Add(this.labelFio);
            this.Controls.Add(this.panelHeader);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.Name = "Form3";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Form3";
            this.MinimizeBox = false;
            this.Load += new System.EventHandler(this.Form3_Load);
            this.panelHeader.ResumeLayout(false);
            this.panelHeader.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();
        }

        #endregion

        private System.Windows.Forms.Panel panelHeader;
        private System.Windows.Forms.Label labelHeader;
        private System.Windows.Forms.Label labelFio;
        private System.Windows.Forms.TextBox textBoxFio;
        private System.Windows.Forms.Label labelBirth;
        private System.Windows.Forms.DateTimePicker dateTimePickerBirth;
        private System.Windows.Forms.Label labelGender;
        private System.Windows.Forms.ComboBox comboBoxGender;
        private System.Windows.Forms.Label labelGroup;
        private System.Windows.Forms.ComboBox comboBoxGroup;
        private System.Windows.Forms.Label labelParentFio;
        private System.Windows.Forms.TextBox textBoxParentFio;
        private System.Windows.Forms.Label labelParentPhone;
        private System.Windows.Forms.TextBox textBoxParentPhone;
        private System.Windows.Forms.Button buttonSave;
        private System.Windows.Forms.Button buttonCancel;
    }
}
