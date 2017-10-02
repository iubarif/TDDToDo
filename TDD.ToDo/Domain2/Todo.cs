using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain
{
	public class Todo
	{
		public int Id { get; set; }
		public string Title { get; set; }
		public bool Close { get; set; }

		public List<TodoItem> ToDoItems { get; set; }
	}
}
