﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode_questions.Scripts
{
    public interface ISolution
    {
        public dynamic Solution<T>(SolutionArgs args);
    }

    public class SolutionArgs
    {

    }
}
