using CQRS.Core.Messages;

namespace Post.Cmd.Api
{
    public class AddCommentCommand:BaseCommand
    {
        public string Comment{get;set;}
        public string Username{get;set;}
    }
}