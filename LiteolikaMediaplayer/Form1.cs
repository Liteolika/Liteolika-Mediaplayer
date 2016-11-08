using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Media;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WMPLib;

namespace LiteolikaMediaplayer
{


    public partial class Form1 : Form
    {
        private WindowsMediaPlayer player = new WindowsMediaPlayer();
        private string fileUrl = "";
        private IMediator _mediator;
        public Form1()
        {
            InitializeComponent();

            Timer timer = new Timer();
            timer.Interval = 10;
            timer.Tick += Timer_Tick;
            timer.Start();

            comboBox1.Items.Add(new PlayerSpeed { Speed = 1.4d, Text = "1.4" });
            comboBox1.Items.Add(new PlayerSpeed { Speed = 1.3d, Text = "1.3" });
            comboBox1.Items.Add(new PlayerSpeed { Speed = 1.2d, Text = "1.2" });
            comboBox1.Items.Add(new PlayerSpeed { Speed = 1.1d, Text = "1.1" });
            comboBox1.Items.Add(new PlayerSpeed { Speed = 1d, Text = "1" });
            comboBox1.Items.Add(new PlayerSpeed { Speed = 0.9d, Text = "0.9" });
            comboBox1.Items.Add(new PlayerSpeed { Speed = 0.8d, Text = "0.8" });
            comboBox1.Items.Add(new PlayerSpeed { Speed = 0.7d, Text = "0.7" });
            comboBox1.Items.Add(new PlayerSpeed { Speed = 0.6d, Text = "0.6" });
            comboBox1.Items.Add(new PlayerSpeed { Speed = 0.5d, Text = "0.5" });
            comboBox1.Items.Add(new PlayerSpeed { Speed = 0.4d, Text = "0.4" });
            comboBox1.Items.Add(new PlayerSpeed { Speed = 0.3d, Text = "0.3" });

            comboBox1.SelectedIndex = 4;

            comboBox1.SelectedIndexChanged += ComboBox1_SelectedIndexChanged;

            _mediator = new Mediator();
            Application.AddMessageFilter(new KeyboardMessageFilter(_mediator));

            _mediator.OnKeyPressed += _mediator_OnKeyPressed;

        }

        private void _mediator_OnKeyPressed(object sender, int key)
        {
            label4.Text = key.ToString();
            if (key == 97)
                player.controls.currentPosition = player.controls.currentPosition - 5;

            if (key == 98)
            {
                if (player.playState == WMPPlayState.wmppsPlaying)
                    player.controls.pause();
                else if (player.playState == WMPPlayState.wmppsPaused)
                    player.controls.play();
            }

            if (key == 99)
            {
                player.controls.currentPosition = player.controls.currentPosition + 5;
            }

            if (key == 100)
                player.controls.currentPosition = player.controls.currentPosition - 10;

            if (key == 102)
                player.controls.currentPosition = player.controls.currentPosition + 10;

            if (key == 103)
                player.controls.currentPosition = player.controls.currentPosition - 30;

            if (key == 105)
                player.controls.currentPosition = player.controls.currentPosition + 30;

        }

        private void ComboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            player.controls.pause();
            player.settings.rate = ((PlayerSpeed)comboBox1.SelectedItem).Speed;
            player.controls.play();
        }

        private void NumericUpDown1_ValueChanged(object sender, EventArgs e)
        {

        }


        private void Timer_Tick(object sender, EventArgs e)
        {
            if (player.currentMedia != null)
            {
                TimeSpan current;
                TimeSpan duration;
                TimeSpan.TryParse(player.controls.currentPositionString, out current);
                TimeSpan.TryParse(player.currentMedia.durationString, out duration);

                lblTimer.Text = player.controls.currentPositionString;
                lblTimerLeft.Text = (duration - current).ToString();

            }
        }

        private void buttonStart_Click(object sender, EventArgs e)
        {
            //player.URL = @"Q:\NP\Tidningar\2016\4\Material\FMI\812_0173 - Copy.WMA";
            if (!string.IsNullOrEmpty(fileUrl))
            {
                if (File.Exists(fileUrl))
                {
                    player.URL = fileUrl;
                    player.controls.play();
                }
            }

        }

        private void btnPause_Click(object sender, EventArgs e)
        {

            if (player.playState == WMPPlayState.wmppsPlaying)
                player.controls.pause();
            else if (player.playState == WMPPlayState.wmppsPaused)
                player.controls.play();
        }

        private void btnRev5_Click(object sender, EventArgs e)
        {
            player.controls.currentPosition = player.controls.currentPosition - 5;
        }

        private void btnFwd5_Click(object sender, EventArgs e)
        {
            player.controls.currentPosition = player.controls.currentPosition + 5;
        }

        private void btnRev10_Click(object sender, EventArgs e)
        {
            player.controls.currentPosition = player.controls.currentPosition - 10;
        }

        private void btnRev30_Click(object sender, EventArgs e)
        {
            player.controls.currentPosition = player.controls.currentPosition - 30;
        }

        private void btnFwd10_Click(object sender, EventArgs e)
        {
            player.controls.currentPosition = player.controls.currentPosition + 10;
        }

        private void btnFwd30_Click(object sender, EventArgs e)
        {
            player.controls.currentPosition = player.controls.currentPosition + 30;
        }

        private void btnStop_Click(object sender, EventArgs e)
        {
            player.controls.stop();
        }

        private void öppnaLjudfilToolStripMenuItem_Click(object sender, EventArgs e)
        {
            openFileDialog.FileName = "";
            openFileDialog.Title = "Öppna ljudfil";
            openFileDialog.Filter = "Ljudfiler (*.wav, *.wma, *.mp3) | *.wav; *.wma; *.mp3";
            var result = openFileDialog.ShowDialog();
            if (result == DialogResult.OK)
            {
                this.fileUrl = openFileDialog.FileName;
                lblFilename.Text = this.fileUrl;
            }

        }
    }
}
