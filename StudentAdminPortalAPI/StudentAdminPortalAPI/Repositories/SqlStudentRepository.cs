﻿using Microsoft.EntityFrameworkCore;
using StudentAdminPortalAPI.DataModels;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace StudentAdminPortalAPI.Repositories
{
    public class SqlStudentRepository : IStudentRepository
    {
        private readonly StudentAdminContext context;

        public SqlStudentRepository(StudentAdminContext context)
        {
            this.context = context;
        }
        public async Task<List<Student>> GetAllStudentsAsync()
        {
            return await context.Student.Include(nameof(Gender)).Include(nameof(Address
                )).ToListAsync();
        }
    }
}
