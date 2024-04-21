using Acme.BookSt.Authors;
using Acme.BookSt.Books;
using AutoMapper;

namespace Acme.BookSt.Web;

public class BookStWebAutoMapperProfile : Profile
{
    public BookStWebAutoMapperProfile()
    {
        //Define your AutoMapper configuration here for the Web project.
        CreateMap<BookDto, CreateUpdateBookDto>();
        CreateMap<Pages.Authors.CreateModalModel.CreateAuthorViewModel,
                  CreateAuthorDto>();
        CreateMap<AuthorDto, Pages.Authors.EditModalModel.EditAuthorViewModel>();
        CreateMap<Pages.Authors.EditModalModel.EditAuthorViewModel,
                  UpdateAuthorDto>();
        CreateMap<Pages.Books.CreateModalModel.CreateBookViewModel, CreateUpdateBookDto>();
        CreateMap<BookDto, Pages.Books.UpdateModalModel.EditBookViewModel>();
        CreateMap<Pages.Books.UpdateModalModel.EditBookViewModel, CreateUpdateBookDto>();

    }
}
