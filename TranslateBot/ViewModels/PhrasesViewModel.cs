using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using TranslateBot.Models;

namespace TranslateBot.ViewModels
{
    public class PhrasesViewModel
    {
        public IEnumerable<Phrase> PhraseList { get; set; }
    }
}
