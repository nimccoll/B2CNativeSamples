namespace B2CXamarin.Services.Logon
{
    public static class B2CConstants
    {
        // Azure AD B2C Coordinates
        public static string Tenant = "{your B2C tenant name}.onmicrosoft.com";
        public static string AzureADB2CHostname = "login.microsoftonline.com";
        public static string ClientID = "{your client ID}";
        public static string PolicySignUpSignIn = "B2C_1A_signup_signin";
        public static string PolicyEditProfile = "B2C_1_SiPe";
        public static string PolicyResetPassword = "B2C_1_SSPR";

        public static string[] Scopes = { "https://graph.microsoft.com/profile" };

        public static string AuthorityBase = $"https://{AzureADB2CHostname}/tfp/{Tenant}/";
        public static string AuthoritySignInSignUp = $"{AuthorityBase}{PolicySignUpSignIn}";
        public static string AuthorityEditProfile = $"{AuthorityBase}{PolicyEditProfile}";
        public static string AuthorityPasswordReset = $"{AuthorityBase}{PolicyResetPassword}";
        public static string IOSKeyChainGroup = "com.microsoft.adalcache";
    }
}