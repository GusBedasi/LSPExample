namespace LSPLibrary.Domain.Contracts
{
    public interface IManager : IEmployee
    {
        void GeneratePerformanceReview();
    }
}