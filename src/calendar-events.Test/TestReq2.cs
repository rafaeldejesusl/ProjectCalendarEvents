using Xunit;
using FluentAssertions;
using calendar_events;
using System;

namespace calendar_events.Test;

public class TestReq2
{
    [Theory(DisplayName = "Deve procurar um evento por titulo")]
    [InlineData("Churrasco", "2021-04-22", "Churrasco da firma", 0)]
    public void TestListSearchByTitle(string title, string date, string description,int expected)
    {
        Event eventInstance = new (title, date, description);
        EventList instance = new ();
        instance.GenericList();
        instance.Add(eventInstance);
        int result = instance.SearchByTitle(title);
        result.Should().Be(expected);
    }

    [Theory(DisplayName = "Deve procurar um evento por data")]
    [InlineData("Churrasco", "2021-04-22", "Churrasco da firma", 0)]
    public void TestListSearchByDate(string title, string date, string description, int expected)
    {
        Event eventInstance = new (title, date, description);
        EventList instance = new ();
        instance.GenericList();
        instance.Add(eventInstance);
        int result = instance.SearchByDate(date);
        result.Should().Be(expected);
    }

    
}