using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DongHoDienTuUC
{
    public partial class Form1 : Form
    {
        private DongHoDienTu _DigitalTimer;

        public Form1()
        {
            InitializeComponent();
            
            _DigitalTimer = DongHoDienTu.getInstance();
            this.pnTimer.Controls.Add(_DigitalTimer);
            _DigitalTimer.TimeOver += TimeOverHandler;
        }

        private void btnResume_Click(object sender, EventArgs e)
        {
            btnPause.Enabled = true;
            btnResume.Enabled = false;
            this._DigitalTimer.Resume();
        }

        private void btnStop_Click(object sender, EventArgs e)
        {
            btnStop.Enabled = false;
            btnStart.Enabled = true;
            btnResume.Enabled = false;
            btnPause.Enabled = false;
            this._DigitalTimer.Stop();
        }

        private void btnPause_Click(object sender, EventArgs e)
        {
            btnPause.Enabled = false;
            btnResume.Enabled = true;
            this._DigitalTimer.Pause();
        }

        private void btnStart_Click(object sender, EventArgs e)
        {
            if (this._DigitalTimer.Start())
            {
                btnStart.Enabled = false;
                btnResume.Enabled = false;
                btnStop.Enabled = true;
                btnPause.Enabled = true;
            }
        }

        private void TimeOverHandler()
        {
            MessageBox.Show("Ring...ring...ring... Time is over!!!", "Notification");
            
            btnStart.Enabled = true;
            btnResume.Enabled = false;
            btnPause.Enabled = false;
            btnStop.Enabled = false;
        }
    }
}
