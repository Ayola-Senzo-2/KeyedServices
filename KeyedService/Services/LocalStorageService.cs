using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace KeyedService.Services
{
    public class LocalStorageService: IStorageService
    {
        public void UploadData(string someData)
        {
            Console.WriteLine("Data uploaded on Local Machine");
        }
    }
}