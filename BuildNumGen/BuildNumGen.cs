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

        private void BuildNumGen_Load(object sender, EventArgs e)
        {

        }

        private void btn_Generate_Click(object sender, EventArgs e)
        {
            DateTime date = DateTime.Now;
            string month = date.Month.ToString("00");
            string day = date.Day.ToString("00");
            string releaseNum = Properties.Settings.Default.ReleaseNum.ToString("00");
            string yearsSinceRelease = Properties.Settings.Default.YearsSinceRelease.ToString();

            if (yearsSinceRelease == "0")
            {
                yearsSinceRelease = "";
            }

            buildNum = yearsSinceRelease + month + day + "/" + releaseNum;

            lbl_BuildNum.Text = buildNum;
        }
    }
}
