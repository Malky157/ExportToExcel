using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DeveloperProject
{
    public class Response
    {
        public bool Success { get; set; }
        public string FileName { get; set; }
        public string Errors { get; set; }

        public override string ToString()
        {
            return $"Response: {Success} - {FileName}  {Errors}";
        }
    }
}
