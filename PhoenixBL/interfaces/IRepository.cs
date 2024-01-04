namespace PhoenixBL.interfaces
{
    public class IRepository
    {
        public int id { get; set; }
        public string? name { get; set; }
        public string? avatar { get; set; }
        public bool isBookmark { get; set; }
    }
}