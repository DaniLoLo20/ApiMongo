namespace ApiMongo.Models
{
    public class EscuelaSettings :IEscuelaSttings
    {
        public string Server { get; set; }
        public string DataBase { get; set; }

        public string Collection { get; set; }
    }

    public interface IEscuelaSttings
    {

        string Server { get; set; }
        string DataBase { get; set; }

        string Collection { get; set; }

    }
}
