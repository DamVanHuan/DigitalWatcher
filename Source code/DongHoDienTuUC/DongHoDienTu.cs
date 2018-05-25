using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DongHoDienTuUC
{
    public partial class DongHoDienTu : UserControl
    {
        private static DongHoDienTu _Instance;

        private Image[] _Images;
        private int _CurMinute;
        private int _CurSecond;

        public delegate void TimeOut();
        public TimeOut TimeOver;

        public static DongHoDienTu getInstance()
        {
            if (_Instance == null)
            {
                _Instance = new DongHoDienTu();
                return _Instance;
            }
            else return _Instance;
        }

        public DongHoDienTu()
        {
            InitializeComponent();

            _CurMinute = 0;
            _CurSecond = -1;
            numMinutes.Maximum = 99;
            numSeconds.Maximum = 59;

            _Images = new Image[10];
            LoadImages();
        }

        private void LoadImages()
        {
            int i = 0;
            _Images[i++] = DongHoDienTuUC.Properties.Resources._0;
            _Images[i++] = DongHoDienTuUC.Properties.Resources._1;
            _Images[i++] = DongHoDienTuUC.Properties.Resources._2;
            _Images[i++] = DongHoDienTuUC.Properties.Resources._3;
            _Images[i++] = DongHoDienTuUC.Properties.Resources._4;
            _Images[i++] = DongHoDienTuUC.Properties.Resources._5;
            _Images[i++] = DongHoDienTuUC.Properties.Resources._6;
            _Images[i++] = DongHoDienTuUC.Properties.Resources._7;
            _Images[i++] = DongHoDienTuUC.Properties.Resources._8;
            _Images[i++] = DongHoDienTuUC.Properties.Resources._9;
        }

        private void SetNumberToImage(PictureBox pb1, PictureBox pb2, int number)
        {
            int num2 = number % 10; // hàng chục
            int num1 = number / 10; // hàng đơn vị

            pb1.Image = _Images[num1];
            pb2.Image = _Images[num2];
        }

        private void numMinutes_ValueChanged(object sender, EventArgs e)
        {
            SetNumberToImage(pbMinute1, pbMinute2, (int)numMinutes.Value);
        }

        private void numSeconds_ValueChanged(object sender, EventArgs e)
        {
            SetNumberToImage(pbSecond1, pbSecond2, (int)numSeconds.Value);
        }

        public bool Start()
        {
            _CurMinute = (int)numMinutes.Value;
            _CurSecond = (int)numSeconds.Value;

            if (_CurMinute == 0 && _CurSecond == 0)
            {
                return false;
            }

            SetNumberToImage(pbMinute1, pbMinute2, _CurMinute);
            SetNumberToImage(pbSecond1, pbSecond2, _CurSecond--);
            numMinutes.Enabled = false;
            numSeconds.Enabled = false;
            timer.Enabled = true;

            return true;
        }

        public void Pause()
        {
            timer.Enabled = false;
        }

        public void Stop()
        {
            timer.Enabled = false;
            numMinutes.Enabled = true;
            numSeconds.Enabled = true;

            if (_CurMinute > 0)
            {
                SetNumberToImage(pbMinute1, pbMinute2, 0);
            }

            if (_CurSecond > 0)
            {
                SetNumberToImage(pbSecond1, pbSecond2, 0);
            }
        }

        public void Resume()
        {
            timer.Enabled = true;
        }

        private void timer_Tick(object sender, EventArgs e)
        {
            if (_CurSecond < 0)
            {
                if (_CurMinute > 0)
                {
                    _CurSecond = 59;
                    SetNumberToImage(pbMinute1, pbMinute2, --_CurMinute);
                    SetNumberToImage(pbSecond1, pbSecond2, _CurSecond--);
                }
                else
                {
                    Stop();

                    if (TimeOver != null)
                    {
                        TimeOver();
                    }
                }
            }
            else SetNumberToImage(pbSecond1, pbSecond2, _CurSecond--);
        }

    }
}
