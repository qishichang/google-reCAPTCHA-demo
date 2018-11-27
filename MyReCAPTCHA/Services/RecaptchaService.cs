using Microsoft.Extensions.Configuration;
using Refit;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MyReCAPTCHA.Services
{
    public class RecaptchaService : IRecaptchaService
    {
        private readonly IConfiguration _configuration;
        public RecaptchaService(IConfiguration configuration)
        {
            _configuration = configuration;
        }

        public async Task<bool> Verify(string recaptcha)
        {
            var data = new Dictionary<string, object>();
            data.Add("secret", _configuration.GetValue<string>("RecaptchaSetting:Secrety")); // Use 'User Secrets'
            data.Add("response", recaptcha);
            var output = await RestService.For<IGoogleRecaptchaApi>("https://www.google.com/recaptcha/api").Verify(data);
            return output.Success;
        }
    }
}
