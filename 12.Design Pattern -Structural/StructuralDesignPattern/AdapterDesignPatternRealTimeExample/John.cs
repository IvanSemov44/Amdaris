
namespace AdapterDesignPatternRealTimeExample
{
    public class John : IEnglishSpeaker
    {
        public string AnswerFortheQuestion(string words)
        {
            string reply = null;
            if(words.Equals("where are you?", StringComparison.InvariantCultureIgnoreCase))
            {
                reply = "I am in USA";
            }
            return reply;
        }

        public string AskQuestion(string words)
        {
            Console.WriteLine("Question asked by Jhon [English speaker and can understand only english.]");
            ITarger targer = new Pam();
            string replyFromDavid = targer.TransleAndTellToOtherPerson(words, "French");
            return replyFromDavid;
        }
    }
}
