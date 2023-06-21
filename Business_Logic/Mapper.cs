using Entities.Entities;
using Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business_Logic
{
    public static class Mapper
    {
        public static Flashcards Map(FlashcardDetail fd)
        {
            return new Flashcards()
            {
                Id = fd.Id,
                Question = fd.Question,
                Answer = fd.Answer,
            };
        }

        public static FlashcardDetail Map(Flashcards fd)
        {
            return new FlashcardDetail()
            {
                Id = fd.Id,
                Question = fd.Question,
                Answer = fd.Answer,
            };
        }

        public static IEnumerable<Flashcards> Map(IEnumerable<FlashcardDetail> list)
        {
            return list.Select(Map).ToList();
        }
    }
}
