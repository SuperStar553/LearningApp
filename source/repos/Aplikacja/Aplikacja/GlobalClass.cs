namespace Aplikacja
{
    static class GlobalClass
    {
        private static bool _firstEntry = true;

        public static bool FirstEntry
        {
            get { return _firstEntry; }
            set { _firstEntry = value; }
        }


    }
}
