namespace Acme.ClassManage.Permissions;

public static class ClassManagePermissions
{
    public const string GroupName = "ClassManage";

    public const string GroupNameCommon = "Common";
    //Add your own permission names. Example:
    //public const string MyPermission1 = GroupName + ".MyPermission1";
    public class LopHoc
    {
        public const string Default = GroupNameCommon + ".LopHoc";
        public const string Update = Default + ".Update";
        public const string Create = Default + "create";
        public const string Delete = Default + "delete";

    }
    public class SinhVien
    {
        public const string Default = GroupNameCommon + ".SinhVien";
        public const string Update = Default + ".Update";
        public const string Create = Default + "create";
        public const string Delete = Default + "delete";

    }

}
