using Microsoft.AspNetCore.Mvc;
using SlackOverload.Models;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Threading.Tasks;

namespace SlackOverload.Controllers
{
    public class QuestionsController : Controller
    {
        private SlackData slackData;

        public QuestionsController(IDbConnection connection)
        {
            slackData = new SlackData(connection);
        }

        [HttpGet]
        public IActionResult Index()
        {
            List<Question> questions = slackData.GetAllQuestions();
            return View(questions);
        }

        [HttpGet]
        public IActionResult Question(int id)
        {
            Question theQuestion = slackData.GetQuestionById(id);

            if (theQuestion == null) return RedirectToAction("Error", "Shared");

            List<Answer> answers = slackData.GetAllAnswersFromQuestion(id);

            ViewData["QuestionTitle"] = theQuestion.title;
            ViewData["QuestionSummary"] = theQuestion.description;
            ViewData["QuestionDate"] = theQuestion.posted.ToShortDateString();
            ViewData["QuestionId"] = theQuestion.questionId;
            ViewData["QuestionUser"] = theQuestion.username;
            ViewData["QuestionStatus"] = theQuestion.status < 1 ? "Active" : "Closed";
            ViewData["QuestionTags"] = theQuestion.tags;

            return View(answers);
        }

        [HttpGet]
        public IActionResult AddQuestion()
        {
            return View(); //returns new question form
        }

        [HttpPost]
        public IActionResult CreateQuestion(Question newQuestion)
        {
            slackData.CreateNewQuestion(newQuestion);

            return RedirectToAction("Question", new { id = newQuestion.questionId });
        }

        [HttpGet]
        public IActionResult EditQuestion(int id)
        {
            Question outdatedQuestion = slackData.GetQuestionById(id);

            if (outdatedQuestion == null) return RedirectToAction("Index");

            return View(outdatedQuestion);
        }

        [HttpPost]
        public IActionResult UpdateQuestion(Question updatedQuestion)
        {
            slackData.UpdateQuestion(updatedQuestion);

            return RedirectToAction("Question", new { id = updatedQuestion.questionId });
        }

        public IActionResult DeleteQuestion(int id)
        {
            Question theQuestion = slackData.GetQuestionById(id);

            if (SlackData.CurrentUser == "admin" || SlackData.CurrentUser == theQuestion.username)
            {
                slackData.DeleteQuestion(id);
            }

            return RedirectToAction("Index");
        }

        [HttpGet]
        public IActionResult AddAnswer(int id) //question id
        {
            return View();
        }

        [HttpPost]
        public IActionResult CreateAnswer(Answer newAnswer)
        {
            slackData.CreateNewAnswer(newAnswer);

            return RedirectToAction("Question", new { id = newAnswer.questionId });
        }

        [HttpGet]
        public IActionResult EditAnswer(int id) //question id
        {
            Answer outdatedAnswer = slackData.GetAnswerById(id);

            if (outdatedAnswer == null) return RedirectToAction("Index");

            return View(outdatedAnswer);
        }

        [HttpPost]
        public IActionResult UpdateAnswer(Answer updatedAnswer)
        {
            slackData.UpdateAnswer(updatedAnswer);

            return RedirectToAction("Question", new { id = updatedAnswer.questionId });
        }

        public IActionResult DeleteAnswer(int id)
        {
            Answer theAnswer = slackData.GetAnswerById(id);
            if (theAnswer == null) return RedirectToAction("Index");

            int qid = theAnswer.questionId;

            if (SlackData.CurrentUser == "admin" || SlackData.CurrentUser == theAnswer.username)
            {
                slackData.DeleteAnswer(id);
            }

            return RedirectToAction("Question", new { id = qid });
        }
    }
}
