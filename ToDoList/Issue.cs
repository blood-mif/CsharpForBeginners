﻿using System;

namespace ToDoList
{
    ///<summary>
    ///    Задача
    ///</summary>

    public class Issue
    {
        public Issue()
        {
            CreationDate = DateTime.Now;
            Status = Status.New;
        }

        public string Title { get; set; }

        public DateTime CreationDate { get; set; }

        ///<summary>   
        ///1 - Новая
        ///2 - Выполненная
        ///</summary>>
    
        public Status Status { get; set; }
    }
}
