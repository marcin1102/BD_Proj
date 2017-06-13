using System;
using System.Collections.Generic;

namespace BusinessLayer.ValueObjects
{
    public partial class Activity
    {
        public string Descr { get; set; }
        public string Status { get; set; }
        public string Result { get; set; }
        public int Id { get; set; }
        public int ReqId { get; set; }
        public string Type { get; set; }
        public Nullable<int> WorkerId { get; set; }

        public virtual ActivitiesTypesDictionary ActivitiesTypesDictionary { get; set; }
        public virtual Request Request { get; set; }
        public virtual Worker Worker { get; set; }
    }
}
