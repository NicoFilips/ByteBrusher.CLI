using ByteBrusher.Model.Implementation;
using FluentAssertions;
using NUnit.Framework;

namespace ByteBrusher.CLI.Tests.SmokeTests;

[TestFixture]
public class StartUpTests
{
    private readonly string[] _args =
    [
        "--path", "/example/path",
        "--delete",
        "--video",
        "--textdocuments"
    ];

    [Test]
    public void ParseCommandLineOptions_WithAllArguments_ShouldReturnValidCliOptions()
    {
        // Arrange
        string[] args =
        [
            "--path", "/example/path",
            "--delete",
            "--video",
            "--textdocuments"
        ];

        // Act
        CliOptions result = ByteBrusher.Util.ByteParser.ParseCommandLineOptions(args);

        // Assert
        result.Should().NotBeNull();
        result.Path.Should().Be("/example/path");
        result.DeleteFlag.Should().BeTrue();
        result.IncludeVideos.Should().BeTrue();
        result.IncludeDocuments.Should().BeTrue();
    }

    [Test]
    public void ParseCommandLineOptions_WithMissingRequiredArgument_ShouldThrowException()
    {
        // Arrange
        string[] args =
        [
            "--delete",
            "--video",
            "--textdocuments"
        ];

        // Act
        Action act = () => ByteBrusher.Util.ByteParser.ParseCommandLineOptions(args);

        // Assert
        act.Should().Throw<ArgumentNullException>();
    }
}
