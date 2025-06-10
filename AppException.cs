namespace LibraryManagement;

public class InvalidBookException : Exception
{
    public InvalidBookException(string message) : base(message)
    {}
}