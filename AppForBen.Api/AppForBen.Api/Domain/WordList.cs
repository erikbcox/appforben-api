using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AppForBen.Api.Domain
{
    public interface IWordList
    {
        int WordListId { get; set; }
        string Name { get; set; }
        List<IWord> Words { get; set; }
    }
    public class WordList: IWordList
    {
        public int WordListId { get; set; }
        public string Name { get; set; }
        public List<IWord> Words {get;set;}
    }
}
