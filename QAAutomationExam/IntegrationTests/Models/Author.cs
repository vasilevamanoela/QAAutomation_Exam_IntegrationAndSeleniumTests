namespace IntegrationTests.Models
{
    using Newtonsoft.Json;
    using System;
    using System.Collections.Generic;

    public partial class Author
    {
        [JsonProperty("id", NullValueHandling = NullValueHandling.Ignore)]
        public Guid? Id { get; set; }

        [JsonProperty("name", NullValueHandling = NullValueHandling.Ignore)]
        public string Name { get; set; }

        [JsonProperty("firstname", NullValueHandling = NullValueHandling.Ignore)]
        public string FirstName { get; set; }

        [JsonProperty("lastname", NullValueHandling = NullValueHandling.Ignore)]
        public string LastName { get; set; }

        [JsonProperty("dateOfBirth", NullValueHandling = NullValueHandling.Ignore)]
        public string DateOfBirth { get; set; }

        [JsonProperty("age", NullValueHandling = NullValueHandling.Ignore)]
        public long? Age { get; set; }

        [JsonProperty("genre", NullValueHandling = NullValueHandling.Ignore)]
        public string Genre { get; set; }

        [JsonProperty("links", NullValueHandling = NullValueHandling.Ignore)]
        public List<Link> Links { get; set; }

        public static Author FromJson(string json) => JsonConvert.DeserializeObject<Author>(json, IntegrationTests.Models.Converter.Settings);

    }
}
