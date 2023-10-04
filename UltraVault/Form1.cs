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

        }
        string passwordGenerated;
        string encryptedPass;
        private void metroSetButton1_Click(object sender, EventArgs e)
        {
            int passwordLenght = int.Parse(metroSetTextBox1.Text);
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
    }
}
