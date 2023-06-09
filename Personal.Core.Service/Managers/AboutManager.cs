﻿using Personal.Core.Core.Models;
using Personal.Core.Repository.Interfaces;
using Personal.Core.Service.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace Personal.Core.Service.Managers
{
    public class AboutManager : IAboutService
    {
        private readonly IAboutRepository _aboutRepository;

        public AboutManager(IAboutRepository aboutRepository)
        {
            _aboutRepository = aboutRepository;
        }

        public async Task ChangeStatusAllAsync(List<About> t, bool status)
        {
            if (status)
            {
                t.ForEach(b =>
                {
                    b.Status = false;
                });
            }
            else
            {
                t.ForEach(b =>
                {
                    b.Status = true;
                });
            }
            await _aboutRepository.ChangeStatusAllAsync(t);
        }

        public async Task ChangeStatusAsync(About t, bool status)
        {
            if (status)
            {
                t.Status = false;
            }
            else
            {
                t.Status = true;
            }
            await _aboutRepository.ChangeStatusAsync(t);
        }

        public async Task DeleteAllAsync(string tableName)
        {
            await _aboutRepository.DeleteAllAsync(tableName);
        }

        public async Task DeleteAsync(About t)
        {
            await _aboutRepository.DeleteAsync(t);
        }

        public async Task<About> GetByIdAsync(int id)
        {
            return await _aboutRepository.GetByIdAsync(id);
        }

        public async Task<int> GetClickCountAsync()
        {
            return await _aboutRepository.GetClickCountAsync();
        }

        public async Task InsertAsync(About t)
        {
            await _aboutRepository.InsertAsync(t);
        }

        public async Task<List<About>> ToListAsync()
        {
            return await _aboutRepository.ToListAsync();
        }

        public async Task<List<About>> ToListByFilterAsync(Expression<Func<About, bool>> filter)
        {
            return await _aboutRepository.ToListByFilterAsync(filter);
        }

        public async Task UpdateAsync(About t)
        {
            await _aboutRepository.UpdateAsync(t);
        }
    }
}
