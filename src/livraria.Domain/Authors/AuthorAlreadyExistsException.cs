using Volo.Abp;

namespace livraria.Authors
{
    public class AuthorAlreadyExistsException : BusinessException
    {
        public AuthorAlreadyExistsException(string name)
            : base(livrariaDomainErrorCodes.AuthorAlreadyExists)
        {
            WithData("name", name);
        }
    }
}
