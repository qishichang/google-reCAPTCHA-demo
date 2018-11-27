using Newtonsoft.Json;
using Refit;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MyReCAPTCHA.Services.DTO
{
    public class RecaptchaOutput
    {
        public bool Success { get; set; }

        [JsonProperty(PropertyName = "challenge_ts")]
        public DateTime? ChallengeTs { get; set; } // UTC 

        public string Hostname { get; set; }

        [JsonProperty(PropertyName = "error-codes")]
        public string[] ErrorCodes { get; set; }
    }
}
