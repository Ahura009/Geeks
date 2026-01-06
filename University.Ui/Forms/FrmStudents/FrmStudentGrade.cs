using University.Application.Students.Command.AddGradeToStudent;
using University.Application.Students.Command.AddResitGradeToStudent;
using University.Application.Students.Query.GetModuleByStudent;
using University.Application.Students.Query.StudentGrade;
using University.Ui.Extension;

namespace University.Ui.Forms.FrmStudents;

public partial class FrmStudentGrade : Form
{
    private readonly Guid _id;
    private readonly string _name;


    public FrmStudentGrade(Guid id, string name)
    {
        InitializeComponent();
        _id = id;
        _name = name;
        lblInfo.Text = $"مدیریت نمرات دانشجو  {_name}";
        LoadModules();
        LoadGrades();
    }

    private void LoadModules()
    {
        var studentModule = new GetModuleByStudentIdQueryHandler()
            .Handle(new GetModuleByStudentIdQuery { StudentId = _id }).Data;
        cmbModule.BindData(studentModule, "ModuleName", "ModuleId");
    }

    private void LoadGrades()
    {
        var data = new GetGradeByStudentQueryHandler().Handle(new GetGradeByStudentQuery
        {
            StudentId = _id
        }).Data;

        dataGridGrades.BindingSource(data);

        dataGridGrades.Columns.CreateTextBoxColumn("Score", "نمره اصلی");
        dataGridGrades.Columns.CreateTextBoxColumn("GradeId", "", false);
        dataGridGrades.Columns.CreateTextBoxColumn("StudentId", "", false);
        dataGridGrades.Columns.CreateTextBoxColumn("ModuleId", "", false);
        dataGridGrades.Columns.CreateTextBoxColumn("ResitScore", "نمره رسیت");
        dataGridGrades.Columns.CreateTextBoxColumn("Weight", "وزن نمره");
        dataGridGrades.Columns.CreateTextBoxColumn("DateUtc", "تاریخ ثبت");
        dataGridGrades.Columns.CreateTextBoxColumn("ResitDateUtc", "تاریخ ثبت رسیت");
        dataGridGrades.Columns.CreateTextBoxColumn("FinalScore", "نمره نهایی");
    }

    private void BtnAddGrade_Click(object sender, EventArgs e)
    {
        new AddGradeToStudentCommandHandler().Handle(new AddGradeToStudentCommand
        {
            DateUtc = dtpDate.Value,
            ModuleId = cmbModule.GetSelectedValue<Guid>(),
            Score = (int)nudScore.Value,
            StudentId = _id,
            Weight = nudWeight.Value
        });
        LoadGrades();
        MessageBox.Show("نمره با موفقیت ثبت شد.");
    }


    private void btnAddResit_Click_1(object sender, EventArgs e)
    {
        new AddResitGradeToStudentCommandHandler().Handle(new AddResitGradeToStudentCommand
        {
            ResitDateUtc = dtpDate.Value,
            ModuleId = cmbModule.GetSelectedValue<Guid>(),
            ResitScore = (int)nudScore.Value,
            StudentId = _id,
            Weight = nudWeight.Value
        });
        LoadGrades();
        MessageBox.Show("نمره با موفقیت ثبت شد.");
    }
}