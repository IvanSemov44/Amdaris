
namespace AdapterDesignPatternRealTimeExample
{
    public class David : IFrenchSpeaker
    {
        public string AnswerFortheQuestion(string words)
        {
            string reply = null;
            if(words.Equals("comment allez-vous?", StringComparison.InvariantCultureIgnoreCase))
            {
                reply = "Je suis tres bien";
            }
            return reply;
        }

        public string AskQuestion(string words)
        {
            Console.WriteLine("Question asked by David [French speaker and can understand only french]");
            ITarger target = new Pam();
            string replyFromJhon = target.TransleAndTellToOtherPerson(words, "English");
            return replyFromJhon;
        }
    }
}
