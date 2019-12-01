using System;
using System.Collections.Generic;
namespace Jubulant
{
    public class Scenario
    {
        private string _scenario;
        public string _Scenario { get; set; }
        private string[] answers;

        private int points;

        public Scenario(string _question, string[] _answer, int _points)
        {

            _Scenario = _question;
            answers = _answer;
            points = _points;
        }

        public string[] getAnswers()
        {
            return answers;
        }
    }
}