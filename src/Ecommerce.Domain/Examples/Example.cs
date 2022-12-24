using System;
using Volo.Abp.Domain.Entities.Auditing;

namespace Ecommerce.Examples
{
    public class Example : FullAuditedAggregateRoot<Guid>
    {
        /// <summary>
        /// Example name
        /// </summary>
        public string Name { get; set; }

        /// <summary>
        /// Note
        /// </summary>
        public string Note { get; set; }

        protected Example()
        {
        }

        public Example(
            Guid id,
            string name,
            string note
        ) : base(id)
        {
            Name = name;
            Note = note;
        }
    }
}