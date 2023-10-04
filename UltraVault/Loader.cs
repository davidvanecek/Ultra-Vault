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

namespace UltraVault
{
    public partial class Loader : MetroSetForm
    {
        public Loader()
        {
            InitializeComponent();
        }

        private async void Loader_Load(object sender, EventArgs e)
        {
            // Čekání na 3 sekundy
            await Task.Delay(3000);

            // Zavření okna
            this.Close();

        }
    }
}
