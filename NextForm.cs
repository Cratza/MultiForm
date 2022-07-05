namespace MultiForm
{
    public class NextForm : Form
    {
        public NextForm(List<Student> students)
        {
            Students = students;
            dgvMainForm = new DataGridView();
            this.Controls.Add(dgvMainForm);
            dgvMainForm.DataSource = Students;
        }

        private List<Student> Students;
        private DataGridView dgvMainForm;
    }
}