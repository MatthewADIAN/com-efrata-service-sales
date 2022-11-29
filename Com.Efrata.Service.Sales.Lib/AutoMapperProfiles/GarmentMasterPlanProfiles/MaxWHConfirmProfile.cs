using AutoMapper;
using Com.Efrata.Service.Sales.Lib.Models.GarmentMasterPlan.MaxWHConfirmModel;
using Com.Efrata.Service.Sales.Lib.ViewModels.GarmentMasterPlan.MaxWHConfirmViewModels;
using System;
using System.Collections.Generic;
using System.Text;

namespace Com.Efrata.Service.Sales.Lib.AutoMapperProfiles.GarmentMasterPlanProfiles
{
    public class MaxWHConfirmProfile : Profile
    {
        public MaxWHConfirmProfile()
        {
            CreateMap<MaxWHConfirm, MaxWHConfirmViewModel>()
                .ReverseMap();
        }
    }
}
