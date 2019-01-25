namespace lib
{
    public class KeyWord
    {
        public int Id { get; set; }

        public string Term { get; set; }
    }

    public class Contract
    {
        public int Id { get; set; }

        public KeyWord[] KeyWords { get; set; }

        public System.DateTime CreatedDate { get; set; }
    }
}
