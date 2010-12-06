﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace OES.Model
{
    class Completion:Problem
    {
        public string stuAns;
        public List<string> ans;
        public Completion()
        {
            type = "填空题";
        }
        public Completion(string p)
        {
            problem = p;
            stuAns = "";
            ans = new List<string>();
            type = "填空题";
        }
    }
}
