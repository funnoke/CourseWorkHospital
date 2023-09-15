using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace CourseWorkAt4.Database;

public partial class AttandanceService
{
	[Key, DatabaseGenerated(DatabaseGeneratedOption.None)]
	public int PkIdAttandanceService { get; set; }
	[ForeignKey("FkIdService")]
	public int? FkIdService { get; set; }
    public ServiceH? ServiceHId { get; set; }

	[ForeignKey("FkIdAttandance")]
	public int? FkIdAttandance { get; set; }
    public Attandance? AttandanceId { get; set; }
}
