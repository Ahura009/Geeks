using University.Application.Students.Command.AllocateSeminarGroupAutomatically;
using University.Application.Students.Command.Create;
using University.Application.Students.Query.GetStudent;
using University.Infra.Application;
using University.Infra.Core.Const;
using University.Ui.Extension;

namespace University.Ui.Forms.FrmStudents;

public partial class FrmStudent : Form
{
    public FrmStudent()
    {
        InitializeComponent();
    }

    private void FrmStudent_Load(object sender, EventArgs e)
    {
        LoadStudentsGrid();
    }

    private void btnRegister_Click(object sender, EventArgs e)
    {
        errorProvider1.Clear();

        if (string.IsNullOrWhiteSpace(txtFullName.Text))
        {
            errorProvider1.SetError(txtFullName, "نام و نام خانوادگی الزامی است.");
            MessageBox.Show("لطفاً نام و نام خانوادگی دانشجو را وارد کنید.", "هشدار", MessageBoxButtons.OK,
                MessageBoxIcon.Warning);
            txtFullName.Focus();
            return;
        }

        try
        {
            var result = new CreateStudentCommandHandler().Handle(new CreateStudentCommand
            {
                FullName = txtFullName.Text.Trim()
            });

            if (result.State == ApplicationServiceState.Ok)
            {
                MessageBox.Show(result.Message, Const.Success, MessageBoxButtons.OK, MessageBoxIcon.Information);
                ClearForm();
                LoadStudentsGrid();
            }
            else
            {
                MessageBox.Show(result.Message, Const.Error, MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        catch (Exception ex)
        {
            MessageBox.Show("خطای غیرمنتظره: " + ex.Message, "خطا", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }
    }

    private void btnClear_Click(object sender, EventArgs e)
    {
        ClearForm();
    }

    private void ClearForm()
    {
        txtFullName.Clear();
        errorProvider1.Clear();
        txtFullName.Focus();
    }

    private void LoadStudentsGrid()
    {
        var result = new GetStudentQueryHandler().Handle(new GetStudentQuery());
        dataGridViewStudents.BindingSource(result.Data);
        dataGridViewStudents.Columns.CreateTextBoxColumn("StudentName", "نام و نام خانوادگی دانشجو");
        dataGridViewStudents.Columns.CreateTextBoxColumn("StudentId", "", false);
        dataGridViewStudents.Columns.CreateButtonColumn(DataGridViewExtension.StudentModule, "ماژول");
        dataGridViewStudents.Columns.CreateButtonColumn(DataGridViewExtension.StudentSeminarGroup,
            "انتخاب گروه سمینار");
        dataGridViewStudents.Columns.CreateButtonColumn(DataGridViewExtension.StudentConflict, "تاریخچه تداخل");
        dataGridViewStudents.Columns.CreateButtonColumn(DataGridViewExtension.StudentGrade, "نمرات");
    }

    private void dataGridViewStudents_CellClick(object sender, DataGridViewCellEventArgs e)
    {
        if (!dataGridViewStudents.ValidateOperation(e)) return;
        var id = dataGridViewStudents.GetRowData<Guid>(e, 1);
        var name = dataGridViewStudents.GetRowData<string>(e, 0);

        if (e.ColumnIndex == dataGridViewStudents.Columns[DataGridViewExtension.StudentModule]!.Index)
            new FrmStudentModule(id, name).ShowDialog();

        if (e.ColumnIndex == dataGridViewStudents.Columns[DataGridViewExtension.StudentSeminarGroup]!.Index)
            new FrmStudentSeminar(id, name).ShowDialog();

        if (e.ColumnIndex == dataGridViewStudents.Columns[DataGridViewExtension.StudentConflict]!.Index)
            new FrmStudentConflict(id, name).ShowDialog();

        if (e.ColumnIndex == dataGridViewStudents.Columns[DataGridViewExtension.StudentGrade]!.Index)
            new FrmStudentGrade(id, name).ShowDialog();
    }

    private void btnSeminarGroupAllocation_Click(object sender, EventArgs e)
    {
        new AllocateSeminarGroupAutomaticallyCommandHandler().Handle();
        MessageBox.Show("OK", Const.Success, MessageBoxButtons.OK, MessageBoxIcon.Information);
    }
}