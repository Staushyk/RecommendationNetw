﻿using RecommendationNetw.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace RecommendationNetw.Abstracts
{
    public interface IQuestion : IQuestion<string>
    {

    }

    // Minimal Question model
    public interface IQuestion<TKey>    
    {
        TKey Id { get; }

        Category Category { get; set; }
    }
}
