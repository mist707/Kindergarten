namespace Kindergarten
{
    partial class Form2
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
            this.labelTitle = new System.Windows.Forms.Label();
            this.labelSubtitle = new System.Windows.Forms.Label();
            this.labelUser = new System.Windows.Forms.Label();
            this.tabControlMain = new System.Windows.Forms.TabControl();
            this.tabPageChildren = new System.Windows.Forms.TabPage();
            this.tabPageGroups = new System.Windows.Forms.TabPage();
            this.tabPageTeachers = new System.Windows.Forms.TabPage();
            this.tabPageReport = new System.Windows.Forms.TabPage();
            this.dataGridViewChildren = new System.Windows.Forms.DataGridView();
            this.colChildId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colChildFio = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colChildBirth = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colChildAge = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colChildGender = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colChildGroup = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colChildParent = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colChildPhone = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewGroups = new System.Windows.Forms.DataGridView();
            this.colGroupId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colGroupName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colGroupAge = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colGroupTeacher = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colGroupCount = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTeachers = new System.Windows.Forms.DataGridView();
            this.colTeacherId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colTeacherFio = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colTeacherPhone = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colTeacherExp = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colTeacherGroup = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewReport = new System.Windows.Forms.DataGridView();
            this.colRepGroup = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colRepTeacher = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colRepCount = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colRepMax = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colRepFree = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colRepPercent = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.buttonAddChild = new System.Windows.Forms.Button();
            this.buttonEditChild = new System.Windows.Forms.Button();
            this.buttonDeleteChild = new System.Windows.Forms.Button();
            this.buttonAddGroup = new System.Windows.Forms.Button();
            this.buttonEditGroup = new System.Windows.Forms.Button();
            this.buttonDeleteGroup = new System.Windows.Forms.Button();
            this.buttonAddTeacher = new System.Windows.Forms.Button();
            this.buttonEditTeacher = new System.Windows.Forms.Button();
            this.buttonDeleteTeacher = new System.Windows.Forms.Button();
            this.labelSearch = new System.Windows.Forms.Label();
            this.textBoxSearch = new System.Windows.Forms.TextBox();
            this.labelFilterGroup = new System.Windows.Forms.Label();
            this.comboBoxFilterGroup = new System.Windows.Forms.ComboBox();
            this.labelReportTotal = new System.Windows.Forms.Label();
            this.labelStatus = new System.Windows.Forms.Label();
            this.buttonExit = new System.Windows.Forms.Button();
            System.Windows.Forms.DataGridViewCellStyle styleChildrenHead = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle styleChildrenCell = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle styleChildrenAlt = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle styleGroupsHead = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle styleGroupsCell = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle styleGroupsAlt = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle styleTeachersHead = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle styleTeachersCell = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle styleTeachersAlt = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle styleReportHead = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle styleReportCell = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle styleReportAlt = new System.Windows.Forms.DataGridViewCellStyle();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewChildren)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewGroups)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewTeachers)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewReport)).BeginInit();
            this.panelHeader.SuspendLayout();
            this.tabControlMain.SuspendLayout();
            this.tabPageChildren.SuspendLayout();
            this.tabPageGroups.SuspendLayout();
            this.tabPageTeachers.SuspendLayout();
            this.tabPageReport.SuspendLayout();
            this.SuspendLayout();
            // 
            // panelHeader
            // 
            this.panelHeader.BackColor = System.Drawing.Color.FromArgb(242, 140, 56);
            this.panelHeader.Controls.Add(this.labelTitle);
            this.panelHeader.Controls.Add(this.labelSubtitle);
            this.panelHeader.Controls.Add(this.labelUser);
            this.panelHeader.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelHeader.Location = new System.Drawing.Point(0, 0);
            this.panelHeader.Name = "panelHeader";
            this.panelHeader.Size = new System.Drawing.Size(100, 70);
            // 
            // labelTitle
            // 
            this.labelTitle.AutoSize = true;
            this.labelTitle.Font = new System.Drawing.Font("Segoe UI", 17F, System.Drawing.FontStyle.Bold);
            this.labelTitle.ForeColor = System.Drawing.Color.White;
            this.labelTitle.Location = new System.Drawing.Point(20, 8);
            this.labelTitle.Name = "labelTitle";
            this.labelTitle.Text = "Детский сад";
            // 
            // labelSubtitle
            // 
            this.labelSubtitle.AutoSize = true;
            this.labelSubtitle.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.labelSubtitle.ForeColor = System.Drawing.Color.White;
            this.labelSubtitle.Location = new System.Drawing.Point(23, 42);
            this.labelSubtitle.Name = "labelSubtitle";
            this.labelSubtitle.Text = "Учёт детей, групп и воспитателей";
            // 
            // labelUser
            // 
            this.labelUser.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Bold);
            this.labelUser.ForeColor = System.Drawing.Color.White;
            this.labelUser.Location = new System.Drawing.Point(760, 24);
            this.labelUser.Name = "labelUser";
            this.labelUser.Size = new System.Drawing.Size(220, 24);
            this.labelUser.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.labelUser.Text = "Заведующая";
            // 
            // tabControlMain
            // 
            this.tabControlMain.Controls.Add(this.tabPageChildren);
            this.tabControlMain.Controls.Add(this.tabPageGroups);
            this.tabControlMain.Controls.Add(this.tabPageTeachers);
            this.tabControlMain.Controls.Add(this.tabPageReport);
            this.tabControlMain.Font = new System.Drawing.Font("Segoe UI", 10.5F);
            this.tabControlMain.ItemSize = new System.Drawing.Size(150, 32);
            this.tabControlMain.SizeMode = System.Windows.Forms.TabSizeMode.Fixed;
            this.tabControlMain.Location = new System.Drawing.Point(12, 82);
            this.tabControlMain.Name = "tabControlMain";
            this.tabControlMain.SelectedIndex = 0;
            this.tabControlMain.Size = new System.Drawing.Size(976, 482);
            this.tabControlMain.TabIndex = 0;
            // 
            // tabPageChildren
            // 
            this.tabPageChildren.BackColor = System.Drawing.Color.White;
            this.tabPageChildren.Controls.Add(this.dataGridViewChildren);
            this.tabPageChildren.Controls.Add(this.labelSearch);
            this.tabPageChildren.Controls.Add(this.textBoxSearch);
            this.tabPageChildren.Controls.Add(this.labelFilterGroup);
            this.tabPageChildren.Controls.Add(this.comboBoxFilterGroup);
            this.tabPageChildren.Controls.Add(this.buttonAddChild);
            this.tabPageChildren.Controls.Add(this.buttonEditChild);
            this.tabPageChildren.Controls.Add(this.buttonDeleteChild);
            this.tabPageChildren.Location = new System.Drawing.Point(4, 36);
            this.tabPageChildren.Name = "tabPageChildren";
            this.tabPageChildren.Padding = new System.Windows.Forms.Padding(3);
            this.tabPageChildren.Size = new System.Drawing.Size(968, 442);
            this.tabPageChildren.TabIndex = 0;
            this.tabPageChildren.Text = "Дети";
            // 
            // tabPageGroups
            // 
            this.tabPageGroups.BackColor = System.Drawing.Color.White;
            this.tabPageGroups.Controls.Add(this.dataGridViewGroups);
            this.tabPageGroups.Controls.Add(this.buttonAddGroup);
            this.tabPageGroups.Controls.Add(this.buttonEditGroup);
            this.tabPageGroups.Controls.Add(this.buttonDeleteGroup);
            this.tabPageGroups.Location = new System.Drawing.Point(4, 36);
            this.tabPageGroups.Name = "tabPageGroups";
            this.tabPageGroups.Padding = new System.Windows.Forms.Padding(3);
            this.tabPageGroups.Size = new System.Drawing.Size(968, 442);
            this.tabPageGroups.TabIndex = 1;
            this.tabPageGroups.Text = "Группы";
            // 
            // tabPageTeachers
            // 
            this.tabPageTeachers.BackColor = System.Drawing.Color.White;
            this.tabPageTeachers.Controls.Add(this.dataGridViewTeachers);
            this.tabPageTeachers.Controls.Add(this.buttonAddTeacher);
            this.tabPageTeachers.Controls.Add(this.buttonEditTeacher);
            this.tabPageTeachers.Controls.Add(this.buttonDeleteTeacher);
            this.tabPageTeachers.Location = new System.Drawing.Point(4, 36);
            this.tabPageTeachers.Name = "tabPageTeachers";
            this.tabPageTeachers.Padding = new System.Windows.Forms.Padding(3);
            this.tabPageTeachers.Size = new System.Drawing.Size(968, 442);
            this.tabPageTeachers.TabIndex = 2;
            this.tabPageTeachers.Text = "Воспитатели";
            // 
            // tabPageReport
            // 
            this.tabPageReport.BackColor = System.Drawing.Color.White;
            this.tabPageReport.Controls.Add(this.dataGridViewReport);
            this.tabPageReport.Controls.Add(this.labelReportTotal);
            this.tabPageReport.Location = new System.Drawing.Point(4, 36);
            this.tabPageReport.Name = "tabPageReport";
            this.tabPageReport.Padding = new System.Windows.Forms.Padding(3);
            this.tabPageReport.Size = new System.Drawing.Size(968, 442);
            this.tabPageReport.TabIndex = 3;
            this.tabPageReport.Text = "Отчёт по группам";
            // 
            // dataGridViewChildren
            // 
            this.dataGridViewChildren.AllowUserToAddRows = false;
            this.dataGridViewChildren.AllowUserToDeleteRows = false;
            this.dataGridViewChildren.AllowUserToResizeRows = false;
            styleChildrenAlt.BackColor = System.Drawing.Color.FromArgb(255, 248, 240);
            this.dataGridViewChildren.AlternatingRowsDefaultCellStyle = styleChildrenAlt;
            this.dataGridViewChildren.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridViewChildren.BackgroundColor = System.Drawing.Color.White;
            this.dataGridViewChildren.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dataGridViewChildren.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.dataGridViewChildren.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            styleChildrenHead.BackColor = System.Drawing.Color.FromArgb(255, 232, 209);
            styleChildrenHead.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            styleChildrenHead.ForeColor = System.Drawing.Color.FromArgb(52, 58, 64);
            styleChildrenHead.SelectionBackColor = System.Drawing.Color.FromArgb(255, 232, 209);
            styleChildrenHead.SelectionForeColor = System.Drawing.Color.FromArgb(52, 58, 64);
            styleChildrenHead.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridViewChildren.ColumnHeadersDefaultCellStyle = styleChildrenHead;
            this.dataGridViewChildren.ColumnHeadersHeight = 40;
            this.dataGridViewChildren.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.dataGridViewChildren.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.colChildId,
            this.colChildFio,
            this.colChildBirth,
            this.colChildAge,
            this.colChildGender,
            this.colChildGroup,
            this.colChildParent,
            this.colChildPhone});
            styleChildrenCell.BackColor = System.Drawing.Color.White;
            styleChildrenCell.Font = new System.Drawing.Font("Segoe UI", 10F);
            styleChildrenCell.ForeColor = System.Drawing.Color.FromArgb(52, 58, 64);
            styleChildrenCell.Padding = new System.Windows.Forms.Padding(4, 0, 0, 0);
            styleChildrenCell.SelectionBackColor = System.Drawing.Color.FromArgb(255, 209, 163);
            styleChildrenCell.SelectionForeColor = System.Drawing.Color.FromArgb(52, 58, 64);
            this.dataGridViewChildren.DefaultCellStyle = styleChildrenCell;
            this.dataGridViewChildren.EnableHeadersVisualStyles = false;
            this.dataGridViewChildren.GridColor = System.Drawing.Color.FromArgb(240, 226, 210);
            this.dataGridViewChildren.Location = new System.Drawing.Point(14, 56);
            this.dataGridViewChildren.MultiSelect = false;
            this.dataGridViewChildren.Name = "dataGridViewChildren";
            this.dataGridViewChildren.ReadOnly = true;
            this.dataGridViewChildren.RowHeadersVisible = false;
            this.dataGridViewChildren.RowTemplate.Height = 30;
            this.dataGridViewChildren.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridViewChildren.Size = new System.Drawing.Size(940, 330);
            this.dataGridViewChildren.TabIndex = 0;
            this.dataGridViewChildren.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridViewChildren_CellDoubleClick);
            // 
            // colChildId
            // 
            this.colChildId.FillWeight = 6F;
            this.colChildId.HeaderText = "№";
            this.colChildId.Name = "colChildId";
            this.colChildId.ReadOnly = true;
            // 
            // colChildFio
            // 
            this.colChildFio.FillWeight = 30F;
            this.colChildFio.HeaderText = "ФИО ребёнка";
            this.colChildFio.Name = "colChildFio";
            this.colChildFio.ReadOnly = true;
            // 
            // colChildBirth
            // 
            this.colChildBirth.FillWeight = 14F;
            this.colChildBirth.HeaderText = "Дата рождения";
            this.colChildBirth.Name = "colChildBirth";
            this.colChildBirth.ReadOnly = true;
            // 
            // colChildAge
            // 
            this.colChildAge.FillWeight = 9F;
            this.colChildAge.HeaderText = "Возраст";
            this.colChildAge.Name = "colChildAge";
            this.colChildAge.ReadOnly = true;
            // 
            // colChildGender
            // 
            this.colChildGender.FillWeight = 6F;
            this.colChildGender.HeaderText = "Пол";
            this.colChildGender.Name = "colChildGender";
            this.colChildGender.ReadOnly = true;
            // 
            // colChildGroup
            // 
            this.colChildGroup.FillWeight = 13F;
            this.colChildGroup.HeaderText = "Группа";
            this.colChildGroup.Name = "colChildGroup";
            this.colChildGroup.ReadOnly = true;
            // 
            // colChildParent
            // 
            this.colChildParent.FillWeight = 28F;
            this.colChildParent.HeaderText = "Родитель";
            this.colChildParent.Name = "colChildParent";
            this.colChildParent.ReadOnly = true;
            // 
            // colChildPhone
            // 
            this.colChildPhone.FillWeight = 19F;
            this.colChildPhone.HeaderText = "Телефон";
            this.colChildPhone.Name = "colChildPhone";
            this.colChildPhone.ReadOnly = true;
            // 
            // dataGridViewGroups
            // 
            this.dataGridViewGroups.AllowUserToAddRows = false;
            this.dataGridViewGroups.AllowUserToDeleteRows = false;
            this.dataGridViewGroups.AllowUserToResizeRows = false;
            styleGroupsAlt.BackColor = System.Drawing.Color.FromArgb(255, 248, 240);
            this.dataGridViewGroups.AlternatingRowsDefaultCellStyle = styleGroupsAlt;
            this.dataGridViewGroups.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridViewGroups.BackgroundColor = System.Drawing.Color.White;
            this.dataGridViewGroups.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dataGridViewGroups.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.dataGridViewGroups.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            styleGroupsHead.BackColor = System.Drawing.Color.FromArgb(255, 232, 209);
            styleGroupsHead.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            styleGroupsHead.ForeColor = System.Drawing.Color.FromArgb(52, 58, 64);
            styleGroupsHead.SelectionBackColor = System.Drawing.Color.FromArgb(255, 232, 209);
            styleGroupsHead.SelectionForeColor = System.Drawing.Color.FromArgb(52, 58, 64);
            styleGroupsHead.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridViewGroups.ColumnHeadersDefaultCellStyle = styleGroupsHead;
            this.dataGridViewGroups.ColumnHeadersHeight = 40;
            this.dataGridViewGroups.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.dataGridViewGroups.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.colGroupId,
            this.colGroupName,
            this.colGroupAge,
            this.colGroupTeacher,
            this.colGroupCount});
            styleGroupsCell.BackColor = System.Drawing.Color.White;
            styleGroupsCell.Font = new System.Drawing.Font("Segoe UI", 10F);
            styleGroupsCell.ForeColor = System.Drawing.Color.FromArgb(52, 58, 64);
            styleGroupsCell.Padding = new System.Windows.Forms.Padding(4, 0, 0, 0);
            styleGroupsCell.SelectionBackColor = System.Drawing.Color.FromArgb(255, 209, 163);
            styleGroupsCell.SelectionForeColor = System.Drawing.Color.FromArgb(52, 58, 64);
            this.dataGridViewGroups.DefaultCellStyle = styleGroupsCell;
            this.dataGridViewGroups.EnableHeadersVisualStyles = false;
            this.dataGridViewGroups.GridColor = System.Drawing.Color.FromArgb(240, 226, 210);
            this.dataGridViewGroups.Location = new System.Drawing.Point(14, 14);
            this.dataGridViewGroups.MultiSelect = false;
            this.dataGridViewGroups.Name = "dataGridViewGroups";
            this.dataGridViewGroups.ReadOnly = true;
            this.dataGridViewGroups.RowHeadersVisible = false;
            this.dataGridViewGroups.RowTemplate.Height = 30;
            this.dataGridViewGroups.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridViewGroups.Size = new System.Drawing.Size(940, 372);
            this.dataGridViewGroups.TabIndex = 0;
            this.dataGridViewGroups.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridViewGroups_CellDoubleClick);
            // 
            // colGroupId
            // 
            this.colGroupId.FillWeight = 6F;
            this.colGroupId.HeaderText = "№";
            this.colGroupId.Name = "colGroupId";
            this.colGroupId.ReadOnly = true;
            // 
            // colGroupName
            // 
            this.colGroupName.FillWeight = 20F;
            this.colGroupName.HeaderText = "Название";
            this.colGroupName.Name = "colGroupName";
            this.colGroupName.ReadOnly = true;
            // 
            // colGroupAge
            // 
            this.colGroupAge.FillWeight = 25F;
            this.colGroupAge.HeaderText = "Возрастная категория";
            this.colGroupAge.Name = "colGroupAge";
            this.colGroupAge.ReadOnly = true;
            // 
            // colGroupTeacher
            // 
            this.colGroupTeacher.FillWeight = 30F;
            this.colGroupTeacher.HeaderText = "Воспитатель";
            this.colGroupTeacher.Name = "colGroupTeacher";
            this.colGroupTeacher.ReadOnly = true;
            // 
            // colGroupCount
            // 
            this.colGroupCount.FillWeight = 15F;
            this.colGroupCount.HeaderText = "Детей / мест";
            this.colGroupCount.Name = "colGroupCount";
            this.colGroupCount.ReadOnly = true;
            // 
            // dataGridViewTeachers
            // 
            this.dataGridViewTeachers.AllowUserToAddRows = false;
            this.dataGridViewTeachers.AllowUserToDeleteRows = false;
            this.dataGridViewTeachers.AllowUserToResizeRows = false;
            styleTeachersAlt.BackColor = System.Drawing.Color.FromArgb(255, 248, 240);
            this.dataGridViewTeachers.AlternatingRowsDefaultCellStyle = styleTeachersAlt;
            this.dataGridViewTeachers.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridViewTeachers.BackgroundColor = System.Drawing.Color.White;
            this.dataGridViewTeachers.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dataGridViewTeachers.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.dataGridViewTeachers.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            styleTeachersHead.BackColor = System.Drawing.Color.FromArgb(255, 232, 209);
            styleTeachersHead.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            styleTeachersHead.ForeColor = System.Drawing.Color.FromArgb(52, 58, 64);
            styleTeachersHead.SelectionBackColor = System.Drawing.Color.FromArgb(255, 232, 209);
            styleTeachersHead.SelectionForeColor = System.Drawing.Color.FromArgb(52, 58, 64);
            styleTeachersHead.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridViewTeachers.ColumnHeadersDefaultCellStyle = styleTeachersHead;
            this.dataGridViewTeachers.ColumnHeadersHeight = 40;
            this.dataGridViewTeachers.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.dataGridViewTeachers.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.colTeacherId,
            this.colTeacherFio,
            this.colTeacherPhone,
            this.colTeacherExp,
            this.colTeacherGroup});
            styleTeachersCell.BackColor = System.Drawing.Color.White;
            styleTeachersCell.Font = new System.Drawing.Font("Segoe UI", 10F);
            styleTeachersCell.ForeColor = System.Drawing.Color.FromArgb(52, 58, 64);
            styleTeachersCell.Padding = new System.Windows.Forms.Padding(4, 0, 0, 0);
            styleTeachersCell.SelectionBackColor = System.Drawing.Color.FromArgb(255, 209, 163);
            styleTeachersCell.SelectionForeColor = System.Drawing.Color.FromArgb(52, 58, 64);
            this.dataGridViewTeachers.DefaultCellStyle = styleTeachersCell;
            this.dataGridViewTeachers.EnableHeadersVisualStyles = false;
            this.dataGridViewTeachers.GridColor = System.Drawing.Color.FromArgb(240, 226, 210);
            this.dataGridViewTeachers.Location = new System.Drawing.Point(14, 14);
            this.dataGridViewTeachers.MultiSelect = false;
            this.dataGridViewTeachers.Name = "dataGridViewTeachers";
            this.dataGridViewTeachers.ReadOnly = true;
            this.dataGridViewTeachers.RowHeadersVisible = false;
            this.dataGridViewTeachers.RowTemplate.Height = 30;
            this.dataGridViewTeachers.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridViewTeachers.Size = new System.Drawing.Size(940, 372);
            this.dataGridViewTeachers.TabIndex = 0;
            this.dataGridViewTeachers.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridViewTeachers_CellDoubleClick);
            // 
            // colTeacherId
            // 
            this.colTeacherId.FillWeight = 6F;
            this.colTeacherId.HeaderText = "№";
            this.colTeacherId.Name = "colTeacherId";
            this.colTeacherId.ReadOnly = true;
            // 
            // colTeacherFio
            // 
            this.colTeacherFio.FillWeight = 35F;
            this.colTeacherFio.HeaderText = "ФИО воспитателя";
            this.colTeacherFio.Name = "colTeacherFio";
            this.colTeacherFio.ReadOnly = true;
            // 
            // colTeacherPhone
            // 
            this.colTeacherPhone.FillWeight = 20F;
            this.colTeacherPhone.HeaderText = "Телефон";
            this.colTeacherPhone.Name = "colTeacherPhone";
            this.colTeacherPhone.ReadOnly = true;
            // 
            // colTeacherExp
            // 
            this.colTeacherExp.FillWeight = 12F;
            this.colTeacherExp.HeaderText = "Стаж, лет";
            this.colTeacherExp.Name = "colTeacherExp";
            this.colTeacherExp.ReadOnly = true;
            // 
            // colTeacherGroup
            // 
            this.colTeacherGroup.FillWeight = 20F;
            this.colTeacherGroup.HeaderText = "Группа";
            this.colTeacherGroup.Name = "colTeacherGroup";
            this.colTeacherGroup.ReadOnly = true;
            // 
            // dataGridViewReport
            // 
            this.dataGridViewReport.AllowUserToAddRows = false;
            this.dataGridViewReport.AllowUserToDeleteRows = false;
            this.dataGridViewReport.AllowUserToResizeRows = false;
            styleReportAlt.BackColor = System.Drawing.Color.FromArgb(255, 248, 240);
            this.dataGridViewReport.AlternatingRowsDefaultCellStyle = styleReportAlt;
            this.dataGridViewReport.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridViewReport.BackgroundColor = System.Drawing.Color.White;
            this.dataGridViewReport.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dataGridViewReport.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.dataGridViewReport.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            styleReportHead.BackColor = System.Drawing.Color.FromArgb(255, 232, 209);
            styleReportHead.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            styleReportHead.ForeColor = System.Drawing.Color.FromArgb(52, 58, 64);
            styleReportHead.SelectionBackColor = System.Drawing.Color.FromArgb(255, 232, 209);
            styleReportHead.SelectionForeColor = System.Drawing.Color.FromArgb(52, 58, 64);
            styleReportHead.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridViewReport.ColumnHeadersDefaultCellStyle = styleReportHead;
            this.dataGridViewReport.ColumnHeadersHeight = 40;
            this.dataGridViewReport.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.dataGridViewReport.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.colRepGroup,
            this.colRepTeacher,
            this.colRepCount,
            this.colRepMax,
            this.colRepFree,
            this.colRepPercent});
            styleReportCell.BackColor = System.Drawing.Color.White;
            styleReportCell.Font = new System.Drawing.Font("Segoe UI", 10F);
            styleReportCell.ForeColor = System.Drawing.Color.FromArgb(52, 58, 64);
            styleReportCell.Padding = new System.Windows.Forms.Padding(4, 0, 0, 0);
            styleReportCell.SelectionBackColor = System.Drawing.Color.FromArgb(255, 209, 163);
            styleReportCell.SelectionForeColor = System.Drawing.Color.FromArgb(52, 58, 64);
            this.dataGridViewReport.DefaultCellStyle = styleReportCell;
            this.dataGridViewReport.EnableHeadersVisualStyles = false;
            this.dataGridViewReport.GridColor = System.Drawing.Color.FromArgb(240, 226, 210);
            this.dataGridViewReport.Location = new System.Drawing.Point(14, 14);
            this.dataGridViewReport.MultiSelect = false;
            this.dataGridViewReport.Name = "dataGridViewReport";
            this.dataGridViewReport.ReadOnly = true;
            this.dataGridViewReport.RowHeadersVisible = false;
            this.dataGridViewReport.RowTemplate.Height = 30;
            this.dataGridViewReport.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridViewReport.Size = new System.Drawing.Size(940, 352);
            this.dataGridViewReport.TabIndex = 0;
            // 
            // colRepGroup
            // 
            this.colRepGroup.FillWeight = 18F;
            this.colRepGroup.HeaderText = "Группа";
            this.colRepGroup.Name = "colRepGroup";
            this.colRepGroup.ReadOnly = true;
            // 
            // colRepTeacher
            // 
            this.colRepTeacher.FillWeight = 32F;
            this.colRepTeacher.HeaderText = "Воспитатель";
            this.colRepTeacher.Name = "colRepTeacher";
            this.colRepTeacher.ReadOnly = true;
            // 
            // colRepCount
            // 
            this.colRepCount.FillWeight = 10F;
            this.colRepCount.HeaderText = "Детей";
            this.colRepCount.Name = "colRepCount";
            this.colRepCount.ReadOnly = true;
            // 
            // colRepMax
            // 
            this.colRepMax.FillWeight = 10F;
            this.colRepMax.HeaderText = "Мест";
            this.colRepMax.Name = "colRepMax";
            this.colRepMax.ReadOnly = true;
            // 
            // colRepFree
            // 
            this.colRepFree.FillWeight = 12F;
            this.colRepFree.HeaderText = "Свободно";
            this.colRepFree.Name = "colRepFree";
            this.colRepFree.ReadOnly = true;
            // 
            // colRepPercent
            // 
            this.colRepPercent.FillWeight = 15F;
            this.colRepPercent.HeaderText = "Заполненность";
            this.colRepPercent.Name = "colRepPercent";
            this.colRepPercent.ReadOnly = true;
            // 
            // buttonAddChild
            // 
            this.buttonAddChild.BackColor = System.Drawing.Color.FromArgb(42, 157, 143);
            this.buttonAddChild.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttonAddChild.FlatAppearance.BorderSize = 0;
            this.buttonAddChild.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonAddChild.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.buttonAddChild.ForeColor = System.Drawing.Color.White;
            this.buttonAddChild.Location = new System.Drawing.Point(14, 396);
            this.buttonAddChild.Name = "buttonAddChild";
            this.buttonAddChild.Size = new System.Drawing.Size(130, 36);
            this.buttonAddChild.TabIndex = 1;
            this.buttonAddChild.Text = "Добавить";
            this.buttonAddChild.UseVisualStyleBackColor = false;
            this.buttonAddChild.Click += new System.EventHandler(this.buttonAddChild_Click);
            // 
            // buttonEditChild
            // 
            this.buttonEditChild.BackColor = System.Drawing.Color.FromArgb(69, 123, 157);
            this.buttonEditChild.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttonEditChild.FlatAppearance.BorderSize = 0;
            this.buttonEditChild.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonEditChild.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.buttonEditChild.ForeColor = System.Drawing.Color.White;
            this.buttonEditChild.Location = new System.Drawing.Point(156, 396);
            this.buttonEditChild.Name = "buttonEditChild";
            this.buttonEditChild.Size = new System.Drawing.Size(130, 36);
            this.buttonEditChild.TabIndex = 2;
            this.buttonEditChild.Text = "Изменить";
            this.buttonEditChild.UseVisualStyleBackColor = false;
            this.buttonEditChild.Click += new System.EventHandler(this.buttonEditChild_Click);
            // 
            // buttonDeleteChild
            // 
            this.buttonDeleteChild.BackColor = System.Drawing.Color.FromArgb(230, 57, 70);
            this.buttonDeleteChild.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttonDeleteChild.FlatAppearance.BorderSize = 0;
            this.buttonDeleteChild.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonDeleteChild.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.buttonDeleteChild.ForeColor = System.Drawing.Color.White;
            this.buttonDeleteChild.Location = new System.Drawing.Point(298, 396);
            this.buttonDeleteChild.Name = "buttonDeleteChild";
            this.buttonDeleteChild.Size = new System.Drawing.Size(130, 36);
            this.buttonDeleteChild.TabIndex = 3;
            this.buttonDeleteChild.Text = "Удалить";
            this.buttonDeleteChild.UseVisualStyleBackColor = false;
            this.buttonDeleteChild.Click += new System.EventHandler(this.buttonDeleteChild_Click);
            // 
            // buttonAddGroup
            // 
            this.buttonAddGroup.BackColor = System.Drawing.Color.FromArgb(42, 157, 143);
            this.buttonAddGroup.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttonAddGroup.FlatAppearance.BorderSize = 0;
            this.buttonAddGroup.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonAddGroup.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.buttonAddGroup.ForeColor = System.Drawing.Color.White;
            this.buttonAddGroup.Location = new System.Drawing.Point(14, 396);
            this.buttonAddGroup.Name = "buttonAddGroup";
            this.buttonAddGroup.Size = new System.Drawing.Size(130, 36);
            this.buttonAddGroup.TabIndex = 1;
            this.buttonAddGroup.Text = "Добавить";
            this.buttonAddGroup.UseVisualStyleBackColor = false;
            this.buttonAddGroup.Click += new System.EventHandler(this.buttonAddGroup_Click);
            // 
            // buttonEditGroup
            // 
            this.buttonEditGroup.BackColor = System.Drawing.Color.FromArgb(69, 123, 157);
            this.buttonEditGroup.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttonEditGroup.FlatAppearance.BorderSize = 0;
            this.buttonEditGroup.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonEditGroup.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.buttonEditGroup.ForeColor = System.Drawing.Color.White;
            this.buttonEditGroup.Location = new System.Drawing.Point(156, 396);
            this.buttonEditGroup.Name = "buttonEditGroup";
            this.buttonEditGroup.Size = new System.Drawing.Size(130, 36);
            this.buttonEditGroup.TabIndex = 2;
            this.buttonEditGroup.Text = "Изменить";
            this.buttonEditGroup.UseVisualStyleBackColor = false;
            this.buttonEditGroup.Click += new System.EventHandler(this.buttonEditGroup_Click);
            // 
            // buttonDeleteGroup
            // 
            this.buttonDeleteGroup.BackColor = System.Drawing.Color.FromArgb(230, 57, 70);
            this.buttonDeleteGroup.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttonDeleteGroup.FlatAppearance.BorderSize = 0;
            this.buttonDeleteGroup.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonDeleteGroup.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.buttonDeleteGroup.ForeColor = System.Drawing.Color.White;
            this.buttonDeleteGroup.Location = new System.Drawing.Point(298, 396);
            this.buttonDeleteGroup.Name = "buttonDeleteGroup";
            this.buttonDeleteGroup.Size = new System.Drawing.Size(130, 36);
            this.buttonDeleteGroup.TabIndex = 3;
            this.buttonDeleteGroup.Text = "Удалить";
            this.buttonDeleteGroup.UseVisualStyleBackColor = false;
            this.buttonDeleteGroup.Click += new System.EventHandler(this.buttonDeleteGroup_Click);
            // 
            // buttonAddTeacher
            // 
            this.buttonAddTeacher.BackColor = System.Drawing.Color.FromArgb(42, 157, 143);
            this.buttonAddTeacher.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttonAddTeacher.FlatAppearance.BorderSize = 0;
            this.buttonAddTeacher.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonAddTeacher.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.buttonAddTeacher.ForeColor = System.Drawing.Color.White;
            this.buttonAddTeacher.Location = new System.Drawing.Point(14, 396);
            this.buttonAddTeacher.Name = "buttonAddTeacher";
            this.buttonAddTeacher.Size = new System.Drawing.Size(130, 36);
            this.buttonAddTeacher.TabIndex = 1;
            this.buttonAddTeacher.Text = "Добавить";
            this.buttonAddTeacher.UseVisualStyleBackColor = false;
            this.buttonAddTeacher.Click += new System.EventHandler(this.buttonAddTeacher_Click);
            // 
            // buttonEditTeacher
            // 
            this.buttonEditTeacher.BackColor = System.Drawing.Color.FromArgb(69, 123, 157);
            this.buttonEditTeacher.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttonEditTeacher.FlatAppearance.BorderSize = 0;
            this.buttonEditTeacher.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonEditTeacher.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.buttonEditTeacher.ForeColor = System.Drawing.Color.White;
            this.buttonEditTeacher.Location = new System.Drawing.Point(156, 396);
            this.buttonEditTeacher.Name = "buttonEditTeacher";
            this.buttonEditTeacher.Size = new System.Drawing.Size(130, 36);
            this.buttonEditTeacher.TabIndex = 2;
            this.buttonEditTeacher.Text = "Изменить";
            this.buttonEditTeacher.UseVisualStyleBackColor = false;
            this.buttonEditTeacher.Click += new System.EventHandler(this.buttonEditTeacher_Click);
            // 
            // buttonDeleteTeacher
            // 
            this.buttonDeleteTeacher.BackColor = System.Drawing.Color.FromArgb(230, 57, 70);
            this.buttonDeleteTeacher.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttonDeleteTeacher.FlatAppearance.BorderSize = 0;
            this.buttonDeleteTeacher.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonDeleteTeacher.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.buttonDeleteTeacher.ForeColor = System.Drawing.Color.White;
            this.buttonDeleteTeacher.Location = new System.Drawing.Point(298, 396);
            this.buttonDeleteTeacher.Name = "buttonDeleteTeacher";
            this.buttonDeleteTeacher.Size = new System.Drawing.Size(130, 36);
            this.buttonDeleteTeacher.TabIndex = 3;
            this.buttonDeleteTeacher.Text = "Удалить";
            this.buttonDeleteTeacher.UseVisualStyleBackColor = false;
            this.buttonDeleteTeacher.Click += new System.EventHandler(this.buttonDeleteTeacher_Click);
            // 
            // labelSearch
            // 
            this.labelSearch.AutoSize = true;
            this.labelSearch.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.labelSearch.ForeColor = System.Drawing.Color.FromArgb(52, 58, 64);
            this.labelSearch.Location = new System.Drawing.Point(12, 18);
            this.labelSearch.Name = "labelSearch";
            this.labelSearch.Text = "Поиск по ФИО:";
            // 
            // textBoxSearch
            // 
            this.textBoxSearch.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textBoxSearch.Font = new System.Drawing.Font("Segoe UI", 11F);
            this.textBoxSearch.Location = new System.Drawing.Point(125, 14);
            this.textBoxSearch.Name = "textBoxSearch";
            this.textBoxSearch.Size = new System.Drawing.Size(260, 27);
            this.textBoxSearch.TabIndex = 1;
            this.textBoxSearch.TextChanged += new System.EventHandler(this.textBoxSearch_TextChanged);
            // 
            // labelFilterGroup
            // 
            this.labelFilterGroup.AutoSize = true;
            this.labelFilterGroup.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.labelFilterGroup.ForeColor = System.Drawing.Color.FromArgb(52, 58, 64);
            this.labelFilterGroup.Location = new System.Drawing.Point(410, 18);
            this.labelFilterGroup.Name = "labelFilterGroup";
            this.labelFilterGroup.Text = "Группа:";
            // 
            // comboBoxFilterGroup
            // 
            this.comboBoxFilterGroup.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxFilterGroup.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.comboBoxFilterGroup.Font = new System.Drawing.Font("Segoe UI", 11F);
            this.comboBoxFilterGroup.Location = new System.Drawing.Point(472, 14);
            this.comboBoxFilterGroup.Name = "comboBoxFilterGroup";
            this.comboBoxFilterGroup.Size = new System.Drawing.Size(220, 28);
            this.comboBoxFilterGroup.SelectedIndexChanged += new System.EventHandler(this.comboBoxFilterGroup_SelectedIndexChanged);
            // 
            // labelReportTotal
            // 
            this.labelReportTotal.BackColor = System.Drawing.Color.FromArgb(255, 232, 209);
            this.labelReportTotal.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Bold);
            this.labelReportTotal.ForeColor = System.Drawing.Color.FromArgb(52, 58, 64);
            this.labelReportTotal.Location = new System.Drawing.Point(12, 380);
            this.labelReportTotal.Name = "labelReportTotal";
            this.labelReportTotal.Size = new System.Drawing.Size(940, 40);
            this.labelReportTotal.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.labelReportTotal.Text = "Всего детей:";
            this.labelReportTotal.Padding = new System.Windows.Forms.Padding(10, 0, 0, 0);
            // 
            // labelStatus
            // 
            this.labelStatus.AutoSize = true;
            this.labelStatus.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.labelStatus.ForeColor = System.Drawing.Color.FromArgb(52, 58, 64);
            this.labelStatus.Location = new System.Drawing.Point(14, 582);
            this.labelStatus.Name = "labelStatus";
            this.labelStatus.Text = "Детей: 0";
            // 
            // buttonExit
            // 
            this.buttonExit.BackColor = System.Drawing.Color.FromArgb(233, 236, 239);
            this.buttonExit.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttonExit.FlatAppearance.BorderSize = 0;
            this.buttonExit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonExit.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.buttonExit.ForeColor = System.Drawing.Color.FromArgb(52, 58, 64);
            this.buttonExit.Location = new System.Drawing.Point(858, 574);
            this.buttonExit.Name = "buttonExit";
            this.buttonExit.Size = new System.Drawing.Size(130, 36);
            this.buttonExit.TabIndex = 2;
            this.buttonExit.Text = "Выход";
            this.buttonExit.UseVisualStyleBackColor = false;
            this.buttonExit.Click += new System.EventHandler(this.buttonExit_Click);
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(255, 250, 244);
            this.ClientSize = new System.Drawing.Size(1000, 624);
            this.Controls.Add(this.buttonExit);
            this.Controls.Add(this.labelStatus);
            this.Controls.Add(this.tabControlMain);
            this.Controls.Add(this.panelHeader);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "Form2";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Детский сад — учёт детей и групп";
            this.Load += new System.EventHandler(this.Form2_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewChildren)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewGroups)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewTeachers)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewReport)).EndInit();
            this.panelHeader.ResumeLayout(false);
            this.panelHeader.PerformLayout();
            this.tabControlMain.ResumeLayout(false);
            this.tabPageChildren.ResumeLayout(false);
            this.tabPageChildren.PerformLayout();
            this.tabPageGroups.ResumeLayout(false);
            this.tabPageGroups.PerformLayout();
            this.tabPageTeachers.ResumeLayout(false);
            this.tabPageTeachers.PerformLayout();
            this.tabPageReport.ResumeLayout(false);
            this.tabPageReport.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();
        }

        #endregion

        private System.Windows.Forms.Panel panelHeader;
        private System.Windows.Forms.Label labelTitle;
        private System.Windows.Forms.Label labelSubtitle;
        private System.Windows.Forms.Label labelUser;
        private System.Windows.Forms.TabControl tabControlMain;
        private System.Windows.Forms.TabPage tabPageChildren;
        private System.Windows.Forms.TabPage tabPageGroups;
        private System.Windows.Forms.TabPage tabPageTeachers;
        private System.Windows.Forms.TabPage tabPageReport;
        private System.Windows.Forms.DataGridView dataGridViewChildren;
        private System.Windows.Forms.DataGridViewTextBoxColumn colChildId;
        private System.Windows.Forms.DataGridViewTextBoxColumn colChildFio;
        private System.Windows.Forms.DataGridViewTextBoxColumn colChildBirth;
        private System.Windows.Forms.DataGridViewTextBoxColumn colChildAge;
        private System.Windows.Forms.DataGridViewTextBoxColumn colChildGender;
        private System.Windows.Forms.DataGridViewTextBoxColumn colChildGroup;
        private System.Windows.Forms.DataGridViewTextBoxColumn colChildParent;
        private System.Windows.Forms.DataGridViewTextBoxColumn colChildPhone;
        private System.Windows.Forms.DataGridView dataGridViewGroups;
        private System.Windows.Forms.DataGridViewTextBoxColumn colGroupId;
        private System.Windows.Forms.DataGridViewTextBoxColumn colGroupName;
        private System.Windows.Forms.DataGridViewTextBoxColumn colGroupAge;
        private System.Windows.Forms.DataGridViewTextBoxColumn colGroupTeacher;
        private System.Windows.Forms.DataGridViewTextBoxColumn colGroupCount;
        private System.Windows.Forms.DataGridView dataGridViewTeachers;
        private System.Windows.Forms.DataGridViewTextBoxColumn colTeacherId;
        private System.Windows.Forms.DataGridViewTextBoxColumn colTeacherFio;
        private System.Windows.Forms.DataGridViewTextBoxColumn colTeacherPhone;
        private System.Windows.Forms.DataGridViewTextBoxColumn colTeacherExp;
        private System.Windows.Forms.DataGridViewTextBoxColumn colTeacherGroup;
        private System.Windows.Forms.DataGridView dataGridViewReport;
        private System.Windows.Forms.DataGridViewTextBoxColumn colRepGroup;
        private System.Windows.Forms.DataGridViewTextBoxColumn colRepTeacher;
        private System.Windows.Forms.DataGridViewTextBoxColumn colRepCount;
        private System.Windows.Forms.DataGridViewTextBoxColumn colRepMax;
        private System.Windows.Forms.DataGridViewTextBoxColumn colRepFree;
        private System.Windows.Forms.DataGridViewTextBoxColumn colRepPercent;
        private System.Windows.Forms.Button buttonAddChild;
        private System.Windows.Forms.Button buttonEditChild;
        private System.Windows.Forms.Button buttonDeleteChild;
        private System.Windows.Forms.Button buttonAddGroup;
        private System.Windows.Forms.Button buttonEditGroup;
        private System.Windows.Forms.Button buttonDeleteGroup;
        private System.Windows.Forms.Button buttonAddTeacher;
        private System.Windows.Forms.Button buttonEditTeacher;
        private System.Windows.Forms.Button buttonDeleteTeacher;
        private System.Windows.Forms.Label labelSearch;
        private System.Windows.Forms.TextBox textBoxSearch;
        private System.Windows.Forms.Label labelFilterGroup;
        private System.Windows.Forms.ComboBox comboBoxFilterGroup;
        private System.Windows.Forms.Label labelReportTotal;
        private System.Windows.Forms.Label labelStatus;
        private System.Windows.Forms.Button buttonExit;
    }
}
