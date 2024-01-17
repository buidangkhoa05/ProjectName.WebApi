using FirebaseAdmin.Auth;

namespace ProjectName.Application.Firebase
{
    public interface IFirebaseClient : IDisposable
    {
        public FirebaseAuth FirebaseAuth { get; }
    }
}
