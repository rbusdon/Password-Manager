﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProgramFirstFunction.CheckerPassword
{
    public interface ICheckerPassword : IChecker
    {
        public void SetNext(ICheckerPassword next);
    }
}
