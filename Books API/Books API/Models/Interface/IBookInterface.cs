namespace Books_API.Models.Interface {
    public interface IBookInterface {

        
        List<Book> FindAll();
        Book Create(Book book);
        Book Update(Book book);
        void Delete(long id);
        Book FindById(long id);



    }
}
