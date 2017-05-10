using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RitEduClient.Views
{
    public interface IOrganizationInfoView
    {
        void LoadGeneralTab(string orgName, string orgDesc, string orgEmail,
                            string orgWebsite, string orgNumMembers, string orgNumCalls);

        void LoadLocationTab();
    }
}
