namespace FamilyArchive.Model
{
    using System;
    using Microsoft.AspNetCore.Identity;

    public class UserRole : IdentityRole<Guid>, IDbEntity
    {
        public DateTime Created { get; set; }

        public DateTime Updated { get; set; }
    }
}