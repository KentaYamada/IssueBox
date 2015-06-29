using IssueBox.Models.Infrastructure;

namespace IssueBox.Views.Infrastructure
{
    public interface IStatus
    {
        TASK_STATUS Status { get; }
    }
}
