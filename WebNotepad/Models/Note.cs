using System;
using System.Collections.Generic;

namespace WebNotepad.Models
{
    public class Note
    {
        public int Id { get; set; }

        public string Title { get; set; }

        public string Description { get; set; }

        public string Text { get; set; }

        public DateTime DateOfCreate { get; set; }

        public DateTime DateOfLastEdit { get; set; }

        public List<int> AttachedNotes { get; set; }

        public List<string> Tegs { get; set; }
    }
}
