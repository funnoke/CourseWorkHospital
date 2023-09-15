using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CourseWorkAt4.Database
{
	public partial class CheckInDoctor
	{
		[Column("PK_IdCheckInDoctor")]
		[Key, DatabaseGenerated(DatabaseGeneratedOption.None)]
		public int PkIdCheckInDoctor { get; set; }
		public DateTime? DateCheckIn { get; set; }
		public bool? CheckIn { get; set; }
		[ForeignKey("FkIdSchedule")]
		public int? FkIdSchedule { get; set; }
		public Schedule? ScheduleId { set; get; }

	}
}
