using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AufgabeFSK18
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void bt_pruefen_Click(object sender, EventArgs e)
        {
            int alter = DateTime.Now.Year - dtp_GebDat.Value.Year;

            //Aktuelles: 14.08.2021
            //GebDatum:  16.08.2000

            if (dtp_GebDat.Value.Month > DateTime.Now.Month || (dtp_GebDat.Value.Month == DateTime.Now.Month
                && dtp_GebDat.Value.Day > DateTime.Now.Day))
                alter--;

            if (alter < 18)
                MessageBox.Show("Zutritt VERWEIGERT");
            else
                MessageBox.Show("Zutritt gewährt");

        }
    }
}
