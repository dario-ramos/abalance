using System.Data;

namespace RitEduClient
{
    public interface IRitEduClientView
    {
        void ShowResults(int pageIndex, int pageSize, int resultsCount, DataTable pageContents);
    }
}
