using AutoMapper;
using livraria.Authors;
using livraria.Books;

namespace livraria;

public class livrariaApplicationAutoMapperProfile : Profile
{
    public livrariaApplicationAutoMapperProfile()
    {
        CreateMap<Book, BookDto>();
        CreateMap<CreateUpdateBookDto, Book>();
        CreateMap<Author, AuthorDto>();

        /* You can configure your AutoMapper mapping configuration here.
         * Alternatively, you can split your mapping configurations
         * into multiple profile classes for a better organization. */
    }
}
