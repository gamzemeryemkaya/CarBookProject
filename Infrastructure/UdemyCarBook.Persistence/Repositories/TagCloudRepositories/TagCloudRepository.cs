using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UdemyCarBook.Application.Interfaces.TagCloudInterfaces;
using UdemyCarBook.Domain.Entities;
using UdemyCarBook.Persistence.Context;

namespace UdemyCarBook.Persistence.Repositories.TagCloudRepositories
{
    public class TagCloudRepository : ITagCloudRepository
    {
        private readonly CarBookContext _context;
        public TagCloudRepository(CarBookContext context)
        {
            _context = context;
        }
        public List<WordCloud> GetTagCloudsByBlogID(int id)
        {
            var values = _context.WordClouds.Where(x => x.BlogID == id).ToList();
            return values;
        }
    }
}
