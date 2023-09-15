using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace CourseWorkAt4.Database;

public partial class MedicalSecretary
{
	[Key, DatabaseGenerated(DatabaseGeneratedOption.None)]
	public int PkIdMedS { get; set; }

    public string? NameMedS { get; set; }
}
