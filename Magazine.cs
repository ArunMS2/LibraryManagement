namespace LibraryManagement;

public class Magazine : Libraryitem
{
    public int IssueNumber { get; set; }

    public Magazine(int id,string title,int issueNumber)
    {
        id = id;
        Title = title;
        IssueNumber = issueNumber;
    }
    
}