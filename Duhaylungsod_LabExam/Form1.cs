using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Duhaylungsod_LabExam
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        double Danielle = 0.0;
        double Edward = 0.0;
        double Fatima = 0.0;
        private void getSales(string initial, double amount)
        {
            string name;
            double totalSales;
            if (initial == "D")
            {
                totalSales = Danielle += amount;
                name = "Danielle";
            }
            else if (initial == "E")
            {
                totalSales = Edward += amount;
                name = "Edward";
            }
            else if (initial == "F")
            {
                totalSales = Fatima += amount;
                name = "Fatima";
            }
            else
            {
                MessageBox.Show("Invalid initial. Please enter D, E, or F.");
                return;
            }

            labelResult.Text = $"${amount} was successfully added to {name}.\n bringing the total to ${totalSales}";
        }

        private void buttonSubmit_Click(object sender, EventArgs e)
        {
            string initial = textBox_Initial.Text.ToUpper();
            double amount;

            if (double.TryParse(textBox_AmountOfSale.Text, out amount))
            {
                getSales(initial, amount);
            }
            else
            {
                MessageBox.Show("Please enter a valid non-negative number for the amount of sale.");
            }

        }

        private void buttonClear_Click(object sender, EventArgs e)
        {

            textBox_Initial.Clear();
            textBox_AmountOfSale.Clear();
            labelResult.Text = "";
        }

        private void buttonPrint_Click(object sender, EventArgs e)
        {
            Form2 form2 = new Form2(Danielle, Edward, Fatima);
            form2.Show();
        }

        private void HOMESALE_Load(object sender, EventArgs e)
        {

        }
    }
}

