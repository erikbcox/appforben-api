using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using AppForBen.Api.Domain;

namespace AppForBen.Api.Controllers
{
    [Produces("application/json")]
    public class WordsController : Controller
    {
        private List<IWordList> _wordLists { get; set; }
        public WordsController()
        {
            _wordLists = new List<IWordList>();
            _wordLists.Add(GenerateWordList(100, "Ben's added April 18","the","at","could","it","am","we","mom","get","my","got","set"));
            _wordLists.Add(GenerateWordList(100, "Group 1", "am", "do", "look", "an", "for", "me"));
            _wordLists.Add(GenerateWordList(200, "Group 2", "and", "go", "my","are","no"));
            _wordLists.Add(GenerateWordList(300, "Group 3", "ask", "give", "learn", "back", "going"));
            _wordLists.Add(GenerateWordList(400, "Group 4", "live", "because", "great", "long", "been"));
            _wordLists.Add(GenerateWordList(500, "Group 5", "had", "many", "came", "green", "again"));

        }
        private IWordList GenerateWordList(int id, string name, params string[] words)
        {
            var wordList = new WordList { WordListId = id, Name = name, Words= new List<IWord>() };
            var index = 1;
            foreach(var w in words)
            {
                wordList.Words.Add(new Word {WordValue = w, WordId = index + id });
            }
            return wordList;
        }

        [HttpGet()]
        [Route("api/wordlist")]
        public IEnumerable<IWordList> GetWordLists()
        {
            return _wordLists;
        }

        // GET: api/Words
        [HttpGet]
        [Route("api/wordlist/{id}")]
        public IWordList GetWordList(int id)
        {
            var list = _wordLists.FirstOrDefault(l => l.WordListId == id);
            return list;
        }

    }
}
