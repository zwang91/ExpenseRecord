using ExpenseRecord.Item;

namespace ExpenseRecord.Services
{
    public interface IExpenseRecordServices
    {
        Task<string> CreateItem(RecordItem recordItem);
        Task<List<RecordItem>> GetAll();
        Task DeleteItem(string id);

    }
}
