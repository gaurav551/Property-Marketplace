using Nepalists.Models;
using Nepalists.Data;
using System.Collections.Generic;
using System.Linq;
using Nepalists.GenericRepository;

namespace Nepalists.Repository
{
    public class ProfileRepository: GenericRepository<Profile>, IProfileRepository
    {
        public ProfileRepository(ApplicationDbContext context) :base(context)
        {
        }
}
}