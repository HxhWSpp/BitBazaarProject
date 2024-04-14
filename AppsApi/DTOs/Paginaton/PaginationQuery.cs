namespace AppsApi.DTOs.Paginaton
{
    public class PaginationQuery
    {
        public PaginationQuery()
        {
            PageNumber = 1;
            PageSize = 30;
        }

        public PaginationQuery(int pageNumber , int pageSize)
        {
            PageNumber = pageNumber;
            if (pageSize > 20)
            {
                PageSize = 20;
            }
            else
            {
                PageSize = pageSize;
            }
        }

        public int PageNumber { get; set; }
        public int PageSize { get; set; }
    }
}
