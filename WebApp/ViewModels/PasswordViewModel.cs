using ApplicationCore.Entities;

namespace WebApp.ViewModels
{
    public record PasswordViewModel
    {
        public string Id { get; set; }
        public string PasswordContent { get; set; }
        public string UsedAlphabit { get; set; }
        public PasswordViewModel(string id, string passwordContent, string usedAlphabit)
        {
            Id = id;
            PasswordContent = passwordContent;
            UsedAlphabit = usedAlphabit;
        }
        public PasswordViewModel(Password password)
        {
            Id = password.Id;
            PasswordContent = password.PasswordContent;
            UsedAlphabit = password.UsedAlphabit;
        }
    }
}
