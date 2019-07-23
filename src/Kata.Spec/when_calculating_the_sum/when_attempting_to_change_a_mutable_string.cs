using FluentAssertions;
using Machine.Specifications;

namespace Kata.Spec.when_calculating_the_sum
{
    public class when_the_user_input_is_empty
    {
        static Monkey _systemUnderTest;
        static int _result;

        Establish context = () => 
            _systemUnderTest = new Monkey();

        Because of = () => 
            _result = _systemUnderTest.Eat("");

        It should_return_zero = () => 
            _result.Should().Be(0);
    }
}