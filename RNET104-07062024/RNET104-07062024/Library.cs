namespace RNET104_07062024;

public class Library
{
    private static List<Book> _books = new List<Book>();

    public static List<Book> FindAllBooks(string str)
    {
        List<Book> result = null;
       
        //v1 - LinQ
        result = _books.FindAll(b => b.Name == str || b.AuthorName == str || b.Code == str);

        //v2 - Custom
        foreach (var book in _books)
        {
            if (book.Name == str || book.Code == str || book.AuthorName == str)
            {
                result.Add(book);
            }
            
        }

        return result;
    }

    public override string ToString()
    {
        string result = String.Empty;
        foreach (var book in _books)
        {
            result += $" Code: {book.Code} \n Name: {book.Name} \n Author name: {book.AuthorName}";
            result = "\n --------------------";
        }
        return result;
    }
}
