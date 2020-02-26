﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BlazorForum.Models;
using Microsoft.EntityFrameworkCore;

namespace BlazorForum.Data.Repository
{
    public class Themes
    {
        private ApplicationDbContext _context;

        public Themes(ApplicationDbContext context)
        {
            _context = context;
        }

        public async Task<string> GetSelectedThemeNameAsync()
        {
            var theme = await _context.Themes.Where(p => p.IsSelected == true && !String.IsNullOrEmpty(p.TextDomain.Trim())).FirstOrDefaultAsync();
            return theme?.TextDomain;
        }

        public async Task<bool> RemoveThemesAsync()
        {
            var themes = _context.Themes;
            if(themes != null)
            {
                foreach(var theme in themes.ToList())
                {
                    themes.Remove(theme);
                }
                await _context.SaveChangesAsync();
                return true;
            }

            return false;
        }

        public async Task<bool> AddThemeAsync(string textDomain)
        {
            var themes = _context.Themes;
            var theme = new Theme
            {
                TextDomain = textDomain,
                IsSelected = true
            };
            themes.Add(theme);
            await _context.SaveChangesAsync();
            return true;
        }
    }
}
