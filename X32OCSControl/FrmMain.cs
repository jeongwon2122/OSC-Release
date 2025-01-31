using DevExpress.XtraEditors;
using System.Collections.Generic;
using System.ComponentModel;
using X32OSCControl.Data;
using X32OSCControl.Define;
using System.Linq;
using System.Drawing;
using SharpOSC;
using System;

namespace X32OCSControl
{
    public partial class FrmMain : XtraForm
    {
        #region [Private] 변수
        private Dictionary<int, clsX32Channel> dicChannel = new Dictionary<int, clsX32Channel>();
        public BindingList<clsX32Channel> lstChannel = new BindingList<clsX32Channel>();
        #endregion

        #region [Public] 생성자
        public FrmMain()
        {
            InitializeComponent();
            for (int i = 0; i < globalUI.ogPlayHandler.lstChannel.Count; i++)
            {
                if (globalUI.ogPlayHandler.lstChannel[i].IsUse)
                    lstChannel.Add(globalUI.ogPlayHandler.lstChannel[i]);
            }

            for (int i = 0; i < lstChannel.Count; i++)
            {
                dicChannel.Add(lstChannel[i].index, lstChannel[i]);
            }

            this.gridControl1.DataSource = lstChannel;
        }
        #endregion

        #region [Private] Form Event 처리
        private void FrmMain_Shown(object sender, System.EventArgs e)
        {
            this.listBoxControl1.DataSource = globalUI.ogPlayHandler.lstWorship;
        }
        #endregion

        #region [Private] Evnet 처리
        private void listBoxControl1_SelectedIndexChanged(object sender, System.EventArgs e)
        {
            clsOrderOfWorship worship = listBoxControl1.SelectedItem as clsOrderOfWorship;
            groupControl2.Text = $"** {worship.worship_name} -- Mute 설정";

            for (int i = 0; i < lstChannel.Count; i++)
            {
                lstChannel[i].IsChecked = false;
            }

            List<clsLinkWorshipNChannel> lstCurLink = globalUI.ogPlayHandler.lstLinkWorshipNChannel.Where(a => a.worship_index == worship.index).ToList();
            for (int i = 0; i < lstCurLink.Count; i++)
            {
                dicChannel[lstCurLink[i].channel_index].IsChecked = true;
            }

            this.gridView1.LayoutChanged();

            System.Diagnostics.Debug.WriteLine("Change");
        }

        private void btnEdit_Click(object sender, System.EventArgs e)
        {
            FrmLinkEditor frm = new FrmLinkEditor(listBoxControl1.SelectedItem as clsOrderOfWorship, lstChannel);
            frm.ShowDialog();

            this.gridView1.LayoutChanged();
        }

        private void gridView1_RowStyle(object sender, DevExpress.XtraGrid.Views.Grid.RowStyleEventArgs e)
        {
            if (e.RowHandle >= 0)
                e.Appearance.ForeColor = (gridView1.GetRow(e.RowHandle) as clsX32Channel).IsChecked ? Color.Blue : Color.Black;
        }

        private void btnSendX32Mute_Click(object sender, System.EventArgs e)
        {
            SendX32Mute();
        }

        private void listBoxControl1_DoubleClick(object sender, System.EventArgs e)
        {
            SendX32Mute();
        }
        #endregion

        #region [private] 함수
        private void SendX32Mute()
        {
            clsOrderOfWorship worship = listBoxControl1.SelectedItem as clsOrderOfWorship;
            string logMesg = $"* [{DateTime.Now.ToString("HH:mm:ss")}] Mute 설정 X32 전송 :: {worship.worship_name}\r\n";
            string onMesg = "  1 : ";
            string offMesg = "  0 : ";

            UDPSender oscSender = new UDPSender("192.168.0.46", 10023);
            for (int i = 0; i < lstChannel.Count; i++)
            {
                int set = lstChannel[i].IsChecked ? 1 : 0;
                var muteOnMessage = new OscMessage($"/ch/{lstChannel[i].index:00}/mix/on", set);
                oscSender.Send(muteOnMessage);

                if (lstChannel[i].IsChecked)
                    onMesg += $"{lstChannel[i].index:00} ";
                else 
                    offMesg += $"{lstChannel[i].index:00} ";

                System.Threading.Thread.Sleep(1);
            }

            logMesg +=  $"{onMesg}\r\n{offMesg}\r\n\r\n";
            textBox1.Text += logMesg;
            textBox1.SelectionStart = textBox1.Text.Length;
            textBox1.ScrollToCaret();
        }
        #endregion
    }
}

