using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PasswordGenerator
{
    public partial class GUI : Form
    {


        //TGenerator newPassphrase = new TGenerator();
        TGenerator generator = TGenerator.getInstance();

        public GUI()
        {
            InitializeComponent();
            

        }

        private void btn__generate_Click(object sender, EventArgs e)
        {
            generator.generateString();
            tb_passphrase.Text = generator.SPassphrase.ToString();
        }


    }
}
