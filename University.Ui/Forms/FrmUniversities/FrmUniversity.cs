namespace University.Ui.Forms.FrmUniversities;

public partial class FrmUniversity : Form
{
    public FrmUniversity()
    {
        InitializeComponent();
    }

    private void btnUniversityCode_Click(object sender, EventArgs e)
    {
        new FrmUniversityCode().ShowDialog();
    }
}