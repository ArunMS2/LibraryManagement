namespace LibraryManagement;

public class Magazine : Libraryitem
{
    public int ID;
    public int IssueNumber { get; set; }

    public Magazine(int id,string title,int issueNumber)
    {
        Id = id;
        Title = title;
        IssueNumber = issueNumber;
    }
    
}