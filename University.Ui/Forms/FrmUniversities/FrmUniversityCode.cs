using University.Domain.University.ValueObject;

namespace University.Ui.Forms.FrmUniversities;

public partial class FrmUniversityCode : Form
{
    public FrmUniversityCode()
    {
        InitializeComponent();
        cmbType.Items.AddRange(new[] { "STU", "MOD", "STF" });
        cmbType.SelectedIndex = 0;
    }

    private void btnGenerate_Click(object sender, EventArgs e)
    {
        errorProvider1.Clear();

        try
        {
            var code = UniversityCode.Create(
                cmbType.Text,
                (int)nudYear.Value,
                (int)nudTerm.Value,
                txtCode.Text,
                (int)nudSerial.Value
            );

            txtGenerated.Text = code.FullCode;
        }
        catch (Exception ex)
        {
            errorProvider1.SetError(btnGenerate, ex.Message);
        }
    }

    private void btnValidate_Click(object sender, EventArgs e)
    {
        errorProvider1.Clear();
        txtResult.Clear();

        if (UniversityCode.TryParse(txtInput.Text, out var code, out var error))
        {
            txtResult.Text =
                $"معتبر\n" +
                $"نوع: {code!.Type}\n" +
                $"سال: {code.Year}\n" +
                $"ترم: {code.Term}\n" +
                $"کد: {code.Code}\n" +
                $"سریال: {code.Serial:D4}";
        }
        else
        {
            txtResult.Text = "نامعتبر";
            errorProvider1.SetError(txtInput, error);
        }
    }
}