using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace mod5_1302213030
{
    internal class SimpleDataBase<T>
    {
        private List<T> storedData;
        private List<DateTime> inputDates;

        public SimpleDataBase()
        {
            List<T> data = new List<T>();
        }

        public void AddNewData(T data)
        {
            this.storedData.Add(data);
            this.inputDates.Add(DateTime.Now);
        }
      
        public void PrintAllData()
        {
            for(int i = 0;i < storedData.Count; i++)
            {
                Console.WriteLine("Data" + i + " berisi "
                    + storedData + " , yang disimpan pada waktu UTC: "
                    + inputDates);
            }
            
        }



    }
}
