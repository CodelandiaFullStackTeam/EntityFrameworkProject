using EntityFrameworkProject.Contexts;
using EntityFrameworkProject.Entities;
using EntityFrameworkProject.Operations;

namespace EntityFrameworkProject
{
    public partial class Form1 : Form
    {
        FuelTypeManager _manager = new();
        public Form1()
        {
            InitializeComponent();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {

            var fuelType = new FuelType
            {
                Name = txtName.Text
            };

            _manager.Add(fuelType);

            dataGridView1.DataSource = _manager.GetAll();
        }



        private void Form1_Load(object sender, EventArgs e)
        {
            txtId.Enabled = false;
            dataGridView1.DataSource = _manager.GetAll() ;
        }

        private void dataGridView1_SelectionChanged(object sender, EventArgs e)
        {
            var id = dataGridView1.CurrentRow.Cells["ID"].Value.ToString();
            var name = dataGridView1.CurrentRow.Cells["Name"].Value.ToString();

            txtName.Text = name;
            txtId.Text = id;
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            int id = int.Parse(txtId.Text);
            var model = _manager.Get(x=>x.Id == id);
            model.Name = txtName.Text;
            
            _manager.Update(model);

            dataGridView1.DataSource = _manager.GetAll();
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            int id = int.Parse(txtId.Text);
            var deletedModel = _manager.Get(x => x.Id == id);
            _manager.Delete(deletedModel);
            
            dataGridView1.DataSource = _manager.GetAll();
        }
    }
}