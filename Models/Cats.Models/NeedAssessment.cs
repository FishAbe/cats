﻿using System;
using System.Collections.Generic;


namespace Cats.Models
{
    public  partial class NeedAssessment
    {
        public NeedAssessment()
        {
            this.HRDs = new List<HRD>();
            this.NeedAssessmentHeaders = new List<NeedAssessmentHeader>();
        }

        public int NeedAID { get; set; }
        public int Region { get; set; }
        public string Season { get; set; }
        public System.DateTime NeedADate { get; set; }
        public Nullable<int> NeddACreatedBy { get; set; }
        public Nullable<bool> NeedAApproved { get; set; }
        public Nullable<int> NeedAApprovedBy { get; set; }
        public string Remark { get; set; }
        public virtual AdminUnitType AdminUnitType { get; set; }
        public virtual ICollection<HRD> HRDs { get; set; }
        public virtual UserProfile UserProfile { get; set; }
        public virtual UserProfile UserProfile1 { get; set; }
        public virtual ICollection<NeedAssessmentHeader> NeedAssessmentHeaders { get; set; }
    }
}
