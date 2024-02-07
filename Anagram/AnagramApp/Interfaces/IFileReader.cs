using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace AnagramApp.Interfaces
{
    public interface IFileReader
    {
        static Task<List<string>> GetWords();
    }

}
