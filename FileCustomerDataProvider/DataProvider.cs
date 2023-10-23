using CustomerConsole.FileCustomerDataProvider.IFileCustomerDataProvider;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CustomerConsole.Data;

namespace CustomerConsole.FileCustomerDataProvider
{
    public class DataProvider<T> : IDataProvider<T> where T : class
    {
        private readonly ApplicationDbContext dbContext; // DbContext for Entity Framework

        public DataProvider(ApplicationDbContext dbContext)
        {
            this.dbContext = dbContext;
        }

        public List<T> GetDataList()
        {
            return dbContext.Set<T>().ToList();
        }

        public List<T> GetDataListByRange(Func<T, bool> filter)
        {
            return dbContext.Set<T>().Where(filter).ToList();
        }

        public void SaveData(T data)
        {
            dbContext.Set<T>().Add(data);
            dbContext.SaveChanges();
        }

        public void SaveDataList(List<T> dataList)
        {
            dbContext.Set<T>().AddRange(dataList);
            dbContext.SaveChanges();
        }
    }
}
