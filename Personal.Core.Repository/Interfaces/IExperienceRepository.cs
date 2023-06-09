﻿using Personal.Core.Core.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Personal.Core.Repository.Interfaces
{
    public interface IExperienceRepository : IModelRepository<Experience>
    {
        Task<List<Experience>> OrderByDescendingExperience();
    }
}
