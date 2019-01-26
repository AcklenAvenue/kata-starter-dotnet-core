using System;
using FluentAssertions;
using Machine.Specifications;

namespace Kata.Spec
{
    public class when_adding_two_numbers
    {
        static int _sut;

        Establish context = () => { 
            _sut = 1;
        };
        
        Because action = () => {            
            _sut = _sut+1; 
        };

        It should_return_the_sum = () => _sut.Should().Be(2);
    }
}