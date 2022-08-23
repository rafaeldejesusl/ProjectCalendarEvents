using Xunit;
using FluentAssertions;
using calendar_events;
using System;

namespace calendar_events.Test;

public class TestReq2
{
    [Theory(DisplayName = "Deve procurar um evento por titulo")]
    [InlineData()]
    public void TestListSearchByTitle(string title, string date, string description,int expected)
    {
        throw new NotImplementedException();
    }

    [Theory(DisplayName = "Deve procurar um evento por data")]
    [InlineData()]
    public void TestListSearchByDate(string title, string date, string description, int expected)
    {
        throw new NotImplementedException();
    }

    
}