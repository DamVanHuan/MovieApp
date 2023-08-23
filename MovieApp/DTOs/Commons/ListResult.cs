namespace MovieApp.DTOs.Commons
{
    public class ListResult<T> where T : class
    {
        public bool HasNext { get; set; }
        public IEnumerable<T> Items { get; set; }
    }
}
