//using Microsoft.AspNetCore.Mvc;
//using Microsoft.AspNetCore.Mvc.Testing;
//using FluentAssertions;
//using Microsoft.VisualStudio.TestPlatform.ObjectModel;
//using System.Net;
//using ExpenseRecord.Controllers;

//namespace ExpenseRecordTest;

//public class ExpenseRecordTest
//{
//    [Fact]
//    public async Task Test_Excepetion_Handling_When_Delete()
//    {
//        //arrange
//        var toDoItemService = new MockToDoItemService();
//        var controller = new ToDoListV2Controller(toDoItemService);

//        //act
//        var actionResult = await controller.DeleteItemAsync("abc");

//        //assert
//        Assert.Equal(typeof(NotFoundObjectResult), actionResult.GetType());
//        var notFoundResult = actionResult as NotFoundObjectResult;
//        Assert.Equal("ToDoItem not found", notFoundResult.Value.ToString());
//    }
//}
