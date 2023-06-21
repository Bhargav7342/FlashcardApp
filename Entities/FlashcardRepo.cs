using Entities.Entities;

namespace Entities
{
    public class FlashcardRepo : IFlashcardRepo
    {
        private readonly UpskilldatabaseContext context;
        public FlashcardRepo(UpskilldatabaseContext _context)
        {
            context = _context;
        }
        public FlashcardDetail AddFlashCard(FlashcardDetail flashcard)
        {
            context.FlashcardDetails.Add(flashcard);
            context.SaveChanges();
            return flashcard;
        }

        public FlashcardDetail DeleteFlashCard(Guid id)
        {
            var flash=context.FlashcardDetails.Where(f=>f.Id==id).FirstOrDefault();
            context.FlashcardDetails.Remove(flash);
            context.SaveChanges();
            return flash;
        }

        public List<FlashcardDetail> GetAllFlashCards()
        {
           var all=(from flash in context.FlashcardDetails
                    where flash.Question != null 
                    select flash).ToList();
            return all;
        }

        public FlashcardDetail UpdateFlashCard(FlashcardDetail flashcard)
        {
            context.FlashcardDetails.Update(flashcard);
            context.SaveChanges();
            return flashcard;
        }
    }
}