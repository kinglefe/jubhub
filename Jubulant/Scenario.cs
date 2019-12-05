using System;
using System.Collections.Generic;
namespace Jubulant
{
    public class Scenario
    {
        public string _Scenario { get; set; }
        public List<int> answers;
        public Star star;
        

        public Scenario(string _question, List<int> _answer)
        {

            this._Scenario = _question;
            this.answers = _answer;
        }
        

        public List<int> getAnswers()
        {
            return answers;
        }
    }
}