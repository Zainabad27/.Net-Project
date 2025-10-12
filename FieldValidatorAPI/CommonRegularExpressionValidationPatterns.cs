using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FieldValidatorAPI
{
    public class CommonRegularExpressionValidationPatterns
    {
        // Email address validation
        public const string Email_Address_RegEx_Pattern =
            @"^[A-Za-z0-9._%+-]+@[A-Za-z0-9.-]+\.[A-Za-z]{2,}$";

        // UK phone number (accepts +44 or 0 followed by 9–10 digits)
        public const string Pk_PhoneNumber_RegEx_Pattern =
            "^[1-9][0-9]{4}$";

        // UK postcode (standard official pattern)
        public const string Uk_Post_Code_RegEx_Pattern =
            @"^(GIR\s?0AA|[A-Z]{1,2}\d[A-Z\d]?\s?\d[A-Z]{2})$";

        // Strong password: min 8 chars, 1 uppercase, 1 lowercase, 1 digit, 1 special char
        public const string Strong_Password_RegEx_Pattern =
            @"^(?=.*[a-z])(?=.*[A-Z])(?=.*\d)(?=.*[^\w\s]).{8,}$";
    }
}
