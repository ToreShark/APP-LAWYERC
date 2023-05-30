    using System.ComponentModel.DataAnnotations;

    namespace APP_LAWYER.DAL.Entities;

    public class BaseEntity
    {
        [Key]
        public Guid Id { get; set; }
    }