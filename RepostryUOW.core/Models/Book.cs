﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RepostriyUOW.core.Models
{
    public class Book
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Title { get; set; }
        public string Description { get; set; }
        public string Author { get; set; }
        public string Catogry { get; set; }
        public int Quantity { get; set; }
        public double Price { get; set; }
        public DateTime Created { get; set; }
        public int BorrowedDay { get; set; }
        public Author author { get; set; }

    }
}
