namespace MultiForm;

public partial class Form1 : Form
{
    public Form1()
    {
        InitializeComponent();

        Students = new List<Student>()
        {
            new Student{ID=10000,Name="Cratza"},
            new Student{ID=10001,Name="Cred"},
        };

        
    }

    List<Student> Students;
}
