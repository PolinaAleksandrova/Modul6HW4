namespace MVC.Dtos;

public class PaginatedTypesRequest<T>
{
    public int PageIndex { get; set; }

    public int PageSize { get; set; }

}