using System;
using System.IO;
using System.Text;

namespace GeniyIdiotClassLibrary;

public static class FileStorage
{
    public static string GetResults(string fileName)
    {
        using var textReader = new StreamReader(Path.Combine(Environment.CurrentDirectory, fileName), Encoding.UTF8);
        return textReader.ReadToEnd();
    }

    public static void SaveResults(User user, string[] diagnoses, string fileName)
    {
        File.AppendAllText(Path.Combine(Environment.CurrentDirectory, fileName),
            $"{user._username}#{user._countRightAnswers}#{diagnoses[user._countRightAnswers]}\n");
    }

    public static bool Exists(string fileName)
    {
        return File.Exists(Path.Combine(Environment.CurrentDirectory, fileName));
    }

    public static void Clear(string fileName)
    {
        File.WriteAllText(Path.Combine(Environment.CurrentDirectory, fileName), string.Empty);
    }
}