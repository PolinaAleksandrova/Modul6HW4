namespace MVC.Dtos;

public class PaginatedBrandsRequest<T>
{
    public int PageIndex { get; set; }

    public int PageSize { get; set; }

}