namespace DotinBankProject.Core.Entities.Base
{
    public interface IEntityBase<out TId>
    {
        TId Id { get; }
    }
}
