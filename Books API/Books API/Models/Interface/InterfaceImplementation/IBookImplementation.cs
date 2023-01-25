using Books_API.Context;

namespace Books_API.Models.Interface.InterfaceImplementation {
    public class IBookImplementation : IBookInterface {

        private MySQLContext _context;
        public IBookImplementation(MySQLContext context) {
            _context = context;
        }

        public List<Book> FindAll() {
            
            List<Book> books = new List<Book>();
            return _context.Books.ToList();
           
        }

        public Book FindById(long id) {

            if(_context.Books.Any(b => b.Id == id)) {
                return _context.Books.SingleOrDefault(b => b.Id == id);
            } else {
                return null;
            }
            
        }

        public void Delete(long id) {
            if(_context.Books.Any(b => b.Id == id)) {
                try {                 
                    _context.Remove(_context.Books.FirstOrDefault(p => p.Id == id));
                    _context.SaveChanges();              
                }
                catch (Exception ex) {
                    throw;
                }
            }
        }

        public Book Update(Book book) {
            if(_context.Books.Any(p => p.Id == book.Id)) {
                try {
                    var oldBook = _context.Books.FirstOrDefault(p => p.Id == book.Id);
                    _context.Entry(oldBook).CurrentValues.SetValues(book);
                    _context.SaveChanges();
                    return book;
                }catch(Exception ex) {
                    throw;
                }
            } else {
                return null;
            }
        }

        public Book Create(Book book) {
            try {

                _context.Add(book);
                _context.SaveChanges();
                return book;

            }
            catch(Exception ex) {
                throw;
            }
        }


    }
}
