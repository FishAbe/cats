﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Cats.Services.Logistics;

namespace Cats.Helpers
{
    public static class DistributionHelper
    {
        
       
        public static decimal GetAllocated(int requisitionId, int fdiPid)
        {
            try
            {
                var sipcAllocationService = (ISIPCAllocationService)DependencyResolver.Current.GetService(typeof(ISIPCAllocationService));
                var allocatedAmount = sipcAllocationService.FindBy(s => s.RequisitionDetailID == requisitionId && s.FDPID == fdiPid).Select(p => p.AllocatedAmount).SingleOrDefault();
                return allocatedAmount;
            }
            catch (Exception)
            {

                return 0;
            }
            
        }
        public static decimal GetReceived(string requisitionNo, int fdpId)
        {
            try
            {
                var _distributionDetailService = (IDistributionDetailService)DependencyResolver.Current.GetService(typeof(IDistributionDetailService)); 
                var receivedAtFdp =
               _distributionDetailService.FindBy(
                   r => r.Distribution.RequisitionNo == requisitionNo && r.Distribution.FDPID == fdpId).Sum(
                       r => r.ReceivedQuantity);

                return receivedAtFdp;
            }
            catch (Exception)
            {

                return 0;
            }
           
        }

        public static decimal GetDispatched(int requisitionId,int fdpid)
        {
            return 600;
        }

        public static decimal GetDistributedQuantity(int requisitionId, int fdpId)
        {
            try
            {
                var _utilizationDetailService = (IUtilizationDetailSerivce)DependencyResolver.Current.GetService(typeof(IUtilizationDetailSerivce)); 
                return
                    _utilizationDetailService.FindBy(
                        r => r.UtilizationHeader.RequisitionId == requisitionId && r.FdpId == fdpId).Select(q=>q.DistributedQuantity).SingleOrDefault();
            }
            catch (Exception)
            {
                
                return 0;
            }
        }
    }
}