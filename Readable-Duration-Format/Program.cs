using Readable_Duration_Format.TimeFormatConverter;

internal class Program
{
    private static void Main(string[] args)
    {
        ToReadableTimeFormatConverter converter = new ToReadableTimeFormatConverter();
        
        Console.WriteLine(converter.TimeFormatConverter(92600));

        Console.WriteLine(converter.TimeFormatConverter(38005));

        Console.WriteLine(converter.TimeFormatConverter(3455));

        Console.WriteLine(converter.TimeFormatConverter(59));

        Console.WriteLine(converter.TimeFormatConverter(0));

        Console.WriteLine(converter.TimeFormatConverterII(92600));

        Console.WriteLine(converter.TimeFormatConverterII(38005));

        Console.WriteLine(converter.TimeFormatConverterII(3455));

        Console.WriteLine(converter.TimeFormatConverterII(59));

        Console.WriteLine(converter.TimeFormatConverterII(0));

    }
}