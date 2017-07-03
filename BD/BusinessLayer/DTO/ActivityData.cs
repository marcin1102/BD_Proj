using DataLayer;

namespace BusinessLayer.DTO
{
    public partial class ActivityData
	{
		public int Id { get; set; }
		public string Type { get; set; }
		public string Descr { get; set; }
        public string Status { get; set; }
        public string Result { get; set; }
		public int ReqId { get; set; }
        public int? WorkerId { get; set; }

        public virtual ActivitiesTypesDictionary ActivitiesTypesDictionary { get; set; }
        public virtual Request Request { get; set; }
        public virtual Worker Worker { get; set; }
    }
}
