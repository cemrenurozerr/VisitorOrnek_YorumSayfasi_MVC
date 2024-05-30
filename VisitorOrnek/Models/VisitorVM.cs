namespace VisitorOrnek.Models
{
	public class VisitorVM
	{
        public Visitor Visitor { get; set; }
        public List<Visitor> Visitors { get; set; }
        public VisitorVM()
        {
            Visitors = new List<Visitor>();
        }
    }
}
