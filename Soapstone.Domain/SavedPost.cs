using System;

namespace Soapstone.Domain
{
    public class SavedPost : Entity
    {
        public Guid UserId { get; private set; }
        public User User { get; private set; }
        public Guid PostId { get; private set; }
        public Post Post { get; private set; }

        private SavedPost()
        {
        }

        public SavedPost(Guid userId, Guid postId)
        {
            UserId = userId;
            PostId = postId;
        }
    }
}