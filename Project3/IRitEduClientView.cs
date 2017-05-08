using System.Data;

namespace RitEduClient
{
    public interface IRitEduClientView
    {
        void ShowResults(int pageIndex, string pageInfo, DataTable pageContents);
    }
}
