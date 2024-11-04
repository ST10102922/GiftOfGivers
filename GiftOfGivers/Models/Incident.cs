using Microsoft.Azure.Documents;

namespace GiftOfGivers.Models
{
    public class Incident
    {
        public int IncidentID { get; set; }
        public int UserID { get; set; }
        public DateTime IncidentDate { get; set; }
        public string Description { get; set; }
        public User User { get; set; }
    }

}
