using ByteBrusher.Model.Implementation;
using CommandLine;

namespace ByteBrusher.Util;

public class ByteParser
{
    public static CliOptions ParseCommandLineOptions(string[] args)
    {
        ParserResult<CliOptions>? parsedOptions = Parser.Default.ParseArguments<CliOptions>(args);
        return parsedOptions.Tag == ParserResultType.Parsed
            ? ((Parsed<CliOptions>)parsedOptions).Value
            : throw new ArgumentNullException(nameof(args));
    }
}