namespace University.Ui.Forms.FrmUniversities
{
    partial class FrmUniversityCode
    {
        private System.ComponentModel.IContainer components = null;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
                components.Dispose();
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        private void InitializeComponent()
        {
            components = new System.ComponentModel.Container();
            errorProvider1 = new ErrorProvider(components);
            toolStripMain = new ToolStrip();
            toolStripLabel1 = new ToolStripLabel();
            pnlMain = new Panel();
            grpValidate = new GroupBox();
            txtInput = new TextBox();
            btnValidate = new Button();
            txtResult = new TextBox();
            grpGenerate = new GroupBox();
            label5 = new Label();
            label4 = new Label();
            label3 = new Label();
            label2 = new Label();
            label1 = new Label();
            cmbType = new ComboBox();
            nudYear = new NumericUpDown();
            nudTerm = new NumericUpDown();
            txtCode = new TextBox();
            nudSerial = new NumericUpDown();
            btnGenerate = new Button();
            txtGenerated = new TextBox();
            ((System.ComponentModel.ISupportInitialize)errorProvider1).BeginInit();
            toolStripMain.SuspendLayout();
            pnlMain.SuspendLayout();
            grpValidate.SuspendLayout();
            grpGenerate.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)nudYear).BeginInit();
            ((System.ComponentModel.ISupportInitialize)nudTerm).BeginInit();
            ((System.ComponentModel.ISupportInitialize)nudSerial).BeginInit();
            SuspendLayout();
            // 
            // errorProvider1
            // 
            errorProvider1.ContainerControl = this;
            // 
            // toolStripMain
            // 
            toolStripMain.Items.AddRange(new ToolStripItem[] { toolStripLabel1 });
            toolStripMain.Location = new Point(0, 0);
            toolStripMain.Name = "toolStripMain";
            toolStripMain.RightToLeft = RightToLeft.Yes;
            toolStripMain.Size = new Size(432, 25);
            toolStripMain.TabIndex = 1;
            // 
            // toolStripLabel1
            // 
            toolStripLabel1.Name = "toolStripLabel1";
            toolStripLabel1.Size = new Size(167, 22);
            toolStripLabel1.Text = "تولید و اعتبارسنجی کد دانشگاهی";
            // 
            // pnlMain
            // 
            pnlMain.Controls.Add(grpValidate);
            pnlMain.Controls.Add(grpGenerate);
            pnlMain.Dock = DockStyle.Fill;
            pnlMain.Location = new Point(0, 25);
            pnlMain.Name = "pnlMain";
            pnlMain.Padding = new Padding(20);
            pnlMain.Size = new Size(432, 372);
            pnlMain.TabIndex = 0;
            // 
            // grpValidate
            // 
            grpValidate.Controls.Add(txtInput);
            grpValidate.Controls.Add(btnValidate);
            grpValidate.Controls.Add(txtResult);
            grpValidate.Dock = DockStyle.Fill;
            grpValidate.Location = new Point(20, 240);
            grpValidate.Name = "grpValidate";
            grpValidate.Size = new Size(392, 112);
            grpValidate.TabIndex = 0;
            grpValidate.TabStop = false;
            grpValidate.Text = "اعتبارسنجی کد";
            // 
            // txtInput
            // 
            txtInput.Location = new Point(15, 22);
            txtInput.Name = "txtInput";
            txtInput.Size = new Size(371, 23);
            txtInput.TabIndex = 0;
            // 
            // btnValidate
            // 
            btnValidate.Location = new Point(15, 51);
            btnValidate.Name = "btnValidate";
            btnValidate.Size = new Size(371, 23);
            btnValidate.TabIndex = 1;
            btnValidate.Text = "بررسی اعتبار";
            btnValidate.Click += btnValidate_Click;
            // 
            // txtResult
            // 
            txtResult.Location = new Point(15, 80);
            txtResult.Name = "txtResult";
            txtResult.ReadOnly = true;
            txtResult.Size = new Size(371, 23);
            txtResult.TabIndex = 2;
            // 
            // grpGenerate
            // 
            grpGenerate.Controls.Add(label5);
            grpGenerate.Controls.Add(label4);
            grpGenerate.Controls.Add(label3);
            grpGenerate.Controls.Add(label2);
            grpGenerate.Controls.Add(label1);
            grpGenerate.Controls.Add(cmbType);
            grpGenerate.Controls.Add(nudYear);
            grpGenerate.Controls.Add(nudTerm);
            grpGenerate.Controls.Add(txtCode);
            grpGenerate.Controls.Add(nudSerial);
            grpGenerate.Controls.Add(btnGenerate);
            grpGenerate.Controls.Add(txtGenerated);
            grpGenerate.Dock = DockStyle.Top;
            grpGenerate.Location = new Point(20, 20);
            grpGenerate.Name = "grpGenerate";
            grpGenerate.Size = new Size(392, 220);
            grpGenerate.TabIndex = 1;
            grpGenerate.TabStop = false;
            grpGenerate.Text = "تولید کد";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(339, 21);
            label5.Name = "label5";
            label5.Size = new Size(29, 15);
            label5.TabIndex = 11;
            label5.Text = "تایپ";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(278, 105);
            label4.Name = "label4";
            label4.Size = new Size(98, 15);
            label4.TabIndex = 10;
            label4.Text = "CODE (3-6 حروف)";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(354, 78);
            label3.Name = "label3";
            label3.Size = new Size(22, 15);
            label3.TabIndex = 9;
            label3.Text = "ترم";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(348, 49);
            label2.Name = "label2";
            label2.Size = new Size(28, 15);
            label2.TabIndex = 8;
            label2.Text = "سال";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(339, 136);
            label1.Name = "label1";
            label1.Size = new Size(37, 15);
            label1.TabIndex = 7;
            label1.Text = "سریال";
            // 
            // cmbType
            // 
            cmbType.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbType.Location = new Point(15, 18);
            cmbType.Name = "cmbType";
            cmbType.Size = new Size(250, 23);
            cmbType.TabIndex = 0;
            // 
            // nudYear
            // 
            nudYear.Location = new Point(15, 47);
            nudYear.Maximum = new decimal(new int[] { 2100, 0, 0, 0 });
            nudYear.Minimum = new decimal(new int[] { 2000, 0, 0, 0 });
            nudYear.Name = "nudYear";
            nudYear.Size = new Size(250, 23);
            nudYear.TabIndex = 1;
            nudYear.Value = new decimal(new int[] { 2025, 0, 0, 0 });
            // 
            // nudTerm
            // 
            nudTerm.Location = new Point(15, 76);
            nudTerm.Maximum = new decimal(new int[] { 3, 0, 0, 0 });
            nudTerm.Minimum = new decimal(new int[] { 1, 0, 0, 0 });
            nudTerm.Name = "nudTerm";
            nudTerm.Size = new Size(250, 23);
            nudTerm.TabIndex = 2;
            nudTerm.Value = new decimal(new int[] { 1, 0, 0, 0 });
            // 
            // txtCode
            // 
            txtCode.Location = new Point(15, 105);
            txtCode.Name = "txtCode";
            txtCode.Size = new Size(250, 23);
            txtCode.TabIndex = 3;
            // 
            // nudSerial
            // 
            nudSerial.Location = new Point(15, 134);
            nudSerial.Maximum = new decimal(new int[] { 9999, 0, 0, 0 });
            nudSerial.Name = "nudSerial";
            nudSerial.Size = new Size(250, 23);
            nudSerial.TabIndex = 4;
            // 
            // btnGenerate
            // 
            btnGenerate.Location = new Point(15, 163);
            btnGenerate.Name = "btnGenerate";
            btnGenerate.Size = new Size(250, 23);
            btnGenerate.TabIndex = 5;
            btnGenerate.Text = "تولید کد";
            btnGenerate.Click += btnGenerate_Click;
            // 
            // txtGenerated
            // 
            txtGenerated.Location = new Point(15, 191);
            txtGenerated.Name = "txtGenerated";
            txtGenerated.ReadOnly = true;
            txtGenerated.Size = new Size(250, 23);
            txtGenerated.TabIndex = 6;
            // 
            // FrmUniversityCode
            // 
            ClientSize = new Size(432, 397);
            Controls.Add(pnlMain);
            Controls.Add(toolStripMain);
            Name = "FrmUniversityCode";
            RightToLeft = RightToLeft.Yes;
            RightToLeftLayout = true;
            StartPosition = FormStartPosition.CenterScreen;
            Text = "University Code Utility";
            ((System.ComponentModel.ISupportInitialize)errorProvider1).EndInit();
            toolStripMain.ResumeLayout(false);
            toolStripMain.PerformLayout();
            pnlMain.ResumeLayout(false);
            grpValidate.ResumeLayout(false);
            grpValidate.PerformLayout();
            grpGenerate.ResumeLayout(false);
            grpGenerate.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)nudYear).EndInit();
            ((System.ComponentModel.ISupportInitialize)nudTerm).EndInit();
            ((System.ComponentModel.ISupportInitialize)nudSerial).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private ToolStrip toolStripMain;
        private ToolStripLabel toolStripLabel1;

        private Panel pnlMain;
        private GroupBox grpGenerate;
        private GroupBox grpValidate;

        private ComboBox cmbType;
        private NumericUpDown nudYear;
        private NumericUpDown nudTerm;
        private TextBox txtCode;
        private NumericUpDown nudSerial;
        private Button btnGenerate;
        private TextBox txtGenerated;

        private TextBox txtInput;
        private Button btnValidate;
        private TextBox txtResult;

        private ErrorProvider errorProvider1;
        private Label label3;
        private Label label2;
        private Label label1;
        private Label label5;
        private Label label4;
    }
}
