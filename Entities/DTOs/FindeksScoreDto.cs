using Core.Entities;

namespace Entities.Concrete
{
    public class FindeksScoreDto : IDto
    {
        public int CustomerFindeksScore { get; set; }
        public int CarMinFindeksScore { get; set; }
    }
}
