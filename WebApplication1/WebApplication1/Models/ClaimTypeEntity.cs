//auto-generated by IMX-ORM.exe. Do not change by hand. Fix the .EXE and regenerate or put new code in a partial class

using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace TestMVCAPI.Entities
{
	public class ClaimTypeEntity : Entity
	{
		[JsonProperty(NullValueHandling = NullValueHandling.Ignore)]
		public int ClaimTypeID { get; set; } = 0;

		[JsonProperty(NullValueHandling = NullValueHandling.Ignore)]
		public string ClaimType { get; set; }

		[JsonProperty(NullValueHandling = NullValueHandling.Ignore)]
		public string ClaimTypeShort { get; set; }

		[JsonProperty(NullValueHandling = NullValueHandling.Ignore)]
		public int? ClaimCategoryID { get; set; } = 1;

		[JsonProperty(NullValueHandling = NullValueHandling.Ignore)]
		public bool? IsDeleted { get; set; } = false;

	}
	public class ClaimTypeSearchParams
	{
		public string ClaimType = null;
		public string ClaimTypeShort = null;
		public int? ClaimCategoryID = null;
		public bool? IsDeleted = null;
	}
}
