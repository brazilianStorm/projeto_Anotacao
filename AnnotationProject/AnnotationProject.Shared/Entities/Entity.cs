using System;

namespace AnnotationProject.Shared.Entities
{
    public class Entity
    {
        public string Id { get; private set; }

        protected Entity()
        {
            Id = Guid.NewGuid().ToString().Replace("-", "");
        }
    }
}
