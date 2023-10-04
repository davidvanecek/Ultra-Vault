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
    public partial class UltraVault : MetroSetForm
    {
        public UltraVault()
        {
            Loader loadForm = new Loader();
            loadForm.Show();
            Task.Delay(3000).ContinueWith(_ =>
            {
                // Počkej 3 sekundy a poté zavři načítací okno
                loadForm.Close();

                // Po zavření načítacího okna zobraz hlavní formulář
              
            });
            InitializeComponent();

        }


            private void UltraVault_Load(object sender, EventArgs e)
        {

        }
    }
}
