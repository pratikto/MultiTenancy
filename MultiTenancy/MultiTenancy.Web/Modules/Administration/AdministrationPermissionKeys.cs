
using Serenity.Extensibility;
using System.ComponentModel;

namespace MultiTenancy.Administration
{
    [NestedPermissionKeys]
    [DisplayName("Administration")]
    public class PermissionKeys
    {
        [Description("User, Role Management and Permissions")]
        public const string Security = "Administration:Security";

        [Description("Languages and Translations")]
        public const string Translation = "Administration:Translation";

        //define a Administration:Tenants permission that only admin user will have
        [Description("Tenants")]
        public const string Tenants = "Administration:Tenants";
    }
}
