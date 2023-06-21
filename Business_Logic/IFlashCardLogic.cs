using Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business_Logic
{
    public interface IFlashCardLogic
    {
        Flashcards AddFlashcard(Flashcards falshcard);
        Flashcards UpdateFlashCard(Flashcards flashcards);
        Flashcards DeleteFlashCard(Guid Id);
        IEnumerable<Flashcards> GetFlashcards();
    }
}
