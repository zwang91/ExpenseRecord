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
    public async Task<IActionResult> CreateItemAsync(RecordItem recordItem)
    {
        try
        {
            var id = await _expenseRecordServices.CreateItemAsync(recordItem);
            return Ok(id);
        }
        catch
        {
            return NotFound();
        };
    }
}