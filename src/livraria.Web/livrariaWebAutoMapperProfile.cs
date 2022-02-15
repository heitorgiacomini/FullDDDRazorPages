using AutoMapper;
using livraria.Authors;
using livraria.Books;

namespace livraria.Web
{
    public class livrariaWebAutoMapperProfile : Profile
    {
        public livrariaWebAutoMapperProfile()
        {
            CreateMap<BookDto, CreateUpdateBookDto>();
            CreateMap<Pages.Authors.CreateModalModel.CreateAuthorViewModel,
                      CreateAuthorDto>();

            CreateMap<AuthorDto, Pages.Authors.EditModalModel.EditAuthorViewModel>();
            CreateMap<Pages.Authors.EditModalModel.EditAuthorViewModel,
                      UpdateAuthorDto>();
        }
    }
}