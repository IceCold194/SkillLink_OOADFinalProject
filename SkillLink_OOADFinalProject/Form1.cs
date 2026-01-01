using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SkillLink_OOADFinalProject
{
    public partial class Form1 : Form
    {
        private SkillLinkManager manager = new SkillLinkManager();

        public Form1()
        {
            InitializeComponent();
        }

        private void buttonAddTrainee_Click(object sender, EventArgs e)
        {
            try
            {
                string name = textBoxTraineeName.Text;
                string contact = textBoxTraineeContact.Text;
                manager.AddTrainee(name, contact);
                MessageBox.Show($"Trainee {name} added with ID {manager.Trainees[manager.Trainees.Count - 1].ID}");

                // Refresh the DataGridView named dgvTrainees
                dataGridViewTrainees.DataSource = null;
                dataGridViewTrainees.DataSource = manager.Trainees;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void buttonCertify_Click(object sender, EventArgs e)
        {
            if (int.TryParse(textBoxTraineeToCertify.Text, out int id))
            {
                bool success = manager.MarkCertified(id, "Computer Literacy 101");
                if (success)
                {
                    MessageBox.Show($"Trainee ID {id} has been certified!");
                }
                else
                {
                    MessageBox.Show("Trainee not found. Select a row to Certify");
                }
            }
        }

        private void dataGridViewTrainees_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = dataGridViewTrainees.Rows[e.RowIndex];

                if (row.DataBoundItem is Trainee selectedTrainee)
                {
                    textBoxTraineeToCertify.Text = selectedTrainee.ID.ToString();
                }
            }
        }
    }
}
