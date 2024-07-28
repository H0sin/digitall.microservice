using System.ComponentModel.DataAnnotations;

namespace Domain.Common;

public abstract class BaseEntity<T> : BaseEntity where T : notnull
{
    [Key] public T? Id { get; set; }

    /// <summary>
    ///     when add entity set create date
    /// </summary>
    public DateTime CreateDate { get; set; }

    /// <summary>
    ///     when update entity set modified date
    /// </summary>
    public DateTime ModifiedDate { get; set; }

    /// <summary>
    ///     work on the creator
    /// </summary>
    public long CreateBy { get; set; }

    /// <summary>
    ///     work on the updater
    /// </summary>
    public long ModifyBy { get; set; }

    /// <summary>
    ///     entity deleted
    /// </summary>
    public bool IsDelete { get; set; }
}

public abstract class BaseEntity
{
    [Key] public virtual long Id { get; set; }

    /// <summary>
    ///     when add entity set create date
    /// </summary>
    public DateTime CreateDate { get; set; }

    /// <summary>
    ///     when update entity set modified date
    /// </summary>
    public DateTime ModifiedDate { get; set; }

    /// <summary>
    ///     work on the creator
    /// </summary>
    public long CreateBy { get; set; }

    /// <summary>
    ///     work on the updater
    /// </summary>
    public long ModifyBy { get; set; }

    /// <summary>
    ///     entity deleted
    /// </summary>
    public bool IsDelete { get; set; }
}