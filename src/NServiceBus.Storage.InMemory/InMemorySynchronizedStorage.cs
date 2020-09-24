namespace NServiceBus
{
    using System.Threading.Tasks;
    using Extensibility;
    using Persistence;

    class InMemorySynchronizedStorage2 : ISynchronizedStorage
    {
        public Task<CompletableSynchronizedStorageSession> OpenSession(ContextBag contextBag)
        {
            var session = (CompletableSynchronizedStorageSession) new InMemorySynchronizedStorageSession();
            return Task.FromResult(session);
        }
    }
}