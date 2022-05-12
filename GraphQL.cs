using Models;

namespace GraphQL;

[ExtendObjectType("query")] // if you comment this attribut it can compile
public class BookQueries
{
    public Book GetBook() =>
        new Book
        {
            Title = "C# in depth.",
            Author = new Author
            {
                Name = "Jon Skeet"
            }
        };
}
