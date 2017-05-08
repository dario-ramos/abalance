using System.Data;

namespace RitEduClient
{
    public interface IRitEduClientView
    {
        void ShowResults(int pageIndex, DataTable pageContents);
    }
}
