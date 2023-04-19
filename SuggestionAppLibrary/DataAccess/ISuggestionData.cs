namespace SuggestionAppLibrary.DataAccess
{
    public interface ISuggestionData
    {
        Task CreateSuggestion(SuggestionModel suggestion);
        Task<List<SuggestionModel>> GetAllApprovedSuggestions();
        Task<List<SuggestionModel>> GetAllSuggestions();
        Task<List<SuggestionModel>> GetAllSuggestionswaitingForApproval();
        Task<SuggestionModel> GetSuggestion(string id);
        Task<List<SuggestionModel>> GetUsersSuggestions(string userId);
        Task UpdateSuggestion(SuggestionModel suggestion);
        Task UpvoteSuggestion(string suggestionId, string userId);
    }
}