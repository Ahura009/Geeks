namespace University.Ui.Forms.FrmStudents
{
    partial class FrmStudentGrade
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

        #region Windows Form Designer generated code

        private void InitializeComponent()
        {
            components = new System.ComponentModel.Container();
            toolStripMain = new ToolStrip();
            toolStripLabel1 = new ToolStripLabel();
            pnlMain = new Panel();
            pnlGrid = new Panel();
            dataGridGrades = new DataGridView();
            pnlForm = new Panel();
            tableLayoutMain = new TableLayoutPanel();
            lblModule = new Label();
            cmbModule = new ComboBox();
            lblScore = new Label();
            nudScore = new NumericUpDown();
            lblWeight = new Label();
            nudWeight = new NumericUpDown();
            lblDate = new Label();
            dtpDate = new DateTimePicker();
            btnAddGrade = new Button();
            btnAddResit = new Button();
            lblInfo = new Label();
            errorProvider1 = new ErrorProvider(components);
            toolStripMain.SuspendLayout();
            pnlMain.SuspendLayout();
            pnlGrid.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridGrades).BeginInit();
            pnlForm.SuspendLayout();
            tableLayoutMain.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)nudScore).BeginInit();
            ((System.ComponentModel.ISupportInitialize)nudWeight).BeginInit();
            ((System.ComponentModel.ISupportInitialize)errorProvider1).BeginInit();
            SuspendLayout();
            // 
            // toolStripMain
            // 
            toolStripMain.Items.AddRange(new ToolStripItem[] { toolStripLabel1 });
            toolStripMain.Location = new Point(0, 0);
            toolStripMain.Name = "toolStripMain";
            toolStripMain.RightToLeft = RightToLeft.Yes;
            toolStripMain.Size = new Size(900, 25);
            toolStripMain.TabIndex = 0;
            // 
            // toolStripLabel1
            // 
            toolStripLabel1.Name = "toolStripLabel1";
            toolStripLabel1.Size = new Size(77, 22);
            toolStripLabel1.Text = "مدیریت نمرات";
            // 
            // pnlMain
            // 
            pnlMain.Controls.Add(pnlGrid);
            pnlMain.Controls.Add(pnlForm);
            pnlMain.Dock = DockStyle.Fill;
            pnlMain.Location = new Point(0, 25);
            pnlMain.Name = "pnlMain";
            pnlMain.Padding = new Padding(20);
            pnlMain.RightToLeft = RightToLeft.Yes;
            pnlMain.Size = new Size(900, 699);
            pnlMain.TabIndex = 1;
            // 
            // pnlGrid
            // 
            pnlGrid.Controls.Add(dataGridGrades);
            pnlGrid.Dock = DockStyle.Fill;
            pnlGrid.Location = new Point(20, 310);
            pnlGrid.Name = "pnlGrid";
            pnlGrid.Padding = new Padding(0, 10, 0, 0);
            pnlGrid.Size = new Size(860, 369);
            pnlGrid.TabIndex = 0;
            // 
            // dataGridGrades
            // 
            dataGridGrades.AllowUserToAddRows = false;
            dataGridGrades.AllowUserToDeleteRows = false;
            dataGridGrades.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataGridGrades.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridGrades.Dock = DockStyle.Fill;
            dataGridGrades.Location = new Point(0, 10);
            dataGridGrades.MultiSelect = false;
            dataGridGrades.Name = "dataGridGrades";
            dataGridGrades.ReadOnly = true;
            dataGridGrades.RightToLeft = RightToLeft.Yes;
            dataGridGrades.RowHeadersWidth = 60;
            dataGridGrades.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dataGridGrades.Size = new Size(860, 359);
            dataGridGrades.TabIndex = 0;
            // 
            // pnlForm
            // 
            pnlForm.AutoSize = true;
            pnlForm.Controls.Add(tableLayoutMain);
            pnlForm.Controls.Add(lblInfo);
            pnlForm.Dock = DockStyle.Top;
            pnlForm.Location = new Point(20, 20);
            pnlForm.Name = "pnlForm";
            pnlForm.Padding = new Padding(0, 0, 0, 10);
            pnlForm.RightToLeft = RightToLeft.Yes;
            pnlForm.Size = new Size(860, 290);
            pnlForm.TabIndex = 1;
            // 
            // tableLayoutMain
            // 
            tableLayoutMain.ColumnCount = 2;
            tableLayoutMain.ColumnStyles.Add(new ColumnStyle());
            tableLayoutMain.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
            tableLayoutMain.Controls.Add(lblModule, 0, 0);
            tableLayoutMain.Controls.Add(cmbModule, 1, 0);
            tableLayoutMain.Controls.Add(lblScore, 0, 1);
            tableLayoutMain.Controls.Add(nudScore, 1, 1);
            tableLayoutMain.Controls.Add(lblWeight, 0, 2);
            tableLayoutMain.Controls.Add(nudWeight, 1, 2);
            tableLayoutMain.Controls.Add(lblDate, 0, 3);
            tableLayoutMain.Controls.Add(dtpDate, 1, 3);
            tableLayoutMain.Controls.Add(btnAddGrade, 1, 4);
            tableLayoutMain.Controls.Add(btnAddResit, 1, 5);
            tableLayoutMain.Dock = DockStyle.Top;
            tableLayoutMain.Location = new Point(0, 30);
            tableLayoutMain.Name = "tableLayoutMain";
            tableLayoutMain.Padding = new Padding(10);
            tableLayoutMain.RowCount = 5;
            tableLayoutMain.RowStyles.Add(new RowStyle(SizeType.Absolute, 40F));
            tableLayoutMain.RowStyles.Add(new RowStyle(SizeType.Absolute, 40F));
            tableLayoutMain.RowStyles.Add(new RowStyle(SizeType.Absolute, 40F));
            tableLayoutMain.RowStyles.Add(new RowStyle(SizeType.Absolute, 40F));
            tableLayoutMain.RowStyles.Add(new RowStyle(SizeType.Absolute, 40F));
            tableLayoutMain.RowStyles.Add(new RowStyle(SizeType.Absolute, 40F));
            tableLayoutMain.RowStyles.Add(new RowStyle(SizeType.Absolute, 20F));
            tableLayoutMain.Size = new Size(860, 250);
            tableLayoutMain.TabIndex = 0;
            // 
            // lblModule
            // 
            lblModule.Anchor = AnchorStyles.Right;
            lblModule.AutoSize = true;
            lblModule.Font = new Font("Tahoma", 9.5F, FontStyle.Bold);
            lblModule.Location = new Point(774, 22);
            lblModule.Name = "lblModule";
            lblModule.Size = new Size(47, 16);
            lblModule.TabIndex = 2;
            lblModule.Text = "ماژول:";
            // 
            // cmbModule
            // 
            cmbModule.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            cmbModule.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbModule.Location = new Point(13, 18);
            cmbModule.Name = "cmbModule";
            cmbModule.Size = new Size(755, 24);
            cmbModule.TabIndex = 3;
            // 
            // lblScore
            // 
            lblScore.Anchor = AnchorStyles.Right;
            lblScore.AutoSize = true;
            lblScore.Font = new Font("Tahoma", 9.5F, FontStyle.Bold);
            lblScore.Location = new Point(774, 62);
            lblScore.Name = "lblScore";
            lblScore.Size = new Size(40, 16);
            lblScore.TabIndex = 4;
            lblScore.Text = "نمره:";
            // 
            // nudScore
            // 
            nudScore.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            nudScore.Location = new Point(13, 58);
            nudScore.Name = "nudScore";
            nudScore.Size = new Size(755, 23);
            nudScore.TabIndex = 5;
            // 
            // lblWeight
            // 
            lblWeight.Anchor = AnchorStyles.Right;
            lblWeight.AutoSize = true;
            lblWeight.Font = new Font("Tahoma", 9.5F, FontStyle.Bold);
            lblWeight.Location = new Point(774, 102);
            lblWeight.Name = "lblWeight";
            lblWeight.Size = new Size(73, 16);
            lblWeight.TabIndex = 6;
            lblWeight.Text = "وزن (0-1):";
            // 
            // nudWeight
            // 
            nudWeight.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            nudWeight.DecimalPlaces = 2;
            nudWeight.Increment = new decimal(new int[] { 5, 0, 0, 131072 });
            nudWeight.Location = new Point(13, 98);
            nudWeight.Maximum = new decimal(new int[] { 1, 0, 0, 0 });
            nudWeight.Name = "nudWeight";
            nudWeight.Size = new Size(755, 23);
            nudWeight.TabIndex = 7;
            // 
            // lblDate
            // 
            lblDate.Anchor = AnchorStyles.Right;
            lblDate.AutoSize = true;
            lblDate.Font = new Font("Tahoma", 9.5F, FontStyle.Bold);
            lblDate.Location = new Point(774, 142);
            lblDate.Name = "lblDate";
            lblDate.Size = new Size(40, 16);
            lblDate.TabIndex = 8;
            lblDate.Text = "تاریخ:";
            // 
            // dtpDate
            // 
            dtpDate.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            dtpDate.CustomFormat = "yyyy-MM-dd HH:mm";
            dtpDate.Format = DateTimePickerFormat.Custom;
            dtpDate.Location = new Point(13, 138);
            dtpDate.Name = "dtpDate";
            dtpDate.Size = new Size(755, 23);
            dtpDate.TabIndex = 9;
            // 
            // btnAddGrade
            // 
            btnAddGrade.Dock = DockStyle.Fill;
            btnAddGrade.Font = new Font("Tahoma", 9.5F);
            btnAddGrade.Location = new Point(13, 173);
            btnAddGrade.Name = "btnAddGrade";
            btnAddGrade.Size = new Size(755, 34);
            btnAddGrade.TabIndex = 10;
            btnAddGrade.Text = "ثبت نمره";
            btnAddGrade.Click += BtnAddGrade_Click;
            // 
            // btnAddResit
            // 
            btnAddResit.Dock = DockStyle.Fill;
            btnAddResit.Font = new Font("Tahoma", 9.5F);
            btnAddResit.Location = new Point(13, 213);
            btnAddResit.Name = "btnAddResit";
            btnAddResit.Size = new Size(755, 34);
            btnAddResit.TabIndex = 11;
            btnAddResit.Text = "ثبت نمره رسیت";
            btnAddResit.Click += btnAddResit_Click_1;
            // 
            // lblInfo
            // 
            lblInfo.Dock = DockStyle.Top;
            lblInfo.Font = new Font("Tahoma", 9.5F, FontStyle.Bold);
            lblInfo.Location = new Point(0, 0);
            lblInfo.Name = "lblInfo";
            lblInfo.Size = new Size(860, 30);
            lblInfo.TabIndex = 1;
            lblInfo.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // errorProvider1
            // 
            errorProvider1.ContainerControl = this;
            // 
            // FrmStudentGrade
            // 
            AutoScaleDimensions = new SizeF(7F, 16F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(900, 724);
            Controls.Add(pnlMain);
            Controls.Add(toolStripMain);
            Font = new Font("Tahoma", 9.5F);
            Name = "FrmStudentGrade";
            RightToLeft = RightToLeft.Yes;
            RightToLeftLayout = true;
            StartPosition = FormStartPosition.CenterScreen;
            Text = "مدیریت نمرات دانشجو";
            toolStripMain.ResumeLayout(false);
            toolStripMain.PerformLayout();
            pnlMain.ResumeLayout(false);
            pnlMain.PerformLayout();
            pnlGrid.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dataGridGrades).EndInit();
            pnlForm.ResumeLayout(false);
            tableLayoutMain.ResumeLayout(false);
            tableLayoutMain.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)nudScore).EndInit();
            ((System.ComponentModel.ISupportInitialize)nudWeight).EndInit();
            ((System.ComponentModel.ISupportInitialize)errorProvider1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private ToolStrip toolStripMain;
        private ToolStripLabel toolStripLabel1;
        private Panel pnlMain;
        private Panel pnlForm;
        private TableLayoutPanel tableLayoutMain;
        private Label lblModule;
        private ComboBox cmbModule;
        private Label lblScore;
        private NumericUpDown nudScore;
        private Label lblWeight;
        private NumericUpDown nudWeight;
        private Label lblDate;
        private DateTimePicker dtpDate;
        private Button btnAddGrade;
        private Button btnAddResit;
        private Panel pnlGrid;
        private DataGridView dataGridGrades;
        private ErrorProvider errorProvider1;
        private Label lblInfo;
    }
}
