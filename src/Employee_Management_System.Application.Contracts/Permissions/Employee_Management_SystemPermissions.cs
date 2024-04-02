namespace Employee_Management_System.Permissions;

public static class Employee_Management_SystemPermissions
{
    public const string GroupName = "Employee_Management_System";

    //Add your own permission names. Example:
    //public const string MyPermission1 = GroupName + ".MyPermission1";
    public static class ADMIN
    {
        public const string Default = GroupName + ".Admin";
        public const string Create = GroupName + ".Create";
        public const string Edit = GroupName + ".Edit";
        public const string Delete = GroupName + ".Delete";
    }

    public static class HR
    {
        public const string Default = GroupName + ".HR";
        public const string Create = GroupName + ".Create";
        public const string Edit = GroupName + ".Edit";
        public const string Delete = GroupName + ".Delete";
    }

    public static class Employee
    {
        public const string Default = GroupName + ".Employee";
        public const string Create = GroupName + ".Create";
        public const string Edit = GroupName + ".Edit";
        public const string Delete = GroupName + ".Delete";
        public const string Read = GroupName + ".Read";
    }
}
