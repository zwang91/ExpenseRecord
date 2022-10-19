using ExpenseRecord.Item;
using ExpenseRecord.Services;
using System.Data.Entity;
using Microsoft.AspNetCore.Authentication.OAuth.Claims;

namespace ExpenseRecord.Services
{
    public class ExpenseRecordServices : IExpenseRecordServices
    {
        public List<RecordItem> recordItemLists = new List<RecordItem>();
        public async Task<string> CreateItem (RecordItem recordItem)
        {
            var id = Guid.NewGuid().ToString();
            var recordGetItem = new RecordItem
            {
                Id = id,
                Description = recordItem.Description,
                Type = recordItem.Type,
                Amount = recordItem.Amount,
                Date = DateTime.Now
            };
            recordItemLists.Add(recordGetItem);
            
            return id;

        }
        public async Task<List<RecordItem>> GetAll()
        {
            return recordItemLists;
        }

        public async Task DeleteItem (string id)
        {
            RecordItem item = recordItemLists.Find(x => x.Id == id);
            recordItemLists.Remove(item);
        }


        
        }
}
