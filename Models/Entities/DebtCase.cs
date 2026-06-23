namespace MS.Financial.Web.Models.Entities
{
    public class DebtCase
    {
        public int Id { get; set; }
        public int ClientId { get; set; }
        public Client Client { get; set; }
        public string CaseType { get; set; } // Asseesment, Review, judgement, Advertisement
        public string CaseStatus { get; set; } // new, inProgtress, Completed, Closed
        public string ReferenceNumber { get; set; }
        public decimal Amount { get; set; }
        public DateTime StartDate { get; set; } = DateTime.UtcNow;
        public DateTime? CompletionDate { get; set; }
        public string Notes { get; set; }
        public ICollection<Document> Documents { get; set; }
    }
}