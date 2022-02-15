using AutoMapper;
using livraria.Books;

namespace livraria.Web
{
    public class livrariaWebAutoMapperProfile : Profile
    {
        public livrariaWebAutoMapperProfile()
        {
            CreateMap<BookDto, CreateUpdateBookDto>();
        }
    }
}