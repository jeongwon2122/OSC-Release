using Newtonsoft.Json;
using System.Collections.Generic;
using System.ComponentModel;
using System.Windows.Forms;

namespace X32OSCControl.Data
{
    public class clsPlayHandler
    {
        #region [Public] 변수
        public BindingList<clsOrderOfWorship> lstWorship;
        public List<clsX32Channel> lstChannel;

        public List<clsLinkWorshipNChannel> lstLinkWorshipNChannel;
        #endregion

        #region [Public] 함수
        public void ReadPlay()
        {
            string fileName = System.IO.Path.Combine(Application.StartupPath, "Play", "OrderOfWorship.ply");
            lstWorship = JsonConvert.DeserializeObject<BindingList<clsOrderOfWorship>>(System.IO.File.ReadAllText(fileName));

            fileName = System.IO.Path.Combine(Application.StartupPath, "Play", "X32Channel.ply");
            lstChannel = JsonConvert.DeserializeObject<List<clsX32Channel>>(System.IO.File.ReadAllText(fileName));

            fileName = System.IO.Path.Combine(Application.StartupPath, "Play", "LinkWorshipNChannel.ply");
            if (System.IO.File.Exists(fileName))
            {
                lstLinkWorshipNChannel = JsonConvert.DeserializeObject<List<clsLinkWorshipNChannel>>(System.IO.File.ReadAllText(fileName));
            }
            else
            {
                lstLinkWorshipNChannel = new List<clsLinkWorshipNChannel>();
                
                WriteLinkWorshipNChannel();
            }
        }

        public void WriteLinkWorshipNChannel()
        {
            string fileName = System.IO.Path.Combine(Application.StartupPath, "Play", "LinkWorshipNChannel.ply");
            System.IO.File.WriteAllText(fileName, JsonConvert.SerializeObject(lstLinkWorshipNChannel, Formatting.Indented));
        }
        #endregion
    }
}
