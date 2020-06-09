using System;
using System.Collections.Generic;
using System.Text;

namespace BlazorMovie.Shared.DTO_s
{
    public class PaginationDTO
    {
        public int Page { get; set; } = 1;
        public int RecordsPerPage { get; set; } = 10;
    }
}
