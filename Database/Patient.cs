using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace CourseWorkAt4.Database;

public partial class Patient
{
	[Key, DatabaseGenerated(DatabaseGeneratedOption.None)]
	public int PkIdPatient { get; set; }

	public string? NamePatient { get; set; }

    public int? HealthInsurance { get; set; }
	[NotMapped]
	public virtual ICollection<Attandance>? AttandancesId { get; set; }
    [NotMapped] 
    public virtual ICollection<Appointment>? AppointmentsId { get; set; }
}
