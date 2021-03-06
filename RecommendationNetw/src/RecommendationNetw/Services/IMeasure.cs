﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace RecommendationNetw.Services
{
    public interface ISimilarityMeasure : ISimilarityMeasure<IDictionary<string, int>>
    {
        
    }

    public interface ISimilarityMeasure<in TMassive>
    {
        double SimilarityLimit { get; }
        double Calculate(TMassive x, TMassive y);
    }
}
