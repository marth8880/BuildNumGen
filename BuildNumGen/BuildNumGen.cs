using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BuildNumGen
{
    public partial class BuildNumGen : Form
    {
        public BuildNumGen()
        {
            InitializeComponent();
        }

        public string buildNum;
        public string yearsSinceProjectStart;
        public string releaseNum;

        private void BuildNumGen_Load(object sender, EventArgs e)
        {
            txt_YPS.Text = Properties.Settings.Default.YearsSinceProjectStart;
            txt_ReleaseNum.Text = Properties.Settings.Default.ReleaseNum;

            GenerateBuildNumber(true);
        }

        private string GenerateBuildNumber(bool copyToClipboard)
        {
            DateTime date = DateTime.Now;
            string month = date.Month.ToString("00");
            string day = date.Day.ToString("00");

            if (yearsSinceProjectStart == "0")
            {
                yearsSinceProjectStart = "";
            }

            buildNum = yearsSinceProjectStart + month + day + "/" + releaseNum;

            txt_BuildNum.Text = buildNum;

            if (copyToClipboard)
            {
                Clipboard.SetText(buildNum);
            }

            return buildNum;
        }

        private void txt_YPS_TextChanged(object sender, EventArgs e)
        {
            yearsSinceProjectStart = txt_YPS.Text;
            Properties.Settings.Default.YearsSinceProjectStart = yearsSinceProjectStart;
            Properties.Settings.Default.Save();

            GenerateBuildNumber(false);
        }

        private void txt_ReleaseNum_TextChanged(object sender, EventArgs e)
        {
            releaseNum = txt_ReleaseNum.Text;
            Properties.Settings.Default.ReleaseNum = releaseNum;
            Properties.Settings.Default.Save();

            GenerateBuildNumber(false);
        }

        private void btn_Generate_Click(object sender, EventArgs e)
        {
            GenerateBuildNumber(true);
        }
    }
}
