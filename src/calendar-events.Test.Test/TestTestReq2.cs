using Xunit;
using System;
using FluentAssertions;
using calendar_events.Test;

namespace calendar_events.Test.Test;

[Collection("Sequential")]
public class TestTestReq2
{
    [Trait("Category", "5 - Criou testes para o TestListSearchByTitle.")]
    [Theory(DisplayName = "TestListSearchByTitle deve ser executado com sucesso com entradas corretas")]
    [InlineData("Festa do pudim", "2022-05-05", "Uma festa onde cada um leva seu pudim!", 0)]
    [InlineData("Festa do bolo", "2022-10-10", "Uma festa onde cada um leva seu bolo!",0)]
    public void TestSucessTestListSearchByTitle(string title, string date, string description, int expected)
    {
        TestReq2 instance = new();
        Action act = () => instance.TestListSearchByTitle(title, date, description, expected);        
        act.Should().NotThrow<System.FormatException>();
        act.Should().NotThrow<Xunit.Sdk.XunitException>();
        act.Should().NotThrow<NotImplementedException>();        
    }

    [Trait("Category", "5 - Criou testes para o TestListSearchByTitle.")]
    [Theory(DisplayName = "TestListSearchByTitle deve falhar quando executado com entradas incorretas")]
    [InlineData("Festa do pudim", "2022-0gf5-05", "Uma festa onde cada um leva seu pudim!", 1)]
    [InlineData("Festa do bolo", "2022-10gcfh-10", "Uma festa onde cada um leva seu bolo!", 2)]
    public void TestFailTestListSearchByTitle(string title, string date, string description, int expected)
    {
        TestReq2 instance = new();
        Action act = () => instance.TestListSearchByTitle(title, date, description, expected);
        act.Should().Throw<System.FormatException>();
        act.Should().NotThrow<NotImplementedException>();
    }

}
public class TestTestReq22
{
    [Trait("Category", "6 - Criou testes para o TestListSearchByDate.")]
    [Theory(DisplayName = "TestListSearchByDate deve ser executado com sucesso com entradas corretas")]
    [InlineData("Festa do pudim", "2022-05-05", "Uma festa onde cada um leva seu pudim!", 0)]
    [InlineData("Festa do bolo", "2022-10-10", "Uma festa onde cada um leva seu bolo!",0)]
    public void TestSucessTestListSearchByDate(string title, string date, string description, int expected)
    {
        TestReq2 instance = new();
        Action act = () => instance.TestListSearchByDate(title, date, description, expected);        
        act.Should().NotThrow<System.FormatException>();
        act.Should().NotThrow<Xunit.Sdk.XunitException>();
        act.Should().NotThrow<NotImplementedException>();        
    }

    [Trait("Category", "6 - Criou testes para o TestListSearchByDate.")]
    [Theory(DisplayName = "TestListSearchByDate deve falhar quando executado com entradas incorretas")]
    [InlineData("Festa do pudim", "2022-0gf5-05", "Uma festa onde cada um leva seu pudim!", 1)]
    [InlineData("Festa do bolo", "2022-10gcfh-10", "Uma festa onde cada um leva seu bolo!", 2)]
    public void TestFailTestListSearchByDate(string title, string date, string description, int expected)
    {
        TestReq2 instance = new();
        Action act = () => instance.TestListSearchByDate(title, date, description, expected);
        act.Should().Throw<System.FormatException>();
        act.Should().NotThrow<NotImplementedException>();
    }

   
}