using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer.DTO
{
    public class RequestData
    {
        public string Descr { get; set; }
        public string Status { get; set; }
        public string Result { get; set; }
        public int Id { get; set; }

        public int ObjId { get; set; }
        public ObjectData Object { get; set; }

        public int? WorkerId { get; set; }
        public WorkerData Worker { get; set; }

		public ICollection<ActivityData> Activities { get; set; }
	}
}
