﻿using MediatR;
using Store.Application.DTOs.Feature;
using Store.Application.Responses;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Store.Application.Mediatr.Feature.Requests.Queries
{
    public class GetFeatures : IRequest<Response>
    {
    }
}
