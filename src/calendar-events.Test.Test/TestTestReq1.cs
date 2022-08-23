using Xunit;
using System;
using FluentAssertions;
using calendar_events.Test;

namespace calendar_events.Test.Test;

[Collection("Sequential")]
public class TestTestReq1
{
    [Trait("Category", "1 - Criou testes para o TestEventFullConstructor.")]
    [Theory(DisplayName = "TestEventFullConstructor deve ser executado com sucesso com entradas corretas")]
    [InlineData("Festa do pudim", "2022-05-05", "Uma festa onde cada um leva seu pudim!")]
    [InlineData("Festa do bolo", "2022-10-10", "Uma festa onde cada um leva seu bolo!")]
    public void TestSucessTestEventFullConstructor(string title, string date, string description)
    {
        TestReq1 instance = new();
        Action act = () => instance.TestEventFullConstructor(title, date, description);        
        act.Should().NotThrow<System.FormatException>();
        act.Should().NotThrow<Xunit.Sdk.XunitException>();
        act.Should().NotThrow<NotImplementedException>();        
    }

    [Trait("Category", "1 - Criou testes para o TestEventFullConstructor.")]
    [Theory(DisplayName = "TestEventFullConstructor deve falhar quando executado com entradas incorretas")]
    [InlineData("Festa do pudim", "2022-0gf5-05", "Uma festa onde cada um leva seu pudim!")]
    [InlineData("Festa do bolo", "2022-10gcfh-10", "Uma festa onde cada um leva seu bolo!")]
    public void TestFailTestEventFullConstructor(string title, string date, string description)
    {
        TestReq1 instance = new();
        Action act = () => instance.TestEventFullConstructor(title, date, description);
        act.Should().Throw<System.FormatException>();
        act.Should().NotThrow<NotImplementedException>();
    }

}
public class TestTestReq12
{
    [Trait("Category", "2 - Criou testes para o TestEventHalfConstructor.")]
    [Theory(DisplayName = "TestEventHalfConstructor deve ser executado com sucesso com entradas corretas")]
    [InlineData("Festa do pudim", "2022-05-05")]
    [InlineData("Festa do bolo", "2022-10-10")]
    public void TestSucessTestEventHalfConstructor(string title, string date)
    {
        TestReq1 instance = new();
        Action act = () => instance.TestEventHalfConstructor(title, date);
        act.Should().NotThrow<System.FormatException>();
        act.Should().NotThrow<Xunit.Sdk.XunitException>();
        act.Should().NotThrow<NotImplementedException>();
    }

    [Trait("Category", "2 - Criou testes para o TestEventHalfConstructor.")]
    [Theory(DisplayName = "TestEventHalfConstructor deve falhar quando executado com entradas incorretas")]
    [InlineData("Festa do pudim", "2022dsf-05-05")]
    [InlineData("Festa do bolo", "2022-10-fds10")]
    public void TestFailTestEventHalfConstructor(string title, string date)
    {
        TestReq1 instance = new();
        Action act = () => instance.TestEventHalfConstructor(title, date);
        act.Should().Throw<System.FormatException>();        
        act.Should().NotThrow<NotImplementedException>();
    }
}
public class TestTestReq13
{
    [Trait("Category", "3 - Criou testes para o TestEventDelayDate.")]
    [Theory(DisplayName = "TestEventDelayDate deve ser executado com sucesso com entradas corretas")]
    [InlineData("Festa do pudim", "2022-05-05", 20, "2022-05-25")]
    [InlineData("Festa do pudim", "2022-05-05", 10, "2022-05-15")]
    [InlineData("Festa do pudim", "2022-05-20", 20, "2022-06-09")]
    public void TestSucessTestEventDelayDate(string title, string date, int days, string expected)
    {
        TestReq1 instance = new();
        Action act = () => instance.TestEventDelayDate(title, date, days, expected);
        act.Should().NotThrow<Xunit.Sdk.XunitException>();
        act.Should().NotThrow<NotImplementedException>();
    }

    [Trait("Category", "3 - Criou testes para o TestEventDelayDate.")]
    [Theory(DisplayName = "TestEventDelayDate deve falhar quando executado com entradas incorretas")]
    [InlineData("Festa do pudim", "2022-05-05", 2, "2021-05-25")]
    [InlineData("Festa do pudim", "2022-05-05", 1, "2021-05-15")]
    [InlineData("Festa do pudim", "2022-05-20", 20, "2021-06-09")]
    public void TestFailTestEventDelayDate(string title, string date, int days, string expected)
    {
        TestReq1 instance = new();
        Action act = () => instance.TestEventDelayDate(title, date, days, expected);
        act.Should().Throw<Xunit.Sdk.XunitException>();
        act.Should().NotThrow<NotImplementedException>();
    }
}
public class TestTestReq14
{
    [Trait("Category", "4 - Criou testes para o TestPrintEvent.")]
    [Theory(DisplayName = "TestPrintEvent deve ser executado com sucesso com entradas corretas")]
    [InlineData("Festa do pudim", "2022-05-05", "Uma festa onde cada um leva seu pudim!", "normal", "Evento = Festa do pudim\nDate = 05/05/2022\n")]
    [InlineData("Festa do bolo", "2022-10-10", "Uma festa onde cada um leva seu bolo!", "normal","Evento = Festa do bolo\nDate = 10/10/2022\n")]
    [InlineData("Festa do pudim", "2022-05-05", "Uma festa onde cada um leva seu pudim!", "detailed", "Evento = Festa do pudim\nDate = 05/05/2022\nDescription = Uma festa onde cada um leva seu pudim!")]
    [InlineData("Festa do bolo", "2022-10-10", "Uma festa onde cada um leva seu bolo!", "detailed","Evento = Festa do bolo\nDate = 10/10/2022\nDescription = Uma festa onde cada um leva seu bolo!")]
    public void TestSucessTestPrintEvent(string title, string date, string description, string format, string expected)
    {
        TestReq1 instance = new();
        Action act = () => instance.TestPrintEvent(title, date, description, format, expected);
        act.Should().NotThrow<Xunit.Sdk.XunitException>();
        act.Should().NotThrow<NotImplementedException>();
    }

    [Trait("Category", "4 - Criou testes para o TestPrintEvent.")]
    [Theory(DisplayName = "TestPrintEvent deve falhar quando executado com entradas incorretas")]
    [InlineData("Festa do pu43dim", "2022-05-05", "Uma festa onde23432 cada um leva seu pudim!", "normal", "Evento = Festa do pudim\nDate = 05/05/2022\n")]
    [InlineData("Festa do gfdbolo", "2022-10-10", "Uma festa onde chgrada um leva seu bolo!", "normal","Evento = Festa do bolo\nDate = 10/10/2022\n")]
    [InlineData("Festa do phgfudim", "2022-05-05", "Uma festa onde cahfghda um leva seu pudim!", "detailed", "Evento = Festa do pudim\nDate = 05/05/2022\nDescription = Uma festa onde cada um leva seu pudim!")]
    [InlineData("Festa do bgolo", "2022-10-10", "Uma festa onde chgfhada um leva seu bolo!", "detailed","Evento = Festa do bolo\nDate = 10/10/2022\nDescription = Uma festa onde cada um leva seu bolo!")]
    public void TestFailTestPrintEvent(string title, string date, string description, string format, string expected)
    {
        TestReq1 instance = new();
        Action act = () => instance.TestPrintEvent(title, date, description, format, expected);
        act.Should().Throw<Xunit.Sdk.XunitException>();
        act.Should().NotThrow<NotImplementedException>();
    }

}