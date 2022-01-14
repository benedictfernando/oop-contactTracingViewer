using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace oop_contactTracingViewer
{
    public partial class viewer : Form
    {
        public viewer()
        {
            InitializeComponent();
        }

        private string text;

        private void viewer_Load(object sender, EventArgs e)
        {
            // Initialize database file & its directory
            string username = "Benedict Fernando";
            string database = $@"C:\Users\{username}\Downloads\CTDatabase.txt";
            // Note: 'username' & 'database' can be changed depending on target

            if (File.Exists(database)) text = File.ReadAllText(database);
            else
            {
                MessageBox.Show("No 'CTDatabase.txt' file was found.\n" +
                    "\nKindly submit at least one entry first using our " +
                    "Contact Tracer App, then return to us again later.",
                    "CT Database Failed", MessageBoxButtons.OK,
                    MessageBoxIcon.Information); Application.Exit();
            }
        }
    }
}
