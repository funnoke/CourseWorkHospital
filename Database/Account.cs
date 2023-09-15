using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace CourseWorkAt4.Database;

public partial class Account
{
	[Key, DatabaseGenerated(DatabaseGeneratedOption.None)]
	public int PkIdAcc { get; set; }

    public string? LoginAcc { get; set; }

    public string? PasswordAcc { get; set; }

    public bool? OnlineAcc { get; set; }

    public string? TypeAcc { get; set; }

	[ForeignKey("FKIdDoctor")]
	public int? FKIdDoctor { get; set; }
	public Doctor? DoctorId { get; set; }

	[ForeignKey("FKIdPatient")]
	public int? FKIdPatient { get; set; }
	public Patient? PatientId { get; set; }

	[ForeignKey("FKIdMedS")]
	public int? FKIdMedS { get; set; }
	public MedicalSecretary? MedicalSecretaryId { get; set; }

}
