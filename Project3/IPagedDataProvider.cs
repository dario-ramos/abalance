using System.Data;

namespace RitEduClient
{
    public interface IPagedDataProvider
    {
        int RecordCount { get; }

        DataTable GetPage(int pageIndex, int pageSize);
    }
}
