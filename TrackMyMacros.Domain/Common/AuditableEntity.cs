namespace TrackMyMacros.Domain.Common;

public class AuditableEntity
{
    public string? CreatedBy { get; set; } 
    public DateTime CreatedDate { get; set; }=DateTime.Now.ToUniversalTime();
    public string? LastModifiedBy { get; set; }
    public DateTime? LastModifiedDate { get; set; }=DateTime.Now.ToUniversalTime();
    
}