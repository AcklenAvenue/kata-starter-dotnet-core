using FluentAssertions;
using Machine.Specifications;

namespace Kata.Spec.when_calculating_the_sum
{
    public class when_the_user_input_is_empty
    {
        static Calculator _sut;
        static int _result;

        Establish context = () => _sut = new Calculator();

        Because of = () => _result = _sut.Add("");

        It should_return_zero = () => _result.Should().Be(0);
    }
}