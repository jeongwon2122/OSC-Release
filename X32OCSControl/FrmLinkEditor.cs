using DevExpress.XtraEditors;
using System.Collections.Generic;
using System.ComponentModel;
using X32OSCControl.Data;
using X32OSCControl.Define;
using System.Linq;

namespace X32OCSControl
{
    public partial class FrmLinkEditor : XtraForm
    {
        #region [Private] 변수 
        private clsOrderOfWorship worship;
        #endregion

        #region [Public] 생성자
        public FrmLinkEditor(clsOrderOfWorship iWorship, BindingList<clsX32Channel> lstChannel)
        {
            InitializeComponent();
            worship = iWorship;

            this.Text = $"** {worship.worship_name} - {this.Text}";

            this.gridControl1.DataSource = lstChannel;
        }

        private void btnClose_Click(object sender, System.EventArgs e)
        {
            this.Close();
        }

        private void btnSave_Click(object sender, System.EventArgs e)
        {
            List<clsLinkWorshipNChannel> lstNewLink = globalUI.ogPlayHandler.lstLinkWorshipNChannel.Where(x => x.worship_index != worship.index).ToList();
            BindingList<clsX32Channel> lstChannel = this.gridControl1.DataSource as BindingList<clsX32Channel>;

            for (int i = 0;  i < lstChannel.Count; i++)
            {
                if (lstChannel[i].IsChecked)
                {
                    clsLinkWorshipNChannel item = new clsLinkWorshipNChannel();
                    item.worship_index = worship.index;
                    item.channel_index = lstChannel[i].index;
                    lstNewLink.Add(item);
                }
            }

            globalUI.ogPlayHandler.lstLinkWorshipNChannel = lstNewLink;
            globalUI.ogPlayHandler.WriteLinkWorshipNChannel();

            this.Close();
        }
        #endregion
    }
}
