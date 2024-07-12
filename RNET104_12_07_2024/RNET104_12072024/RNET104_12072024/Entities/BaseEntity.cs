namespace RNET104_12072024.Entities;

public abstract class BaseEntity
{
    public int Id { get; set; }
    public DateTime CreatedDate { get; set; }
    public DateTime LastModifiedDate { get; set; }
    public DateTime DeletedDate { get; set; }   
    public bool IsDeleted { get; set; }
    public Status Status { get; set; }
}
