﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MoodAnalyser
{
    public class CustomMoodAnalyserException:Exception
    {
        public ExceptionType type;
        public enum ExceptionType
        {
            NULL_MOOD_EXCEPTION,
            EMPTY_MOOD_EXCEPTION
        }
        public CustomMoodAnalyserException(ExceptionType type,string message):base(message)
        {
            this.type = type;   
        }
    }
}
