﻿using Personal.Core.Core.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Personal.Core.Repository.Interfaces
{
    public  interface IProjectRepository : IModelRepository<Project>
    {
        Task<List<Project>> OrderByDescendingProject();

    }
}
