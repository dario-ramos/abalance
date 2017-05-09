using RitEduClient.Entities;
using System.Data;

namespace RitEduClient
{
    public interface IRitEduClientView
    {
        void ClearTabs();

        void LoadGeneralTab(OrganizationGeneralInfo generalInfo);

        void ShowResults(int pageIndex, int pageSize, int resultsCount, DataTable pageContents);
    }
}
