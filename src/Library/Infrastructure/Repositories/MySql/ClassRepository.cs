﻿using NetModular.Lib.Data.Abstractions;

namespace NetModular.Module.CodeGenerator.Infrastructure.Repositories.MySql
{
    public class ClassRepository : SqlServer.ClassRepository
    {
        public ClassRepository(IDbContext context) : base(context)
        {
        }
    }
}
