﻿using Personal.Core.Core.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Personal.Core.Service.Services
{
    public interface IProjectService : IRepositoryService<Project>
    {
        Task<List<Project>> OrderByDescendingProject();

    }
}
