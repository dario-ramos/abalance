using System.Data;

namespace RitEduClient
{
    public interface IPagedDataProvider
    {
        int GetRecordCount(string dataSetId);

        DataTable GetPage(string dataSetId, int pageIndex, int pageSize);
    }
}
