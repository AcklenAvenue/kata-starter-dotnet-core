public class when_$spec_name$
    {
        Establish _context = () => { _systemUnderTest = new $sut$ };

        Because of = () => { _result = Catch.Exception(()=> _systemUnderTest.Action()); };

        It should_$do_something$ = () =>
        {
          _result.Message.Should().Be(something);
        };
       static Exception _result;
    }
