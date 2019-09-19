using FluentAssertions;
using Machine.Specifications;

namespace Kata.Spec
{
    public class when_adding_the_third_char_from_each_line
    {
        Establish _context = () => { _systemUnderTest = new TestClass(); };

        Because of = () => 
            _result = _systemUnderTest.GetSumOfThirdCharacter("123\n9d3492127\nkk2kwkgkykl1\n19328783");

        It should_return_the_sum_of_the_third_characters = () => { _result.Should().Be(11); };
        
        static TestClass _systemUnderTest;
        static int _result;
    }
}