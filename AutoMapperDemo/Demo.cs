using System;
using AutoMapper;
using NUnit.Framework;

namespace AutoMapperDemo
{
    public class Demo
    {
        [Test]
        public void DemoTest()
        { 
            var config = new MapperConfiguration(cfg => {
                cfg.CreateMap<ProtobufInterface.TestResult, Entity.TestResult>()
                .ForMember(dest=> dest.Duration,
                    m => m.MapFrom(src => TimeSpan.FromMilliseconds( src.DurationMs)));
            });
            var iMapper = config.CreateMapper();

            var source = new ProtobufInterface.TestResult();
            source.Class = nameof(Demo);
            source.Package = GetType().FullName;
            source.CheckCount = 1;
            source.Status = ProtobufInterface.Status.sSuccess;
            source.DurationMs = 1234567; // 1234.567 seconds => 20 minutes (1200 seconds) 34 seconds 567 ms
            var destination = iMapper.Map<ProtobufInterface.TestResult, Entity.TestResult>(source);

            Assert.AreEqual(source.Class, destination.Class, "Class has to be equal" );
            Assert.AreEqual(source.Package, destination.Package, "Package has to be equal");
            Assert.AreEqual(source.CheckCount, destination.CheckCount, "CheckCount has to be equal");
            Assert.AreEqual((int)source.Status, (int)destination.Status, "Status has to be equal");
            Assert.AreEqual(source.DurationMs, destination.Duration.TotalMilliseconds, "Duration has to be equal");
        }
    }
}