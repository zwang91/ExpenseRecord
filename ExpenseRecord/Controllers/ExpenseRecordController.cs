using Microsoft.AspNetCore.Mvc;
using System;
using ExpenseRecord.Item;
using ExpenseRecord.Services;

namespace ExpenseRecord.Controllers;

[ApiController]
[Route("[Controller]")]
public class ExpenseRecordController : ControllerBase
{
    private readonly IExpenseRecordServices _expenseRecordServices;

    public ExpenseRecordController(IExpenseRecordServices expenseRecordServices)
    {
        _expenseRecordServices = expenseRecordServices;
    }

    [HttpPost]
    [Route("{Id}")]
    public async Task<IActionResult> CreateItem(RecordItem recordItem)
    {
        try
        {
            var id = await _expenseRecordServices.CreateItem(recordItem);
            return Ok(id);
        }
        catch
        {
            return NotFound();
        };
    }

    [HttpGet]
    public async Task<List<RecordItem>> GetAll()
    {
        var recordItems = await _expenseRecordServices.GetAll();
        return recordItems;
    }

    [HttpDelete]
    [Route("{Id}")]
    public async Task<IActionResult> DeleteItemAsync(string id)
    {
        try
        {
            await _expenseRecordServices.DeleteItem(id);
            return NoContent();
        }
        catch (Exception e)
        {
            return NotFound(e.Message);
        }
    }
}