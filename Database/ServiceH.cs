using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace CourseWorkAt4.Database;

public partial class ServiceH
{
	[Key, DatabaseGenerated(DatabaseGeneratedOption.None)]
	public int PkIdService { get; set; }

    public string? NameService { get; set; }
}
