using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MetroSet_UI.Forms;
using System.IO;
using MetroSet_UI.Controls;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace UltraVault
{
    public partial class UltraVault : MetroSetForm
    {
        public UltraVault()
        {
            InitializeComponent();
        }


        private void UltraVault_Load(object sender, EventArgs e)
        {
            metroSetDivider1.ForeColor = Color.Red;
            metroSetDivider2.ForeColor = Color.Red;
        }
        string passwordGenerated;
        string encryptedPass;
        private void metroSetButton1_Click(object sender, EventArgs e)
        {
            int passwordLenght = metroSetTrackBar1.Value;
            
            passwordGenerated = PasswordGenerator.GeneratePassword(passwordLenght, metroSetComboBox1.SelectedIndex);
           encryptedPass = Encryption.EncryptString(passwordGenerated);
            metroSetTextBox2.Text = passwordGenerated;
            metroSetTextBox3.Text = encryptedPass;
        }
       

        private void metroSetButton2_Click(object sender, EventArgs e)
        {
            SaveFileDialog saveFileDialog1 = new SaveFileDialog();
            saveFileDialog1.Filter = "txt files (*.txt)|*.txt|All files (*.*)|*.*";
            saveFileDialog1.RestoreDirectory = true;

            if (saveFileDialog1.ShowDialog() == DialogResult.OK)
            {
                File.WriteAllText(saveFileDialog1.FileName, passwordGenerated);
            }
        }

        private void metroSetButton3_Click(object sender, EventArgs e)
        {
            SaveFileDialog saveFileDialog1 = new SaveFileDialog();
            saveFileDialog1.Filter = "txt files (*.txt)|*.txt|All files (*.*)|*.*";
            saveFileDialog1.RestoreDirectory = true;

            if (saveFileDialog1.ShowDialog() == DialogResult.OK)
            {
                File.WriteAllText(saveFileDialog1.FileName, encryptedPass);
            }
        }

        private void metroSetButton4_Click(object sender, EventArgs e)
        {
            Application.Exit();

        }

        private void metroSetTrackBar1_Scroll(object sender)
        {
            labelValue.ForeColor= Color.White;
            labelValue.Text = metroSetTrackBar1.Value.ToString();
        }

        private void metroSetTrackBar1_Scroll(object sender, EventArgs e)
        {

        }
    }
}
