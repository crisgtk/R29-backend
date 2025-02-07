public static class varGlobal
{
    public static SocketSQL sql;
    public static string DataBaseUser { get; set; }
    public static string DataBasePass { get; set; }
    public static string DataBase { get; set; }
    public static string DataBasePI { get; set; }
    public static string Server { get; set; }
    public static string LicenseServer { get; set; }
    public static string UserSap { get; set; }
    public static string PassSap { get; set; }


    public static void Environment(string enviro)
    {
        switch (enviro)
        {

            case "prod":
                DataBase = "cygnusgroup_database";
                DataBaseUser = "developer";
                DataBasePass = "cygnusgr.1855";
                Server = @"173.248.133.181,1533";
                break;
            case "dev":
                DataBase = "cygnusgroup_database";
                DataBaseUser = "developer";
                DataBasePass = "cygnusgr.1855";
                Server = @"173.248.133.181,1533";
                break;
        }

        sql = new SocketSQL(Server, DataBaseUser, DataBasePass);
    }


}