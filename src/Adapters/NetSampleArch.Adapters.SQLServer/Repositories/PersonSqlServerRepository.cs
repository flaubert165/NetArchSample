using System.Threading.Tasks;
using NetSampleArch.Adapters.SQLServer.Models;
using NetSampleArch.Adapters.SQLServer.Repositories.Interfaces;

namespace NetSampleArch.Adapters.SQLServer.Repositories
{
    public class PersonSqlServerRepository : IPersonSqlServerRepository
    {
        public PersonSqlServerRepository()
        {
            
        }
        
        public Task<Person> AddAsync(Person person)
        {
            throw new System.NotImplementedException();
        }
    }
}