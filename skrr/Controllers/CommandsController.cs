using System.Collections.Generic;
using Microsoft.AspNetCore.Mvc;
using skrr.Models;
using skrr.Data;


namespace skrr.Controllers
{
    // Set to api/commands to ensure same endpoint
    [Route("api/commands")]
    [ApiController]
    public class CommandsController : ControllerBase
    {
        private readonly ICommanderRepo _repository;
        public CommandsController(ICommanderRepo repository)
        {
            _repository = repository;
        }


        // private readonly MockCommanderRepo _repository = new MockCommanderRepo();
        //Get api/commands/
        [HttpGet]
        public ActionResult<IEnumerable<Command>> GetAllCommands()
        {
            var commandItems = _repository.GetAllCommands();

            return Ok(commandItems);

        }

        //Get api/commands/{id}
        [HttpGet("{id}")]
        public ActionResult<Command> GetCommandById(int id)
        {
            var commandItem = _repository.GetCommandById(id);
            if(commandItem != null)
            {
                return Ok(commandItem);
            }
            return NotFound();
        }

    }
}