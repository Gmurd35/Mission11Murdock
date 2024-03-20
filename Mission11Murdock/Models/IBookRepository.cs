namespace Mission11Murdock.Models
{
    public interface IBookRepository
    {
        public IQueryable<Book> Books { get; }
    }
}
