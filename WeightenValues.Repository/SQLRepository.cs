using System;
using System.Collections.Generic;
using System.Linq;
using WeightenValues.Repository.Interfaces;
using WeightenValues.Repository.DTO;

namespace WeightenValues.Repository
{
    public class SQLRepository : IRepository
    {
        // #todo Would really love to use Dependency Injection instead for this :/
        private WeightedValuesDataContext _db;
        public SQLRepository()
        {
            _db = new WeightedValuesDataContext();
        }

        /// <summary>
        /// Gets all current educations from the database
        /// </summary>
        public Dictionary<int, string> GetEducations
        {
            get
            {
                return _db.Educations.ToDictionary(e => e.ID, e => e.Name);
            }            
        }

        /// <summary>
        /// Gets all current keywords from the database
        /// </summary>
        public Dictionary<int, string> GetKeywords
        {
            get
            {
                return _db.Keywords.ToDictionary(e => e.ID, e => e.Name);
            }
        }
    }
}