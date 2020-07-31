using Newtonsoft.Json;
using System.Collections.Generic;

namespace IntegrationTests.Models
{
    public static class Serialize
    {
        public static string ToJson(this Author self) => JsonConvert.SerializeObject(self, IntegrationTests.Models.Converter.Settings);

        public static string ToJson(this List<Author> self) => JsonConvert.SerializeObject(self, IntegrationTests.Models.Converter.Settings);
    }
}
