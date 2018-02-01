namespace FamilyArchive.Model
{
    using System;
    using Microsoft.AspNetCore.Identity;

    public class User : IdentityUser<Guid>, IDbEntity
    {
        public DateTime Created { get; set; }

        public DateTime Updated { get; set; }
    }
}