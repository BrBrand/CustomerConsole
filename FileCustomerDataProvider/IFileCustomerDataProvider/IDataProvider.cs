using CustomerConsole.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CustomerConsole.FileCustomerDataProvider.IFileCustomerDataProvider
{
    public interface IDataProvider<T>
    {
        List<T> GetDataList();

        List<T> GetDataListByRange(Func<T, bool> filter);

        void SaveData(T data);

        void SaveDataList(List<T> dataList);
    }
}
