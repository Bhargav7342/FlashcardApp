using Entities;
using Models;

namespace Business_Logic
{
    public class FlashCardLogic : IFlashCardLogic
    {
        private readonly IFlashcardRepo repo;
        public FlashCardLogic(IFlashcardRepo _repo)
        {
            repo = _repo;
        }
        public Flashcards AddFlashcard(Flashcards flashcard)
        {
            return Mapper.Map(repo.AddFlashCard(Mapper.Map(flashcard)));
        }

        public Flashcards DeleteFlashCard(Guid Id)
        {
            var card=repo.DeleteFlashCard(Id);
            return Mapper.Map(card);
        }

        public IEnumerable<Flashcards> GetFlashcards()
        {
            return Mapper.Map(repo.GetAllFlashCards());
        }

        public Flashcards UpdateFlashCard(Flashcards flashcards)
        {
            var card=(from c in repo.GetAllFlashCards()
                      where c.Id == flashcards.Id
                      select c).FirstOrDefault();
            if(card!=null)
            {
                card.Question=flashcards.Question;
                card.Answer=flashcards.Answer;

                card=repo.UpdateFlashCard(card);
            }
            return Mapper.Map(card);
        }
    }
}