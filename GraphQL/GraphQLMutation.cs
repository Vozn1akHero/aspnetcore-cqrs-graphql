using Newtonsoft.Json.Linq;

namespace librarygraphql.GraphQL
{
    public class GraphQLMutation
    {
        public string OperationName { get; set; }
        public string NamedMutation { get; set; }
        public string Query { get; set; }
        public JObject Variables { get; set; }
    }
}