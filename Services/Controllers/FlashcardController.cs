using Business_Logic;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Models;

namespace Services.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class FlashcardController : ControllerBase
    {
        public readonly IFlashCardLogic logic;
        public FlashcardController(IFlashCardLogic _logic)
        {
            logic = _logic;
        }

        [HttpGet("Get_All_Cards")] 
        public IActionResult Get()
        {
            try
            {
                var card=logic.GetFlashcards();
                if (card!=null)
                {
                    return Ok(card);
                }
                else
                { return BadRequest(); }
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }
        }

        [HttpPost("Add_Flashcard")]
        public IActionResult Post([FromBody]Flashcards f)
        {
            try
            {
                var card = logic.AddFlashcard(f);
                if (card!=null)
                {
                    return Ok(card);
                }
                else
                { return BadRequest(); }
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }
        }

        [HttpPut("Update_Flashcard")]
        public IActionResult Put([FromBody]Flashcards f)
        {
            try
            {
                var card = logic.UpdateFlashCard(f);
                if (card!=null)
                {
                    return Ok(card);
                }
                else
                { 
                    return BadRequest(); 
                }

            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }
        }

        [HttpDelete("Delete_Flashcard")]
        public IActionResult Delete([FromHeader]Guid id ) 
        {
            try
            {
                var card=logic.DeleteFlashCard(id);
                if(card!=null)
                {
                    return Ok(card);
                }
                else { return BadRequest(); }
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }
        }

        [HttpGet("GetCardById")]

        public IActionResult GetCard([FromHeader]Guid id)
        {
            try
            {
                var res=logic.GetFlashcardsByID(id);
                if(res!=null)
                    return Ok(res);
                else
                { return BadRequest(); }
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }
        }
    }
}
