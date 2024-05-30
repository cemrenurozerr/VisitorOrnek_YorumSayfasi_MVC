using VisitorOrnek.Models;

namespace VisitorOrnek.Data
{
    public class Listeler
    {
        public static List<Visitor> visitors = new List<Visitor>()
        {
            new Visitor() {ID=1, Name="Cemre", Comment="müthişşş", CreatedDate=DateTime.Now}, 
            new Visitor() {ID=2, Name="Cansu", Comment="Çok güzeldi", CreatedDate=DateTime.Now}, 
            new Visitor() {ID=3, Name="Ceren", Comment="EF SA NE", CreatedDate=DateTime.Now}
        };
    }
}
