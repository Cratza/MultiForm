using System.Security.Cryptography.X509Certificates;
using System.Reflection.Metadata;
namespace MultiForm;

public partial class Form1 : Form
{
    public Form1()
    {
        InitializeComponent();

        this.Size = new Size(300, 200);

        dgvMainForm = new DataGridView()
        {
            Dock = DockStyle.Fill
        };

        btnMain = new Button()
        {
            Text = "Click Me to Open new form",
            Dock = DockStyle.Bottom
        };

        btnMain.Click += (ss, ee) =>
        {
            // Show和ShowDialog的区别
            // Show出来的子窗体不影响父窗体的操作
            // ShowDialog出来子窗体后父窗体无法操作
            new NextForm(Students).ShowDialog();
        };

        this.Controls.Add(dgvMainForm);
        this.Controls.Add(btnMain);
        this.Controls.Add(new Button{Text="Button2",Dock=DockStyle.Bottom});

        Students = new List<Student>()
        {
            new Student{ID=10000,Name="Cratza"},
            new Student{ID=10001,Name="Cred"},
        };

        dgvMainForm.DataSource = Students;
    }

    private List<Student> Students;
    private DataGridView dgvMainForm;
    private Button btnMain;
}
