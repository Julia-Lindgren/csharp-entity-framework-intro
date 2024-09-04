﻿using exercise.webapi.Data;
using exercise.webapi.Models;

namespace exercise.webapi.Repository
{
    public class AuthorRepository : IAuthorRepository
    {
        DataContext _db;

        public AuthorRepository(DataContext db)
        {
            _db = db;
        }

        public async Task<Author> GetAuthor(int id)
        {
            Author author = await _db.Authors.FindAsync(id);
            if (author == null)
                throw new Exception("Author not found");

            return author;
        }

    }
}
