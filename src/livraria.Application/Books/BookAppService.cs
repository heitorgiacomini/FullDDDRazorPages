using livraria.Permissions;
using System;
using Volo.Abp.Application.Dtos;
using Volo.Abp.Application.Services;
using Volo.Abp.Domain.Repositories;

namespace livraria.Books
{
    public class BookAppService : CrudAppService<Book, BookDto, Guid, PagedAndSortedResultRequestDto, CreateUpdateBookDto>,IBookAppService
    {
        public BookAppService(IRepository<Book, Guid> repository)
            : base(repository)
        {
            GetPolicyName = livrariaPermissions.Books.Default;
            GetListPolicyName = livrariaPermissions.Books.Default;
            CreatePolicyName = livrariaPermissions.Books.Create;
            UpdatePolicyName = livrariaPermissions.Books.Edit;
            DeletePolicyName = livrariaPermissions.Books.Delete;
        }
    }
}