namespace entityFramework.Models
{
	public class Product
	{
        public int Id { get; set; }
        public string name { get; set; }
        public int Type { get; set; }
    }

    //public class Autor
    //{
    //    public int Id { get; set; }
    //    public string Nume { get; set; }
    //    public List<Carte> Carti { get; set; }
    //}

    //public class Editura
    //{
    //    public int Id { get; set; }
    //    public string Nume { get; set; }
    //    public List<Carte> Carti { get; set; }
    //}

    //public class Carte
    //{
    //    public int Id { get; set; }
    //    public string Titlu { get; set; }
    //    public List<Autor> Autori { get; set; }
    //    public int EdituraId { get; set; }
    //    public int AutorId { get; set; }
    //}

}

