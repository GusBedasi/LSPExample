namespace LSPLibrary.Domain.Contracts
{
    public interface IManaged : IEmployee
    {
        IEmployee Manager { get; set;}
        void AssignManager(IEmployee manager);
    }
}