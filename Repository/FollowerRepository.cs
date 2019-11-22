using Nepalists.Models;
using Nepalists.Data;
using System.Collections.Generic;
using System.Linq;
using Nepalists.GenericRepository;

namespace Nepalists.Repository
{
    public class FollowerRepository : GenericRepository<Follower>, IFollowerRepository
    {
        public FollowerRepository(ApplicationDbContext context) :base(context)
        {
        }
}
}
