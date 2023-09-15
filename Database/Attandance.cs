using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace CourseWorkAt4.Database;

public partial class Attandance
{
	[Key, DatabaseGenerated(DatabaseGeneratedOption.None)]
	public int PkIdAttandance { get; set; }

    public string? MedicalFindings { get; set; }

    public DateTime? DateAndTime { get; set; }

	[ForeignKey("FkIdDoctor")]
	public int? FkIdDoctor { get; set; }
    public Doctor? DoctorId { get; set; }

	[ForeignKey("FkIdPatient")]
	public int? FkIdPatient { get; set; }
    public Patient? PatientId { get; set; }

}
// buttonSaveSchange