//Kenneth Fujimura
//Last Revised: 10-25-2022
//Asking Questions - Endpoint
//This is a web API program that emulates our original "Asking Questions" mini challenge from the coding combine, refactored to work as a website that takes in inputs through its URL.
//Peer Reviewed By: Andrew Nilsson - Great job, all the inputs work in postman and returns the string in the correct format.

using Microsoft.AspNetCore.Mvc;

namespace FujimuraKAskingQuestions.Controllers;

[ApiController]
[Route("[controller]")]
public class AskingQuestionsController : ControllerBase
{
    [HttpGet]
    [Route("AskingQuestions/{name}/{time}")]

    public string AskingQuestions(string name, string time){
        return $"So you're telling me that your name is \"{name}\", and that you woke up at \"{time}\"? Cool beans!";
    }
}
