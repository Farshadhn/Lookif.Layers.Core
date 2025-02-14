namespace Lookif.Layers.Core.Model;

public class GetAllFilter
{
    public GetAllFilter()
    {
       
    }
    public GetAllFilter(int pageNumber,int pageSize)
    {
        PageNumber= pageNumber;
        PageSize= pageSize;
    }
    public int PageNumber { get; set; } = 1;
    public int PageSize { get; set; } = int.MaxValue;
} 