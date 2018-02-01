namespace FamilyArchive.Model
{
    using System;

    public interface IDbEntity
    {
        Guid Id { get; set; }

        DateTime Created { get; set; }

        DateTime Updated { get; set; }
    }
}