using System.Security.Cryptography;

namespace Student_check_App
{
    public partial class Form1 : Form
    {
        List<string> student_about = new List<string>();
        List<string> student_fee = new List<string>();
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            search_result.Text = "";   
            for(int i = 0; i < student_about.Count; i++)
            {
                
                for (int j = 0; j < student_fee.Count; j++)
                {
                    string student_id = student_about[i].Split(' ')[2];
                    string odenis_id = student_fee[j];
                    bool sert = false;
                    if (id_box.Text == student_id && student_id == odenis_id)
                    {
                        search_result.Text = student_about[i] + "  Odenislidir.";
                        break;
                    }
                    else if (id_box.Text == student_id)
                    {
                        for (int k = 0; k < student_fee.Count; k++)
                        {
                            if (!(student_id == student_fee[k]))
                            {
                                sert = true;
                            }
                            if (sert)
                            {
                                search_result.Text = student_about[i] + " Odenis Olunmayib!";
                                break;
                            }
                        }
                    }
                }
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            Student s = new Student();
            s.name = "Huseyn";
            s.surname = "Eliyev";
            s.id = 1596;

            Student s2 = new Student();
            s2.id = 1596;
            

            Student s3 = new Student();
            s3.name = "Adil";
            s3.surname = "Seferov";
            s3.id = 4567;

            Student s4 = new Student();
            s4.name = "Hilal";
            s4.surname = "Efendiyev";
            s4.id = 7536;

            Student s5 = new Student();
            s5.id = 7536;

            student_about.Add(s.name + " " + s.surname + " " + s.id);
            student_about.Add(s3.name + " " + s3.surname + " " + s3.id);
            student_about.Add(s4.name + " " + s4.surname + " " + s4.id);
            student_fee.Add((s2.id).ToString());
            student_fee.Add((s5.id).ToString());
        }
    }

    class Student
    {
        public string name { get; set; }
        
        public string surname { get; set; }
        
        public int id { get; set; }

        
    }
}