
namespace IssueBox.Views.Infrastructure
{
    interface IRequired
    {
        string AlertMessage { get; set; }

        bool Required { get; set; }
    }
}
