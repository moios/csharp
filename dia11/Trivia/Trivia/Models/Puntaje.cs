namespace Trivia.Models
{
    using System.Text.Json.Serialization;
    public class Puntaje
    {
        [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingDefault)]
        public int Id { get; set; }

        public string Jugador { get; set; } = "";

        public int Puntos { get; set; }

        [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingDefault)]
        public DateTime Creado { get; set; }
    }
}
