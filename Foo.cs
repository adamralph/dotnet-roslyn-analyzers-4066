namespace Test
{
    public static class Foo
    {
        public static void Bar(int unused)
        {
            Baz(123);
        }

        private static void Baz(int unused)
        {
            System.Console.WriteLine();
        }
    }
}
