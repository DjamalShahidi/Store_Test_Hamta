using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Store.Application.DTOs.Category
{
    public class AddFeatureToCategoryDto
    {
        public int CategoryId { get; set; }

        public List<int> FeatureIds { get; set; }

    }
}
