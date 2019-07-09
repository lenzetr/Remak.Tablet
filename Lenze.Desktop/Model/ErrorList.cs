using System;

namespace Lenze.Desktop.Model
{
    public class ErrorList
    {
        public string Module { get; set; }
        public string Name { get; set; }
        public string Message { get; set; }
        public string Exception { get; set; }
        public DateTime Date { get; set; } = DateTime.Now;
    }
}
