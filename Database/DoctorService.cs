using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace CourseWorkAt4.Database;

public partial class DoctorService
{
	[Key, DatabaseGenerated(DatabaseGeneratedOption.None)]
	public int PkIdDoctorService { get; set; }
	[ForeignKey("FkIdDoctor")]
	public int? FkIdDoctor { get; set; }
    public Doctor? DoctorId { get; set; }

	[ForeignKey("FkIdService")]
	public int? FkIdService { get; set; }
    public ServiceH? ServiceHId { get; set; }
}
