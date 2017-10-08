namespace FamilyArchive.Data
{
    public interface IDbFactory
    {
        FamilyArchiveContext Init();
    }
}