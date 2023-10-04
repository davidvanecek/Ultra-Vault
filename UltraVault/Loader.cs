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
        private Timer progressBarTimer;
        private int progressBarValue;

        public Loader()
        {
            InitializeComponent();

            // Inicializace Timeru
            progressBarTimer = new Timer();
            progressBarTimer.Interval = 30; // Interval v milisekundách
            progressBarTimer.Tick += new EventHandler(ProgressBarTimer_Tick);
            


        }

        private void ProgressBarTimer_Tick(object sender, EventArgs e)
        {
            // Inkrementujeme hodnotu progressBaru
            progressBarValue++;
            metroSetProgressBar1.Value = progressBarValue;
            metroSetProgressBar1.ProgressColor = Color.Red;

            // Pokud jsme dosáhli 100, zastavíme Timer
            if (progressBarValue >= 100)
            {
                progressBarTimer.Stop();

                // Otevření Form1
                UltraVault mainForm = new UltraVault();
                mainForm.Show();

                // Zavření okna
                this.Hide();
            }
        }

        private async void Loader_Load(object sender, EventArgs e)
        {
            // Čekání na 3 sekundy
            await Task.Delay(3000);

            // Spustíme Timer
            progressBarTimer.Start();
        }
    }
}
