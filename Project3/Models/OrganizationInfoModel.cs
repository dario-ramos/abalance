using RitEduClient.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RitEduClient.Models
{
    public class OrganizationInfoModel
    {
        public event Action<OrganizationGeneralInfo> GeneralTabLoaded;
        private ESDService _esdService;

        public OrganizationInfoModel(ESDService esdService)
        {
            _esdService = esdService;
        }

        public ESDService ESDService
        {
            get
            {
                return _esdService;
            }
        }

        //public async Task LoadTabs(int orgId)
        //{
        //    TabList tabs = await _model.GetTabs(orgId);
        //    foreach (Tab tab in tabs.Tabs)
        //    {
        //        if (tab.Name.ToUpper() == Enum.GetName(typeof(TabName), TabName.GENERAL))
        //        {
        //            OrganizationGeneralInfo generalInfo = await _model.GetOrganizationGeneralInfo(orgId);
        //            _view.LoadGeneralTab(generalInfo);
        //        }
        //    }
        //}

        public async Task LoadTabs(int orgId)
        {
            TabList tabs = await _esdService.GetTabs(orgId);
            foreach (Tab tab in tabs.Tabs)
            {
                if (tab.Name.ToUpper() == Enum.GetName(typeof(TabName), TabName.GENERAL))
                {
                    OrganizationGeneralInfo generalInfo = await _esdService.GetOrganizationGeneralInfo(orgId);
                    OnGeneralTabLoaded(generalInfo);
                }
            }
        }

        private void OnGeneralTabLoaded(OrganizationGeneralInfo generalInfo)
        {
            GeneralTabLoaded?.Invoke(generalInfo);
        }
    }
}
