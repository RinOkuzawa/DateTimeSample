using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DateTimeSample {
    public partial class Form1 : Form {
        private DateTime now = DateTime.Now;
        public Form1() {
            InitializeComponent();
            tbNowDisp.Text = now.ToString();
        }

        private void btNow_Click(object sender, EventArgs e) {
            now = DateTime.Now;
            //tbNowDisp.Text = now.Year + "年 " + now.Month + "月" + now.Day + "日 " + now.Hour + "時" + now.Minute + "分" + now.Second + "秒";
            //↓「/」区切りの日付になる
            tbNowDisp.Text = now.ToShortDateString();
            //↓日付のみの日本語表記になる
            //tbNowDisp.Text = now.ToString("D");　yy/M/d H:m
        }

        private void btBefore_Click(object sender, EventArgs e) {
            var outputDateB = (now.AddDays(-(double)nudDayBeforeAfter.Value)).AddMonths(-(int)nudMonthBeforeAfter.Value); //メソッドチェーン
            

            tbDayBeforeAfter.Text = outputDateB.ToShortDateString();

            tbUruu.Text = DateTime.IsLeapYear(outputDateB.Year) ? "閏年です" : "平年です";
            //if (DateTime.IsLeapYear(nowBefore.Year)) {
            //    tbUruu.Text = "うるう年です";
            //} else {
            //    tbUruu.Text = "平年です";
            //}
        }

        private void btAfter_Click(object sender, EventArgs e) {
            var outputDateA = (now.AddDays((double)nudDayBeforeAfter.Value)).AddMonths((int)nudMonthBeforeAfter.Value); //メソッドチェーン

            tbDayBeforeAfter.Text = outputDateA.ToShortDateString();

            tbUruu.Text = DateTime.IsLeapYear(outputDateA.Year) ? "閏年です" : "平年です";

        }
        private void btBirthDays_Click(object sender, EventArgs e) {
            DateTime birthday = new DateTime(monthCalendar1.SelectionStart.Year, monthCalendar1.SelectionStart.Month, monthCalendar1.SelectionStart.Day);

            Double interval = Math.Truncate((now - birthday).TotalDays);
            
            tbBirthDays.Text = interval.ToString();

        }

        private void btClear_Click(object sender, EventArgs e) {
            nudDayBeforeAfter.Value = 0;
            nudMonthBeforeAfter.Value = 0;
            tbDayBeforeAfter.Text = "";
            tbUruu.Text = "";
        }

        void initButton() {
            if (tbBirthDays == null) {
                btBirthDays.Enabled = false;
            }
        }

        private void Form1_Load(object sender, EventArgs e) {

        }

        private void monthCalendar1_DateSelected(object sender, DateRangeEventArgs e) {
            
        }

        private void btFireWrite_Click(object sender, EventArgs e) {
            var lines = new string[]
                {
                    "祇園"
                };
        }
    }
}
