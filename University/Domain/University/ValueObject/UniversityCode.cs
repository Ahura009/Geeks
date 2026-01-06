namespace University.Domain.University.ValueObject;

public sealed record UniversityCode
{
    private UniversityCode(string fullCode, string type, int year, int term, string code, int serial, int checksum)
    {
        FullCode = fullCode;
        Type = type;
        Year = year;
        Term = term;
        Code = code;
        Serial = serial;
        Checksum = checksum;
    }

    public string FullCode { get; }
    public string Type { get; }
    public int Year { get; }
    public int Term { get; }
    public string Code { get; }
    public int Serial { get; }
    public int Checksum { get; }


    public bool IsStudent => Type == "STU";
    public bool IsModule => Type == "MOD";
    public bool IsStaff => Type == "STF";

    public string Description =>
        $"{Type} {Year}T{Term} - {Code}-{Serial:D4}";


    public static UniversityCode Parse(string input)
    {
        return TryParse(input, out var code, out var error)
            ? code!
            : throw new FormatException(error);
    }

    public static bool TryParse(string input, out UniversityCode? code, out string? error)
    {
        code = null;
        error = null;

        var normalized = Normalize(input);

        if (!ValidateStructure(normalized, out error))
            return false;

        var parts = normalized.Split('-');

        if (!ParseParts(parts, out var data, out error))
            return false;

        code = new UniversityCode(normalized, data.type, data.year, data.term, data.code, data.serial, data.checksum);

        return true;
    }


    private static string Normalize(string input)
    {
        return input?.Trim().ToUpperInvariant() ?? string.Empty;
    }


    private static bool ValidateStructure(string value, out string? error)
    {
        error = null;

        var parts = value.Split('-');

        if (parts.Length != 6)
        {
            error = "کد باید شامل ۶ بخش جداشده با خط تیره باشد";
            return false;
        }

        if (parts[0] != "AU")
        {
            error = "پیشوند باید AU باشد";
            return false;
        }

        if (!new[] { "STU", "MOD", "STF" }.Contains(parts[1]))
        {
            error = "TYPE باید یکی از STU، MOD یا STF باشد";
            return false;
        }

        if (parts[2].Length != 5 || !parts[2].All(char.IsDigit))
        {
            error = "YEARTERM باید شامل ۴ رقم سال و ۱ رقم ترم باشد";
            return false;
        }

        if (parts[3].Length < 3 || parts[3].Length > 6 ||
            !parts[3].All(c => c >= 'A' && c <= 'Z'))
        {
            error = "CODE باید ۳ تا ۶ حرف بزرگ انگلیسی باشد";
            return false;
        }

        if (parts[4].Length != 4 || !parts[4].All(char.IsDigit))
        {
            error = "NNNN باید یک عدد ۴ رقمی باشد";
            return false;
        }

        if (parts[5].Length != 2 || !parts[5].All(char.IsDigit))
        {
            error = "CC باید یک عدد ۲ رقمی باشد";
            return false;
        }

        return true;
    }

    private static bool ParseParts(string[] parts,
        out (string type, int year, int term, string code, int serial, int checksum) data, out string? error)
    {
        data = default;
        error = null;

        var year = int.Parse(parts[2][..4]);
        if (year < 1000 || year > 9999)
        {
            error = "سال نامعتبر است";
            return false;
        }

        var term = parts[2][4] - '0';
        if (term < 1 || term > 3)
        {
            error = "ترم باید بین ۱ تا ۳ باشد";
            return false;
        }

        var serial = int.Parse(parts[4]);

        var checksum = int.Parse(parts[5]);

        var calculated = CalculateChecksum(parts[0] + parts[1] + parts[2] + parts[3] + parts[4]);

        if (checksum != calculated)
        {
            error = $"چکسام نامعتبر است (مقدار صحیح: {calculated:D2})";
            return false;
        }

        data = (parts[1], year, term, parts[3], serial, checksum);

        return true;
    }


    private static int CalculateChecksum(string value)
    {
        var sum = 0;

        foreach (var ch in value)
            sum += ch switch
            {
                >= '0' and <= '9' => ch - '0',
                >= 'A' and <= 'Z' => ch - 'A' + 10,
                _ => 0
            };

        return sum % 97;
    }

    public override string ToString()
    {
        return FullCode;
    }


    public static UniversityCode Create(string type, int year, int term, string code, int serial)
    {
        type = type?.Trim().ToUpperInvariant() ?? "";
        code = code?.Trim().ToUpperInvariant() ?? "";

        if (!new[] { "STU", "MOD", "STF" }.Contains(type))
            throw new ArgumentException("TYPE باید یکی از STU، MOD یا STF باشد");

        if (year < 1000 || year > 9999)
            throw new ArgumentException("سال باید ۴ رقمی باشد");

        if (term < 1 || term > 3)
            throw new ArgumentException("ترم باید بین ۱ تا ۳ باشد");

        if (code.Length < 3 || code.Length > 6 || !code.All(c => c >= 'A' && c <= 'Z'))
            throw new ArgumentException("CODE باید ۳ تا ۶ حرف بزرگ انگلیسی باشد");

        if (serial < 0 || serial > 9999)
            throw new ArgumentException("سریال باید بین 0000 تا 9999 باشد");


        var yearTerm = $"{year}{term}";
        var serialPart = serial.ToString("D4");

        var withoutChecksum =
            "AU" +
            type +
            yearTerm +
            code +
            serialPart;


        var checksum = CalculateChecksum(withoutChecksum);

        var fullCode = $"AU-{type}-{yearTerm}-{code}-{serialPart}-{checksum:D2}";
        return new UniversityCode(fullCode, type, year, term, code, serial, checksum);
    }
}