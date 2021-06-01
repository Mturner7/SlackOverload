using Dapper;
using Dapper.Contrib.Extensions;
using System.Collections.Generic;
using System.Data;
using System.Linq;

namespace SlackOverload.Models
{
    public class SlackData
    {
        private IDbConnection db;

        public static string CurrentUser;

        public SlackData(IDbConnection theFrenchConnection)
        {
            db = theFrenchConnection;
        }

        public List<Question> GetAllQuestions() 
        {
            return db.GetAll<Question>().OrderByDescending(q => q.posted).ToList();
        }

        public Question GetQuestionById(int id)
        {
            return db.Get<Question>(id);
        }

        public void CreateNewQuestion(Question newQuestion)
        {
            db.Insert<Question>(newQuestion);
        }

        public void UpdateQuestion(Question updatedQuestion)
        {
            db.Update<Question>(updatedQuestion);
        }

        public void DeleteQuestion(int questionId)
        {
            Question oldQuestion = db.Get<Question>(questionId);
            db.Delete<Question>(oldQuestion);
        }

        public List<Answer> GetAllAnswersFromQuestion(int questionId)
        {
            return db.Query<Answer>($"select * from answers where questionId = {questionId} order by posted").ToList();
        }

        public Answer GetAnswerById(int answerId)
        {
            return db.Get<Answer>(answerId);
        }

        public void CreateNewAnswer(Answer newAnswer)
        {
            db.Insert<Answer>(newAnswer);
        }

        public void UpdateAnswer(Answer updatedAnswer)
        {
            db.Update<Answer>(updatedAnswer);
        }

        public void DeleteAnswer(int answerId)
        {
            Answer oldAnswer = db.Get<Answer>(answerId);
            db.Delete<Answer>(oldAnswer);
        }
    }
}
