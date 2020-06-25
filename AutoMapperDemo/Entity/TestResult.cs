using System;

namespace AutoMapperDemo
{
    namespace Entity
    {
        public enum Status
        {
            Success,
            Failed,
            Skipped
        }

        public class TestResult
        {
            public string Package;
            public string Class;
            public Status Status;
            public string Error;
            public string StackTrace;
            public TimeSpan Duration;
            public int CheckCount;
        }
    }
}
