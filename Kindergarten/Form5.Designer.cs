namespace Kindergarten
{
    partial class Form5
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
            this.labelPhone = new System.Windows.Forms.Label();
            this.textBoxPhone = new System.Windows.Forms.TextBox();
            this.labelExperience = new System.Windows.Forms.Label();
            this.numericUpDownExperience = new System.Windows.Forms.NumericUpDown();
            this.buttonSave = new System.Windows.Forms.Button();
            this.buttonCancel = new System.Windows.Forms.Button();
            this.panelHeader.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownExperience)).BeginInit();
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
            this.labelHeader.Text = "Form5";
            // 
            // labelFio
            // 
            this.labelFio.AutoSize = true;
            this.labelFio.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.labelFio.ForeColor = System.Drawing.Color.FromArgb(52, 58, 64);
            this.labelFio.Location = new System.Drawing.Point(22, 70);
            this.labelFio.Name = "labelFio";
            this.labelFio.Text = "ФИО воспитателя";
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
            // labelPhone
            // 
            this.labelPhone.AutoSize = true;
            this.labelPhone.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.labelPhone.ForeColor = System.Drawing.Color.FromArgb(52, 58, 64);
            this.labelPhone.Location = new System.Drawing.Point(22, 132);
            this.labelPhone.Name = "labelPhone";
            this.labelPhone.Text = "Телефон";
            // 
            // textBoxPhone
            // 
            this.textBoxPhone.Font = new System.Drawing.Font("Segoe UI", 11F);
            this.textBoxPhone.Location = new System.Drawing.Point(24, 154);
            this.textBoxPhone.Name = "textBoxPhone";
            this.textBoxPhone.Size = new System.Drawing.Size(340, 27);
            this.textBoxPhone.TabIndex = 1;
            this.textBoxPhone.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            // 
            // labelExperience
            // 
            this.labelExperience.AutoSize = true;
            this.labelExperience.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.labelExperience.ForeColor = System.Drawing.Color.FromArgb(52, 58, 64);
            this.labelExperience.Location = new System.Drawing.Point(22, 194);
            this.labelExperience.Name = "labelExperience";
            this.labelExperience.Text = "Стаж работы, лет";
            // 
            // numericUpDownExperience
            // 
            this.numericUpDownExperience.Font = new System.Drawing.Font("Segoe UI", 11F);
            this.numericUpDownExperience.Location = new System.Drawing.Point(24, 216);
            this.numericUpDownExperience.Name = "numericUpDownExperience";
            this.numericUpDownExperience.Size = new System.Drawing.Size(120, 27);
            this.numericUpDownExperience.TabIndex = 2;
            this.numericUpDownExperience.Maximum = new decimal(new int[] { 50, 0, 0, 0 });
            // 
            // buttonSave
            // 
            this.buttonSave.BackColor = System.Drawing.Color.FromArgb(42, 157, 143);
            this.buttonSave.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttonSave.FlatAppearance.BorderSize = 0;
            this.buttonSave.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonSave.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.buttonSave.ForeColor = System.Drawing.Color.White;
            this.buttonSave.Location = new System.Drawing.Point(24, 264);
            this.buttonSave.Name = "buttonSave";
            this.buttonSave.Size = new System.Drawing.Size(164, 40);
            this.buttonSave.TabIndex = 3;
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
            this.buttonCancel.Location = new System.Drawing.Point(200, 264);
            this.buttonCancel.Name = "buttonCancel";
            this.buttonCancel.Size = new System.Drawing.Size(164, 40);
            this.buttonCancel.TabIndex = 4;
            this.buttonCancel.Text = "Отмена";
            this.buttonCancel.UseVisualStyleBackColor = false;
            this.buttonCancel.Click += new System.EventHandler(this.buttonCancel_Click);
            // 
            // Form5
            // 
            this.AcceptButton = this.buttonSave;
            this.CancelButton = this.buttonCancel;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(255, 250, 244);
            this.ClientSize = new System.Drawing.Size(388, 324);
            this.Controls.Add(this.buttonCancel);
            this.Controls.Add(this.buttonSave);
            this.Controls.Add(this.numericUpDownExperience);
            this.Controls.Add(this.labelExperience);
            this.Controls.Add(this.textBoxPhone);
            this.Controls.Add(this.labelPhone);
            this.Controls.Add(this.textBoxFio);
            this.Controls.Add(this.labelFio);
            this.Controls.Add(this.panelHeader);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.Name = "Form5";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Form5";
            this.MinimizeBox = false;
            this.Load += new System.EventHandler(this.Form5_Load);
            this.panelHeader.ResumeLayout(false);
            this.panelHeader.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownExperience)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();
        }

        #endregion

        private System.Windows.Forms.Panel panelHeader;
        private System.Windows.Forms.Label labelHeader;
        private System.Windows.Forms.Label labelFio;
        private System.Windows.Forms.TextBox textBoxFio;
        private System.Windows.Forms.Label labelPhone;
        private System.Windows.Forms.TextBox textBoxPhone;
        private System.Windows.Forms.Label labelExperience;
        private System.Windows.Forms.NumericUpDown numericUpDownExperience;
        private System.Windows.Forms.Button buttonSave;
        private System.Windows.Forms.Button buttonCancel;
    }
}
