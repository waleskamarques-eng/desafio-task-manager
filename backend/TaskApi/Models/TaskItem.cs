using System.ComponentModel.DataAnnotations;

namespace TaskApi.Models
{
    public class TaskItem
    {
        public int Id { get; set; }

        [Required]
        public string Titulo { get; set; }

        public string Descricao { get; set; }

        public string Status { get; set; } = "Pendente";

        public DateTime DataCriacao { get; set; } = DateTime.Now;
    }
}