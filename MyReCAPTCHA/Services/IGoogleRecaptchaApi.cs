using MyReCAPTCHA.Services.DTO;
using Refit;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MyReCAPTCHA.Services
{
    public interface IGoogleRecaptchaApi
    {
        [Post("/siteverify")]
        Task<RecaptchaOutput> Verify([Body(BodySerializationMethod.UrlEncoded)] Dictionary<string, object> data);
    }
}
