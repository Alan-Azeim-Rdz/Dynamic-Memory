namespace Dynamic_Memory
{
    public partial class Form1 : Form
    {
        List<int> list = new List<int>();
        public Form1()
        {
            InitializeComponent();
        }

        private void BtnAdd_Click(object sender, EventArgs e)
        {
            try
            {
                int insertdata = Convert.ToInt32(TxtAdd.Text);
                list.Add(insertdata);
                ListViewDataList.Items.Clear();
                foreach (int i in list)
                {
                    ListViewDataList.Items.Add(i.ToString());
                }
                LblSize.Text = list.Count.ToString();
            }
            catch
            {
                MessageBox.Show("hay un error con los datos que intenta agregar a la lista, verifiquelos");
            }

        }

        private void BtnDelete_Click(object sender, EventArgs e)
        {
            try
            {
                int insertdata = Convert.ToInt32(TxtAdd.Text);
                list.Remove(insertdata);
                ListViewDataList.Items.Clear();
                foreach ( int i in list)
                {
                    ListViewDataList.Items.Add(i.ToString());
                }
                LblSize.Text = list.Count.ToString();
            }
            catch
            {
                MessageBox.Show("hay un error con los datos que intenta remover, verifique que exista");
            }
        }
    }
}
