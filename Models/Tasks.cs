using System;
using System.ComponentModel.DataAnnotations;

namespace ToDo.Models
{
    public class Tasks
    {
        // Поле идентификатора задания
        public int ID { get; set; }

        // Поле заголовка задания
        [Display(Name = "Заголовок")]
        public string Title { get; set; }

        // Поле даты и времени срока выполнения задания
        [Display(Name = "Срок выполнения"), DataType(DataType.DateTime), DisplayFormat(DataFormatString = "{0:yyyy-MM-dd, HH:mm}", ApplyFormatInEditMode = true)]
        public DateTime Date { get; set; }

        // Поле описания задания
        [Display(Name = "Описание")]
        public string Description { get; set; }

        // Поле статуса выполнения задания
        [Display(Name = "Статус")]
        public bool Status { get; set; }
    }
}
