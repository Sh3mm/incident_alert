namespace NotificationLibrary
{
    public static class Constantes
    {
        public enum NotificationTypes
        {
            Email,
            Text
        };


        public static readonly string[] AlertType = 
        {
            "SystemCrash",
            "ComputerMeltdown",
            "NuclearBomb"
        };

        public static readonly string[] UserType =
        {
            "IT Personel",
            "Critical User",
            "Subscription User"
        };
    }
}
