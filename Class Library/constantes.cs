namespace NotificationLibrary
{
    public static class Constantes
    {
        public enum NotificationTypes
        {
            Email,
            Text
        };

        public enum AlertState
        {
            OnGoing,
            Finished
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

        public static readonly string[] AppCategory =
        { 
            "application"
        };

        public static readonly string[] SeverityType =
        {
            "P1",
            "P2",
            "P3"
        };

    }
}
