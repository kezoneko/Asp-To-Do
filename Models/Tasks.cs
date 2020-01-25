using System;
using System.ComponentModel.DataAnnotations;

namespace ToDo.Models
{
    public class Tasks
    {
        // Поле идентификатора задания
        public int ID { get; set; }

        // Поле заголовка задания
        public string Title { get; set; }

        // Поле даты и времени срока выполнения задания
        [DataType(DataType.DateTime)]
        public DateTime Date { get; set; }

        // Поле описания задания
        public string Description { get; set; }

        // Поле статуса выполнения задания
        public bool Status { get; set; }
    }
}
