﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BlazorForum.Models;
using Microsoft.EntityFrameworkCore;

namespace BlazorForum.Data.Repository
{
    public class ForumCategories
    {
        private readonly ApplicationDbContext _context;

        public ForumCategories(ApplicationDbContext context)
        {
            _context = context;
        }

        public async Task<List<ForumCategory>> GetForumCategoriesAsync()
        {
            return await _context.ForumCategories.ToListAsync();
        }

        public async Task<List<ForumCategory>> GetForumCategoriesAsync(int forumId)
        {
            return await _context.ForumCategories.Where(p => p.ForumId == forumId).ToListAsync();
        }

        public async Task<ForumCategory> GetForumCategory(int categoryId)
        {
            return await _context.ForumCategories.Where(p => p.ForumCategoryId == categoryId).FirstOrDefaultAsync();
        }

        public async Task<bool> CreateCategoryAsync(ForumCategory newCategory)
        {
            var categories = _context.ForumCategories;
            await categories.AddAsync(newCategory);
            await _context.SaveChangesAsync();
            return true;
        }

        public async Task<bool> UpdateCategoryAsync(ForumCategory editedCategory)
        {
            var category = _context.ForumCategories.Where(p => p.ForumCategoryId == editedCategory.ForumCategoryId).FirstOrDefault();
            category.Title = editedCategory.Title;
            category.Description = editedCategory.Description;
            category.ForumId = editedCategory.ForumId;
            category.Rank = editedCategory.Rank;
            await _context.SaveChangesAsync();
            return true;
        }
    }
}
