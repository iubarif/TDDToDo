using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Domain;

namespace TDD.ToDo.Test
{
	[TestClass]
	public class ToDo_Test
	{
		public ToDo_Test()
		{

		}

		[TestMethod]
		public void ToDo_Test_CanCreateToDoObject_ShouldReturn_True()
		{
			var todo = new Todo();

			Assert.IsNotNull(todo);
		}

		//[TestMethod]
		//public void ToDo_Test_CanCreateToDoObject_ShouldReturn_True()
		//{
		//	var todo = new Todo();

		//	Assert.IsNotNull(todo);
		//}


	}
}
