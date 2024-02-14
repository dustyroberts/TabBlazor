using Newtonsoft.Json;
using System.Net.Http;

namespace NGageUI {
    public class ReCaptchaService : IReCaptchaService
    {
        public async Task<bool> ValidateResponse(string recaptchaRepsonse, string secretKey)
        {
            var validResonse = false;

            if (!string.IsNullOrEmpty(secretKey) && !string.IsNullOrEmpty(recaptchaRepsonse))
            { 
                var googleUrl = $"https://www.google.com/recaptcha/api/siteverify?secret={secretKey}&response={recaptchaRepsonse}";

                using var httpClient = new HttpClient();
                var request = new HttpRequestMessage(HttpMethod.Post, googleUrl);
                var response = httpClient.SendAsync(request);

                Console.WriteLine(response.Result.StatusCode);

                if (response.Result.StatusCode == System.Net.HttpStatusCode.OK)
                { 
                    var responseString = await response.Result.Content.ReadAsStringAsync();
                    var reCaptchaResponse = JsonConvert.DeserializeObject<ReCaptchaResponse>(responseString);

                    if (recaptchaRepsonse != null)
                    { 
                        validResonse = reCaptchaResponse.Success;
                    }
                }
            }
            return validResonse;
        }
    }
}
