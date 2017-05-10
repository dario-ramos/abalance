using RitEduClient.Entities;
using System.Data;

namespace RitEduClient
{
    public interface IOrganizationSearchView
    {
        void ShowResults(int pageIndex, int pageSize, int resultsCount, DataTable pageContents);
    }
}
