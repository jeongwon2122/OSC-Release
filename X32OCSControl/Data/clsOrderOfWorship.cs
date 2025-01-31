namespace X32OSCControl.Data
{
    public class clsOrderOfWorship
    {
        public int index { get; set; } = 1;
        public string worship_name { get; set; } = "";

        public override string ToString()
        {
            return $"{index:000} {worship_name}";
        }
    }
}
