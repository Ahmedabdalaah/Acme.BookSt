using Volo.Abp.Application.Dtos;

namespace Acme.BookSt.Authors
{
    public class GetAuthorListDto : PagedAndSortedResultRequestDto
    {
        public string? Filter { get; set; }
    }
}
