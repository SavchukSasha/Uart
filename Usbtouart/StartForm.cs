using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WindowsFormsApplication1;

namespace Usbtouart
{
    public partial class StartForm : Form
    {
        public StartForm()
        {
           
            InitializeComponent();

        }

        private void StartForm_Load(object sender, EventArgs e)
        {
            comboBox2.SelectedItem = "COM5";
        }

        private void button1_Click(object sender, EventArgs e)
        {
            
            Form11 newForm = new Form11(comboBox2.Text);
            newForm.Show();
            Hide();
            
        }
    }
}
