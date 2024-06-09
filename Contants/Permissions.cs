namespace ProjetPFA.Contants
{
    public static class Permissions
    {
        public static List<string> GeneratePermissionsList(string module)
        {
            return new List<string>()
            {
                $"Permissions.{module}.View",
            };
        }

        public static List<string> GenerateAllPermissions()
        {
            var allPermissions = new List<string>();

            var modules = Enum.GetValues(typeof(Modules));

            foreach (var module in modules)
                allPermissions.AddRange(GeneratePermissionsList(module.ToString()));

            return allPermissions;
        }

        public static class Products
        {
            public const string View = "Permissions.Products.View";
            public const string Create = "Permissions.Products.Create";
            public const string Edit = "Permissions.Products.Edit";
            public const string Delete = "Permissions.Products.Delete";
        }
        public static class Enseingant
        {
            public const string View = "Permissions.Enseingant.View";
            public const string Create = "Permissions.Enseingant.Create";
            public const string Edit = "Permissions.Enseingant.Edit";
            public const string Delete = "Permissions.Enseingant.Delete";
        }
        public static class Etudiant
        {
            public const string View = "Permissions.Etudiant.View";
            public const string Create = "Permissions.Etudiant.Create";
            public const string Edit = "Permissions.Etudiant.Edit";
            public const string Delete = "Permissions.Etudiant.Delete";
        }
        public static class Finance
        {
            public const string View = "Permissions.Finance.View";
            public const string Create = "Permissions.Finance.Create";
            public const string Edit = "Permissions.Finance.Edit";
            public const string Delete = "Permissions.Finance.Delete";
        }
        public static class Marketing
        {
            public const string View = "Permissions.Marketing.View";
            public const string Create = "Permissions.Marketing.Create";
            public const string Edit = "Permissions.Marketing.Edit";
            public const string Delete = "Permissions.Marketing.Delete";
        }
        public static class Modele
        {
            public const string View = "Permissions.Modele.View";
            public const string Create = "Permissions.Modele.Create";
            public const string Edit = "Permissions.Modele.Edit";
            public const string Delete = "Permissions.Modele.Delete";
        }
    }
}