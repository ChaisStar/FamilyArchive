﻿namespace FamilyArchive.Model
{
    using System;

    public abstract class DbEntity : IDbEntity
    {
        public virtual Guid Id { get; set; }

        public virtual DateTime Created { get; set; }

        public virtual DateTime Updated { get; set; }
    }
}