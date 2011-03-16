﻿using System;
using System.Collections.Generic;
 
using System.Text;

namespace OES.Model
{
    class PCompletion:Problem
    {
        public string path = "";
        public string ans1 = "";
        public string ans2 = "";
        public string ans3 = "";
        public string stuAnsPath = "";
        public PCompletion()
        {
            type = ProblemType.ProgramCompletion;
        }
        public PCompletion(string p)
        {
            problem = p;
            ans1 = "";
            ans2 = "";
            ans3 = "";
            type = ProblemType.ProgramCompletion;
        }
        public override string getAns()
        {
            return stuAnsPath;
        }
    }
}
