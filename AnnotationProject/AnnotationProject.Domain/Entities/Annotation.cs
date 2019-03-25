using System;
using AnnotationProject.Shared.Entities;

namespace AnnotationProject.Domain.Entities
{
    public class Annotation : Entity
    {
        public string Name { get; private set; }        
        public string Description { get; private set; }
        public string User { get; private set; }
        public DateTime InsertDate { get; private set; }
        public DateTime? UpdateDate { get; private set; }

        public Annotation(string name, string description, string user)
        {
            Name = name;
            Description = description;
            User = user;
            InsertDate = DateTime.Now;
        }

        public void Update(string name, string description)
        {
            Name = name;
            Description = description;
            UpdateDate = DateTime.Now;
        }
    }
}
