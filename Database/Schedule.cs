using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace CourseWorkAt4.Database;

	//[PrimaryKey(nameof(PkIdSchedule))]
public partial class Schedule
{
	[Column("PK_IdSchedule")]
	[Key, DatabaseGenerated(DatabaseGeneratedOption.None)]
	public int PkIdSchedule { get; set; }
    public TimeSpan? TimeStart { get; set; }
	public TimeSpan? TimeEnd { get; set; }
	[Column(TypeName = "DateTime")]
	public DateTime? DateInsert { get; set; }
	public int? DayOfWeek { get; set; }
	//[Column(TypeName = "time")]
	public TimeSpan? RangeTime { get; set; }

	// Foreign key for Doctor
	[ForeignKey("FkIdDoctor")]
	public int? FkIdDoctor { get; set; }
    public Doctor? DoctorId { set; get; }
	[NotMapped]
	public virtual ICollection<CheckInDoctor>? CheckInDoctorId { get; set; }
}
