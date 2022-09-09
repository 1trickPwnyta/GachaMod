namespace GachaMod
{
    public static class Debug
    {
        public static void Log(string message)
        {
#if DEBUG
            Verse.Log.Message($"[{GachaMod.PACKAGE_NAME}] {message}");
#endif
        }
    }
}
