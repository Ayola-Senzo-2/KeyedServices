using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace KeyedService.Services
{
    public interface IStorageService
    {
        void UploadData(string someData);
    }
}