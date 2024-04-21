using Acme.BookSt.Authors;
using Acme.BookSt.Books;
using AutoMapper;

namespace Acme.BookSt;

public class BookStApplicationAutoMapperProfile : Profile
{
    public BookStApplicationAutoMapperProfile()
    {
        /* You can configure your AutoMapper mapping configuration here.
         * Alternatively, you can split your mapping configurations
         * into multiple profile classes for a better organization. */
        CreateMap<Acme.BookSt.Book.Book, BookDto>();
        CreateMap<CreateUpdateBookDto, Acme.BookSt.Book.Book>();
        CreateMap<Author, AuthorDto>();
        CreateMap<Author, AuthorLookupDto>();



    }
}
