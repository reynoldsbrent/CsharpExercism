using System;

public static class LogAnalysis 
{
    // TODO: define the 'SubstringAfter()' extension method on the `string` type
    public static string SubstringAfter(this string str, string delimeter) {
        return str.Split(delimeter)[1];
    }

    // TODO: define the 'SubstringBetween()' extension method on the `string` type

    public static string SubstringBetween(this string str, string firstDelimeter, string secondDelimeter) {
        return str.Split(firstDelimeter)[1].Split(secondDelimeter)[0];
    }
    
    // TODO: define the 'Message()' extension method on the `string` type
    public static string Message(this string str) {
        return str.SubstringAfter(": ");
    }

    // TODO: define the 'LogLevel()' extension method on the `string` type
    public static string LogLevel(this string str) {
        return str.SubstringBetween("[", "]");
    }
}