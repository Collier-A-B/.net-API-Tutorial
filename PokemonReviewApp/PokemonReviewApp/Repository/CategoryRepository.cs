﻿using Microsoft.EntityFrameworkCore;
using PokemonReviewApp.Data;
using PokemonReviewApp.Interface;
using PokemonReviewApp.models;

namespace PokemonReviewApp.Repository
{
    public class CategoryRepository : ICategoryRepository
    {
        private DataContext _context;
        public CategoryRepository(DataContext context) 
        {
            _context = context;
        }
        public bool CategoryExists(int id)
        {
            return _context.Categories.Any(c => c.Id == id);
        }

        public bool CreateCategory(Category category)
        {
            // Change Tracker
            // add, updating, modifying
            // connected vs disconnected
            // EntityState.Added
            // 
            _context.Add(category);

            return Save();
        }

        public ICollection<Category> GetCategories()
        {
            return _context.Categories.ToList();
        }

        public Category GetCategory(int id)
        {
            return _context.Categories.Where(e => e.Id == id).FirstOrDefault();
        }

        public ICollection<Pokemon> GetPokemonByCategory(int categoryId)
        {
            return _context.PokemonCategories.Where(e => e.CategoryId == categoryId).Select(c => c.Pokemon).ToList();
        }

        /**
         * Commits the current changes to the database
         * 
         * turns the changes of data context to SQL and performs operations on database
         */
        public bool Save()
        {
            var saved = _context.SaveChanges();
            return saved > 0 ? true : false;
        }
    }
}
