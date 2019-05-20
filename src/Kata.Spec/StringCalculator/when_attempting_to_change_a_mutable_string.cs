using FluentAssertions;
using Kata.StringCalculator;
using Machine.Specifications;

namespace Kata.Spec
{
    [Subject("when adding numbers together")]
    public class when_user_input_is_empty
    {
        static Calculator _sut;
        static int _result;

        Establish context = () => _sut = new Calculator();

        Because of = () => _result = _sut.Add("");

        It should_return_the_sum = () => _result.Should().Be(0);
    }
}