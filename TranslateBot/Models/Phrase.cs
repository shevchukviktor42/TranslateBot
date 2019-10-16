using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace TranslateBot.Models
{
    public class Phrase
    {
        public int PhraseId { get; set; }
        public string src { get; set; }
        public string dst { get; set; }

    }
}
