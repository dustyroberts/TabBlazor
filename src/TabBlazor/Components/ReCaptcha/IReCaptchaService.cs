namespace NGageUI
{
    public interface IReCaptchaService
    {
        Task<bool> ValidateResponse(string recaptchaRepsonse, string secretKey);
    }
}
