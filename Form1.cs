using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Contacts
{
	public partial class Form1 : Form
	{
		public Form1()
		{
			InitializeComponent();
		}

		private void pictureBox1_Click(object sender, EventArgs e)
		{
			MessageBox.Show("Version 0.0.1\n Author: Davi Queiroz", "About");
		}

		private void peopleBindingNavigatorSaveItem_Click(object sender, EventArgs e)
		{
            this.Validate();
            this.peopleBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.contactDBDataSet);

        }

		private void Form1_Load(object sender, EventArgs e)
		{
            // TODO: esta linha de código carrega dados na tabela 'contactDBDataSet.people'. Você pode movê-la ou removê-la conforme necessário.
            this.peopleTableAdapter.Fill(this.contactDBDataSet.people);

        }

		private void nameLabel_Click(object sender, EventArgs e)
		{

		}

		private void nameTextBox_TextChanged(object sender, EventArgs e)
		{

		}

		private void companyLabel_Click(object sender, EventArgs e)
		{

		}

		private void clientLabel_Click(object sender, EventArgs e)
		{

		}

		private void emailLabel_Click(object sender, EventArgs e)
		{

		}

		private void clientCheckBox_CheckedChanged(object sender, EventArgs e)
		{

		}
	}
}
