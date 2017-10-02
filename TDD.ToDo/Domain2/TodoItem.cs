using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain
{
	public class TodoItem
	{
		public int itemID { get; set; }
		public Todo Todo { get; set; }
		public string Title { get; set; }
		public string Description { get; set; }
		public bool Done { get; set; }

	}
}
