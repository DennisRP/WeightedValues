using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace WeightenValues.Repository.Interfaces
{
    // Define interface for easier replacement of storage
    public interface IRepository
    {
        Dictionary<int, string> GetEducations { get; }
        Dictionary<int, string> GetKeywords { get; }
    }
}