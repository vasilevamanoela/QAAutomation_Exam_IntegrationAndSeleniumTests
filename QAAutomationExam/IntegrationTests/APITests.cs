using IntegrationTests.Factories;
using IntegrationTests.Models;
using NUnit.Framework;
using RestSharp;
using System;
using System.Net;

namespace QAAutomationExam.IntegrationTests
{
    [TestFixture]
    public class APITests
    {
        private RestClient _httpClient;
        private string _id;

        [SetUp]
        public void SetUp()
        {
            _httpClient = new RestClient();
            _httpClient.BaseUrl = new Uri("https://libraryjuly.azurewebsites.net");
            _id = CreateAuthor();
        }

        //Method create author => returns author ID
        public string CreateAuthor()
        {
            var newAuthor = AuthorFactory.CreateAuthor();

            var request = new RestRequest($"/api/authors");
            request.AddJsonBody(newAuthor.ToJson(), "application/json");

            var response = _httpClient.Post(request);

            var createdAuthor = Author.FromJson(response.Content);

            return createdAuthor.Id.ToString();
        }

        //POST Author
        [Test]
        public void ReceivedCreatedStatusCode_When_CreateAuthor()
        {
            var author = new Author()
            {
                FirstName = "Pesho",
                LastName = "Peshov",
                Genre = "Male"
            };

            var request = new RestRequest($"/api/authors");
            request.AddJsonBody(author.ToJson(), "application/json");

            var response = _httpClient.Post(request);

            var actualAuthor = Author.FromJson(response.Content);

            var expectedAuthor = new Author()
            {
                Name = $"{author.FirstName} {author.LastName}",
                Genre = author.Genre
            };

            Assert.AreEqual(expectedAuthor.Name, actualAuthor.Name);
            Assert.AreEqual(HttpStatusCode.Created, response.StatusCode);
        }

        //GET Author
        [Test]
        public void ReceivedOKStatusCode_When_GetAuthor()
        {
            var request = new RestRequest($"/api/authors/{_id}");

            var response = _httpClient.Get(request);

            Assert.AreEqual(HttpStatusCode.OK, response.StatusCode);
        }

        //DELETE Author 
        [Test]
        public void ReceivedNoContentStatusCode_When_DeleteAuthor()
        {
            var request = new RestRequest($"/api/authors/{_id}");

            var response = _httpClient.Delete(request);

            Assert.AreEqual(HttpStatusCode.NoContent, response.StatusCode);
        }
    }
}
