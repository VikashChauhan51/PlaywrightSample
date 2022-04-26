using System.IO;

namespace PlaywrightSample.Utils;

public static class FileReader
{
    public static string Read(string filePath)
    {
        using (var stream = new StreamReader(new FileStream(filePath, FileMode.Open, FileAccess.Read, FileShare.Read)))
        {
            return stream.ReadToEnd();
        }
    }

    public static async Task<string> ReadAsync(string filePath)
    {
        using (var stream = new StreamReader(new FileStream(filePath, FileMode.Open, FileAccess.Read, FileShare.Read)))
        {
            return await stream.ReadToEndAsync();
        }
    }
}
