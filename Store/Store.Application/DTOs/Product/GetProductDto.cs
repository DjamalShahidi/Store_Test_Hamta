﻿using Store.Application.DTOs.Common;
using Store.Domain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Store.Application.DTOs.Product
{
    record class GetProductDto:BaseDto
    {
        public string Title { get; set; }

        public string Code { get; set; }

        public string Description { get; set; }

        public string ImgUrl { get; set; }

        public int CategoryId { get; set; }

        public string CategoryTitle { get; set; }

        public List<GetProductDtoFeature> Features { get; set; }=new List<GetProductDtoFeature>();  
    }
    record class GetProductDtoFeature
    {
        public string Name { get; set; }

        public object Value { get; set; }
    }
}
