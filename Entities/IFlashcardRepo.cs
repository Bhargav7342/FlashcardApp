using Entities.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities
{
    public interface IFlashcardRepo
    {
        FlashcardDetail AddFlashCard(FlashcardDetail flashcard);
        FlashcardDetail UpdateFlashCard(FlashcardDetail flashcard);
        FlashcardDetail DeleteFlashCard(Guid id);
        List<FlashcardDetail> GetAllFlashCards();
    }
}
