namespace Teacher_select
{
    public partial class Form1 : Form
    {
        List<string> teacher_about = new List<string>();
        List<string> teacher_contract = new List<string>();
        DateTime date1 = DateTime.Now;
        
        //
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            Teacher t = new Teacher();
            t.name = "Elekber";
            t.surname = "Yasamalli";
            t.pin = "12345";

            Teacher t2 = new Teacher();
            t2.name = "Hesen";
            t2.surname = "Yusifov";
            t2.pin = "45678";

            Teacher t3 = new Teacher();
            t3.start_c = DateTime.Parse("01-10-2015");
            t3.end_c = DateTime.Parse("12-30-2022");
            t3.pin = "12345";

            Teacher t4 = new Teacher();
            t4.name = "Ibrahim";
            t4.surname = "Baxseliyev";
            t4.pin = "66998";

            Teacher t5 = new Teacher();
            t5.start_c = DateTime.Parse("01-10-2019");
            t5.end_c = DateTime.Parse("06-25-2021");
            t5.pin = "66998";

            Teacher t6 = new Teacher();
            t6.name = "Esed";
            t6.surname = "Bayramov";
            t6.pin = "15937";

            Teacher t7 = new Teacher();
            t7.name = "Mikayil";
            t7.surname = "Muradov";
            t7.pin = "78945";

            Teacher t8 = new Teacher();
            t8.start_c = DateTime.Parse("01-10-2010");
            t8.end_c = DateTime.Parse("06-25-2015");
            t8.pin = "78945";

            Teacher t9 = new Teacher();
            t9.name = "Seid";
            t9.surname = "Celilzade";
            t9.pin = "56565";

            teacher_about.Add(t.name + " " + t.surname + " " + t.pin);
            teacher_about.Add(t2.name + " " + t2.surname + " " + t2.pin);
            teacher_about.Add(t4.name + " " + t4.surname + " " + t4.pin);
            teacher_about.Add(t6.name + " " + t6.surname + " " + t6.pin);
            teacher_about.Add(t7.name + " " + t7.surname + " " + t7.pin);
            teacher_about.Add(t9.name + " " + t9.surname + " " + t9.pin);
            teacher_contract.Add((t3.start_c).ToString() + " " + (t3.end_c).ToString() + " " + t3.pin);
            teacher_contract.Add((t5.start_c).ToString() + " " + (t5.end_c).ToString() + " " + t5.pin);
            teacher_contract.Add((t8.start_c).ToString() + " " + (t8.end_c).ToString() + " " + t8.pin);
        }

        private void pin_search_Click(object sender, EventArgs e)
        {
            contracted_teacher.Items.Clear();
            contractless_teacher.Items.Clear();
            bool f = false;
            
            for(int i = 0; i < teacher_about.Count; i++)
            {
                for (int j = 0; j < teacher_contract.Count; j++)
                {
                    DateTime date2 = DateTime.Parse(teacher_contract[j].Split(' ')[3] + " " + teacher_contract[j].Split(' ')[4] + " " + teacher_contract[j].Split(' ')[5]);
                    int result = DateTime.Compare(date2, date1);
                    string teacher_pin = teacher_about[i].Split(' ')[2];
                    string contract_pin = teacher_contract[j].Split(' ')[6];

                    if (pin_box.Text == teacher_pin && teacher_pin == contract_pin)
                    {
                        if(result > 0)
                        {
                            contracted_teacher.Items.Clear();
                            contractless_teacher.Items.Clear();
                            contracted_teacher.Items.Add(teacher_about[i] + " | " + teacher_contract[j].Split(' ')[0] + " | " + teacher_contract[j].Split(' ')[3] + " | " + " Contract Continues...");
                        }
                        else if(result < 0)
                        {
                            contracted_teacher.Items.Clear();
                            contractless_teacher.Items.Clear();
                            contracted_teacher.Items.Add(teacher_about[i] + " | " + teacher_contract[j].Split(' ')[0] + " | " + teacher_contract[j].Split(' ')[3] + " | " + " Contract Has Ended !");
                        }
                        break;
                    }
                    else if (pin_box.Text == teacher_pin)
                    {
                        for (int k = 0; k < teacher_contract.Count; k++)
                        {
                            if (!(teacher_contract[k].Split(' ')[6] == teacher_pin))
                            {
                                f = true;
                            }
                        }
                        if (f)
                        {
                            contracted_teacher.Items.Clear();
                            contractless_teacher.Items.Clear();
                            contractless_teacher.Items.Add(teacher_about[i]);
                        }
                        
                    }
                }
            }
        }
    }

    class Teacher
    {
        public string name { get; set; }
        public string surname { get; set; }
        public string pin { get; set; }
        public DateTime start_c { get; set; }
        public DateTime end_c { get; set; }
    }
}