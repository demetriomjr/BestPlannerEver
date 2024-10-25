namespace models
{
    public abstract class BaseModel : ICloneable
    {
        public Guid Id { get; set; } = Guid.Empty;
        public bool IsDeleted { get; set; } = false;
        public DateTime? ImportedAt { get; set; } = default;
        public DateTime? CreatedAt { get; set; } = default;
        public DateTime? UpdatedAt { get; set; } = default;
        public DateTime? DeletedAt { get; set; } = default;

        public object Clone() => MemberwiseClone();
    }
}
