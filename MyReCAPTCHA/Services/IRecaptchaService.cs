using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MyReCAPTCHA.Services
{
    public interface IRecaptchaService
    {
        Task<bool> Verify(string recaptcha);
    }
}
