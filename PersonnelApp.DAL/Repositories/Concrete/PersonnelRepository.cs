using PersonnelApp.DAL.Repositories.Abstract;
using PersonnelApp.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PersonnelApp.DAL.Repositories.Concrete
{
    public class PersonnelRepository : Repository<Personnel>, IPersonnelRepository
    {
        public PersonnelRepository(PersonnelContext context) : base(context)
        {

        }
        public IEnumerable<Personnel> GetPersonnelsWithDepartment()
        {
            return PersonnelContext.Personnels.Include("Department").ToList();
        }

        public PersonnelContext PersonnelContext { get { return _context as PersonnelContext; } }
    }
}
