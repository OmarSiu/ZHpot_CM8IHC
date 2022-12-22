using Excel = Microsoft.Office.Interop.Excel; 
using System.Reflection;
namespace ZHpot_CM8IHC
{
    public partial class Form1 : Form
    {
        Models.Diak context = new Models.Diak();
        Excel.Application xlApp;
        Excel.Workbook xlWB;
        Excel.Worksheet xlSheet;
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            studentBindingSource.DataSource = context.Students.ToList();
            filter1();
            filter2();
            try
            {
                xlApp = new Excel.Application();
                xlWB = xlApp.Workbooks.Add(Missing.Value);
                xlSheet = xlWB.ActiveSheet;
                CreateTable();
                xlApp.Visible = true;
                xlApp.UserControl = true;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            DialogResult result = MessageBox.Show("are you sure?", "confirm", MessageBoxButtons.YesNo);
            if (result == DialogResult.No)
            {
                e.Cancel = true;
            }
        }

        private void buttonadd_Click(object sender, EventArgs e)
        {
            NewStudent newStudent = new NewStudent();
            if (newStudent.ShowDialog() == DialogResult.OK)
            {
                Models.Student student = new Models.Student();
                student.Name = newStudent.textBoxnev.Text;
                student.Neptun = newStudent.textBoxneptun.Text;
                context.Add(student);
                try
                {
                    context.SaveChanges();
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
                studentBindingSource.DataSource = context.Students.ToList();
            }
        }

        private void buttondel_Click(object sender, EventArgs e)
        {
            var selecteditem = studentBindingSource.Current;
            DialogResult result = MessageBox.Show("are you sure?", "delete", MessageBoxButtons.YesNo);
            if (result == DialogResult.Yes)
            {
                studentBindingSource.Remove(selecteditem);
                context.SaveChanges();
            }
        }

        private void textBoxszuro1_TextChanged(object sender, EventArgs e)
        {
            filter1();
        }

        private void filter1()
        {
            var people = from x in context.Students
                         where x.Name.Contains(textBoxszuro1.Text)
                         select x;
            listBoxnev.DataSource = people.ToList();
            listBoxnev.DisplayMember = "Name";
        }

        private void textBoxszuro2_TextChanged(object sender, EventArgs e)
        {
            filter2();
        }

        private void filter2()
        {
            var neptun = from x in context.Students
                         where x.Neptun.Contains(textBoxszuro2.Text)
                         select x;
            listBoxneptun.DataSource = neptun.ToList();
            listBoxneptun.DisplayMember = "Neptun";
        }

        void CreateTable()
        {
            Models.Diak exc = new Models.Diak();
            var cella = exc.Students.ToList();
            string[] fejlec = new string[] {
            "ID",
            "Neptun",
            "Name",
            "BirthDate",
            "AverageGrade",
            "IsActive"};
            object[,] tömb = new object[cella.Count(), fejlec.Count()];
            for (int i = 0; i < fejlec.Length; i++)
            {
                xlSheet.Cells[1, i + 1] = fejlec[i];
            }
            for (int i = 0; i < cella.Count(); i++)
            {
                tömb[i, 0] = cella[i].Id;
                tömb[i, 1] = cella[i].Neptun;
                tömb[i, 2] = cella[i].Name;
                tömb[i, 3] = cella[i].BirthDate;
                tömb[i, 4] = cella[i].AverageGrade;
                tömb[i, 5] = cella[i].IsActive;
            }
            int sor = cella.Count();
            int oszlop = fejlec.Count();
            Excel.Range adat_range = xlSheet.get_Range("A2", Type.Missing).get_Resize(sor, oszlop);
            adat_range.Value2 = tömb;
            adat_range.Columns.AutoFit();
        }
    }
}