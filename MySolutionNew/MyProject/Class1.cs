namespace MyProject;

public static class StringOperations
{
    public static string ToLower(string s) => s?.ToLower() ?? "";
    
    public static int GetLength(string s) => s?.Length ?? 0;
}