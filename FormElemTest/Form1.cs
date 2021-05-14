using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using FormElemTest;

namespace FormElemTest
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();

           
        }

        private void btn_color_change_Click(object sender, EventArgs e)
        {
            RichBoxEventsNew.FindAndChangeColor(
                rtbx_out, 
                tbx_word.Text, 
                getFileLocation(), 
                Color.Green, 
                Convert.ToInt32(tbx_start.Text),
                Convert.ToInt32(tbx_end.Text)
                );
        }

        private void btn_change_word_Click(object sender, EventArgs e)
        {
            RichBoxEventsNew.FindAndChangeWord(
                rtbx_out, 
                tbx_word.Text, 
                tbx_target.Text, 
                getFileLocation(), 
                Convert.ToInt32(tbx_start.Text),
                Convert.ToInt32(tbx_end.Text)
                );
        }
        
        private string getFileLocation()
        {
            using (OpenFileDialog openFileDialog = new OpenFileDialog() {
                InitialDirectory = Environment.CurrentDirectory,
                RestoreDirectory = true,
                Filter = "rtf files (*.rtf)|*.rtf"
            })
            {
                if (openFileDialog.ShowDialog() == DialogResult.OK)
                {
                    return openFileDialog.FileName;
                }
                else
                {
                    return "";
                }
            }
            
        }
    }
    
}
