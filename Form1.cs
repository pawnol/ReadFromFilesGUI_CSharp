/*
 * Read From File GUI
 * Pawelski
 * 2/15/2022
 * This program reads numbers from a file and displays them in a list box.
 */

using System;
using System.IO;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ReadFromFileGUI
{
    public partial class ReadFromFileForm : Form
    {
        public ReadFromFileForm()
        {
            InitializeComponent();
        }

        private void readButton_Click(object sender, EventArgs e)
        {
            // Please add teh appropriate path below!
            const string PATH_FILE = @"";
            FileStream file = new FileStream(PATH_FILE, FileMode.Open, FileAccess.Read);
            StreamReader reader = new StreamReader(file);
            while(!reader.EndOfStream)
            {
                numbersListBox.Items.Add(reader.ReadLine());
            }
            reader.Close();
            file.Close();
        }
    }
}
