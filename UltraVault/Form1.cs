﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MetroSet_UI.Forms;

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

        private void metroSetButton1_Click(object sender, EventArgs e)
        {
            int passwordLenght = int.Parse(metroSetTextBox1.Text);
            string passwordGenerated = PasswordGenerator.GeneratePassword(passwordLenght, metroSetComboBox1.SelectedIndex);
            string encryptedPass = Encryption.EncryptString(passwordGenerated);
            metroSetTextBox2.Text = passwordGenerated;
            metroSetTextBox3.Text = encryptedPass;
        }

        private void metroSetLabel2_Click(object sender, EventArgs e)
        {

        }

        private void metroSetTextBox2_Click(object sender, EventArgs e)
        {

        }
    }
}
