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

        public ActivityTypeData ActivityTypeData { get; set; }
        public RequestData Request { get; set; }
        public WorkerData Worker { get; set; }
    }
}
