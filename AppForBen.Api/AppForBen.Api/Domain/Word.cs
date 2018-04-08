using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AppForBen.Api.Domain
{
    public interface IWord
    {
        int WordId { get; set; }
        string WordValue { get; set; }
    }
    public class Word : IWord
    {
        public Word()
        {
        }
        public int WordId { get; set; }

        public string WordValue { get; set; }
    }
}
