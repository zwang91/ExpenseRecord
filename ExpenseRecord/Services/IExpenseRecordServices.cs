using ExpenseRecord.Item;

namespace ExpenseRecord.Services
{
    public interface IExpenseRecordServices
    {
        Task<string> CreateItemAsync(RecordItem recordItem);

    }
}
