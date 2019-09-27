public class when_$spec_name$
    {
        Establish _context = () => { _systemUnderTest = new $sut$ };

        Because of = () => { _result = _systemUnderTest.Action(); };

        It should_$do_something$ = () =>
        {
          _result.Should().Be(something);
        };

    }
