namespace AutoMapperDemo
{
    namespace ProtobufInterface
    {
        public enum Status
        {
            sSuccess,
            sFailed,
            sSkipped
        }

        public class TestResult
        {
            public string Package;
            public string Class;
            public Status Status;
            public string Error;
            public string StackTrace;
            public long DurationMs;
            public int CheckCount;
        }
    }
}
