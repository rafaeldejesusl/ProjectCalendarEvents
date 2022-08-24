using Xunit;
using FluentAssertions;
using calendar_events;
using System;

namespace calendar_events.Test;

public class TestReq1
{
    [Theory(DisplayName = "Deve cadastrar um evento com o construtor completo")]
    [InlineData("Churrasco", "2021-04-22", "Churrasco da firma")]
    public void TestEventFullConstructor(string title, string date, string description)
    {
        Event instance = new (title, date, description);
        instance.Should().BeAssignableTo<Event>();
    }

    [Theory(DisplayName = "Deve cadastrar um evento com o construtor sem descrição")]
    [InlineData("Churrasco", "2021-04-22")]
    public void TestEventHalfConstructor(string title, string date)
    {
        Event instance = new (title, date);
        instance.Should().BeAssignableTo<Event>(); 
    }

    [Theory(DisplayName = "Deve atrasar a data de um evento corretamente")]
    [InlineData("Churrasco", "2021-04-22", 5, "2021-04-27")]
    public void TestEventDelayDate(string title, string date, int days, string expected)
    {
        Event instance = new (title, date);
        var dateArray = expected.Split('-');
        var expectedDate = new DateTime(Convert.ToInt32(dateArray[0]), Convert.ToInt32(dateArray[1]), Convert.ToInt32(dateArray[2])); 
        instance.DelayDate(days);
        instance.EventDate.Should().Be(expectedDate);
    }

    [Theory(DisplayName = "Deve imprimir um evento corretamente")]
    [InlineData("Churrasco", "2021-04-22", "Churrasco da firma", "detailed", "Evento = Churrasco\nDate = 22/04/2021\nDescription = Churrasco da firma")]    
    public void TestPrintEvent(string title, string date, string description, string format, string expected)
    {
        Event instance = new (title, date, description);
        var result = instance.PrintEvent(format); 
        result.Should().Be(expected);
    }
    
    
}