using WebApplication11.Data;

namespace WebApplication11.Models
{
    public class DocumentActs
    {
        public List<Document> GetDocumnts()
        {
            DocumentData documentData = new DocumentData();
            var Documnets = documentData.Documents;
            return Documnets;
        }

    }
}
