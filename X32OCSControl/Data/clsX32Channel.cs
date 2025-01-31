using Newtonsoft.Json;
using System.ComponentModel;

namespace X32OSCControl.Data
{
    public class clsX32Channel
    {
        [DisplayName("채널")]
        public int index { get; set; } = 1;
        [DisplayName("분류")]
        public string channel_group { get; set; } = "무선마이크";

        [DisplayName("이름")]
        public string channel_name { get; set; } = "";
        public bool IsUse { get; set; } = false;

        [JsonIgnore]
        [DisplayName("사용선택")]
        public bool IsChecked { get; set; } = false;

        [JsonIgnore]
        [DisplayName("사용여부")]
        public string DispCheck { get { return IsChecked ? "사용" : ""; } }
    }
}
