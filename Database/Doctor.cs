using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace CourseWorkAt4.Database;

public partial class Doctor
{
	[Key, DatabaseGenerated(DatabaseGeneratedOption.None)]
	public int PkIdDoctor { get; set; }

    public string? NameD { get; set; }

    public string? Speciality { get; set; }
	[NotMapped]
	public virtual ICollection<Schedule>? SchedulesId { get; set; }
	[NotMapped]
	public virtual ICollection<Attandance>? AttancesId { get; set; }
	[NotMapped]
	public virtual ICollection<Appointment>? AppointmentsId { get; set; }
}
