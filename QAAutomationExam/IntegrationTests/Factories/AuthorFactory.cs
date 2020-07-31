using IntegrationTests.Models;

namespace IntegrationTests.Factories
{
    public static class AuthorFactory
    {
        public static Author CreateAuthor()
        {
            return new Author
            {
                FirstName = "FName",
                LastName = "LName",
                Genre = "Male"
            };
        }
    }
}
