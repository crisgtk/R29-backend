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
                DataBase = "iaco_r29";
                DataBaseUser = "iacoapp";
                DataBasePass = "iaco*2020";
                Server = @"68.71.137.39,1533";
                break;
            case "dev":
                DataBase = "iaco_r29";
                DataBaseUser = "iacoapp";
                DataBasePass = "iaco*2020";
                Server = @"68.71.137.39,1533";
                break;
        }

        sql = new SocketSQL(Server, DataBaseUser, DataBasePass);
    }


}