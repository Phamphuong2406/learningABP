using Volo.Abp.Identity;

namespace Acme.BookStore;

public static class BookStoreConsts // khởi tạo các hằng số
{
    public const string DbTablePrefix = "App";
    public const string? DbSchema = null;
    public const string AdminEmailDefaultValue = IdentityDataSeedContributor.AdminEmailDefaultValue;
    public const string AdminPasswordDefaultValue = IdentityDataSeedContributor.AdminPasswordDefaultValue;
    public const int GenericTextMaxLength = 300;
    public const int DescriptionTextMaxLength = 1000;
}
