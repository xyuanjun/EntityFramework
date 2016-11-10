using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;

namespace Microsoft.EntityFrameworkCore
{
    /// <summary>
    ///     Allows configuration for an entity type to be factored into a separate class,
    ///     rather than in-line in <see cref="DbContext.OnModelCreating(ModelBuilder)"/>.
    ///     Derive from this class, override <see cref="Configure(EntityTypeBuilder{TEntity})"/>,
    ///     and then apply the configuration to the model using 
    ///     <see cref="ModelBuilder.ApplyConfiguration{TEntity}"/>
    ///     in <see cref="DbContext.OnModelCreating(ModelBuilder)"/>.
    /// </summary>
    /// <typeparam name="TEntity"> The entity type to be configured. </typeparam>
    public abstract class EntityTypeConfiguration<TEntity>
        where TEntity : class
    {
        /// <summary>
        ///     Override this method to specify the configuration for <typeparamref name="TEntity"/>.
        /// </summary>
        /// <param name="builder"> The builder to be used to configure the entity type. </param>
        public abstract void Configure(EntityTypeBuilder<TEntity> builder);
    }
}
