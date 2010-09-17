using System;
using System.Globalization;
using Draugen.Data.Paging;
using Draugen.Services.Dtos;

namespace Draugen.Services.Assemblers
{
    public class PageInfoAssembler : IAssembler<PageInfoDto, IPageInfo>
    {
        public PageInfoDto WriteDto(IPageInfo domain, CultureInfo culture)
        {
            return new PageInfoDto()
                       {
                           Index = domain.Index,
                           Size = domain.Size,
                           TotalItems = domain.TotalItems,
                           TotalPages = domain.TotalPages
                       };
        }

        public IPageInfo Create(PageInfoDto dto)
        {
            throw new NotImplementedException();
        }
    }
}
