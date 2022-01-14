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

        private string[] entries;

        private void viewer_Load(object sender, EventArgs e)
        {
            // Initialize database file & its directory
            string username = "Benedict Fernando";
            string database = $@"C:\Users\{username}\Downloads\CTDatabase.txt";
            // Note: 'username' & 'database' can be changed depending on target

            if (File.Exists(database))
            {
                entries = File.ReadAllText(database).Split("\n\n");
                firstEntry();
            }
            else
            {
                MessageBox.Show("No 'CTDatabase.txt' file was found.\n" +
                    "\nKindly submit at least one entry first using our " +
                    "Contact Tracer App, then return to us again later.",
                    "CT Database Failed", MessageBoxButtons.OK,
                    MessageBoxIcon.Information); Application.Exit();
            }
        }

        // Load 1st entry
        private void firstEntry()
        {
            pages.Text = "1 out of " + entries.Length; loadEntry(1);
            if (entries.Length == 1) right.Enabled = false;
        }

        // Load nth entry
        private void loadEntry(int page)
        {
            // Create an array of data from individual entries
            string[] data = entries[--page].Split("\n");

            Label[] field =     // Initialize array of the fields from our app
                { submission, temp, name, gender, address, status, contacts };

            // Set each field to its corresponding data from text database
            for (int i = 0; i < field.Length; i++) field[i].Text = data[i];
        }

        // Handle button click
        private void transferPage(object sender, EventArgs e)
        {
            int list = entries.Length; int space = pages.Text.IndexOf(' ');
            int page = Int32.Parse(pages.Text.Substring(0, space));
                
            // Increment or decrement page
            if ((sender as Button).Name == "right") page++; else page--;

            // Disable back & forward buttons
            if (page == 1) left.Enabled = false; else left.Enabled = true;
            if (page == list) right.Enabled = false; else right.Enabled = true;

            // Load necessary changes
            loadEntry(page); pages.Text = $"{page} out of {list}";
        }
    }
}
