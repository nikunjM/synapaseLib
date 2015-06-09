using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json;


namespace SyanpasePayLib
{
    class Settings
    {
        //API TEST VALUE 
        public const string API_TEST_VALUE = "https://sandbox.synapsepay.com/api/v2/";
        //IN PRODUCTION VALUE
        public const string API_PRODUCTION_VALUE = "https://synapsepay.com/api/v2/";
        

        //FOR LIVE PROJECT USE
        ////////////////////////////////////////////////////////////////////
        // API_TEST_VALUE=API_PRODUCTION_VALUE;
        /////////////////////////////////////////////////////////////////////

        //CAN BE USED FOR SELECTING METHOD AND ENDPOINT FOR CREATE USER
        public const string ACCOUNT_CREATE_METHOD = "POST";
        public const string ACCOUNT_CREATE_ENDPOINT = "user/create";

        //CAN BE USED FOR SELECTING METHOD AND ENDPOINT FOR LOGIN USER
        public const string ACCOUNT_LOGIN_METHOD = "POST";
        public const string ACCOUNT_LOGIN_ENDPOINT = "user/login";

        //CAN BE USED FOR SELECTING METHOD AND ENDPOINT FOR Refresh Access
        public const string ACCOUNT_REFRESH_ACCESS_METHOD = "POST";
        public const string ACCOUNT_REFRESH_ACCESS_ENDPOINT = "user/refresh";

        //CAN BE USED FOR SELECTING METHOD AND ENDPOINT FOR EDIT USER INFO
        public const string ACCOUNT_EDIT_INFO_METHOD = "POST";
        public const string ACCOUNT_EDIT_INFO_ENDPOINT = "user/edit";

        //CAN BE USED FOR SELECTING METHOD AND ENDPOINT FOR VIEW USER INFO
        public const string ACCOUNT_VIEW_INFO_METHOD = "POST";
        public const string ACCOUNT_VIEW_INFO_ENDPOINT = "user/show";

        //CAN BE USED FOR SELECTING METHOD AND ENDPOINT FOR LINKING BANK ACCOUNT
        public const string BANK_LINK_BANK_ACCOUNT_METHOD = "POST";
        public const string BANK_LINK_BANK_ACCOUNT_ENDPOINT = "bank/login";

        //CAN BE USED FOR SELECTING METHOD AND ENDPOINT FOR MFA BANK LOGIN 
        public const string BANK_MFA_BANK_LOGIN_METHOD = "POST";
        public const string BANK_MFA_BANK_LOGIN_ENDPOINT = "bank/mfa";

        //CAN BE USED FOR SELECTING METHOD AND ENDPOINT FOR REFRESH BANK LOGIN 
        public const string BANK_REFRESH_BANK_LOGIN_METHOD = "POST";
        public const string BANK_REFRESH_BANK_LOGIN_ENDPOINT = "bank/refresh";

        //CAN BE USED FOR SELECTING METHOD AND ENDPOINT FOR ADDING BANK
        public const string BANK_ADD_BANK_METHOD = "POST";
        public const string BANK_ADD_BANK_ENDPOINT = "bank/add";

        //CAN BE USED FOR SELECTING METHOD AND ENDPOINT FOR REMOVING BANK
        public const string BANK_REMOVE_BANK_METHOD = "POST";
        public const string BANK_REMOVE_BANK_ENDPOINT = "bank/delete";

        //CAN BE USED FOR SELECTING METHOD AND ENDPOINT FOR VIEWING LINK BANKS
        public const string BANK_VIEWING_BANK_METHOD = "POST";
        public const string BANK_VIEWING_BANK_ENDPOINT = "bank/show";

        //CAN BE USED FOR SELECTING METHOD AND ENDPOINT FOR SETTING PRIMARY ACCOUNTS
        public const string BANK_SETTING_PRIMARY_BANK_METHOD = "POST";
        public const string BANK_SETTING_PRIMARY_BANK_ENDPOINT = "bank/setprimary";

        //CAN BE USED FOR SELECTING METHOD AND ENDPOINT FOR CREATING ORDER
        public const string ORDER_CREATE_ORDER_METHOD = "POST";
        public const string ORDER_CREATE_ORDER_ENDPOINT = "order/add";

        //CAN BE USED FOR SELECTING METHOD AND ENDPOINT FOR POLLING ORDER
        public const string ORDER_ORDER_POLL_METHOD = "POST";
        public const string ORDER_ORDER_POLL_ENDPOINT = "order/poll";

        //CAN BE USED FOR SELECTING METHOD AND ENDPOINT FOR UPDATING ORDER
        public const string ORDER_UPDATE_METHOD = "POST";
        public const string ORDER_UPDATE_ENDPOINT = "order/update";

        //CAN BE USED FOR SELECTING METHOD AND ENDPOINT FOR VOID ORDER
        public const string ORDER_VOID_METHOD = "POST";
        public const string ORDER_VOID_ENDPOINT = "order/void";

        //CAN BE USED FOR SELECTING METHOD AND ENDPOINT FOR VIEW RECENT ORDER
        public const string ORDER_VIEW_RECENT_METHOD = "POST";
        public const string ORDER_VIEW_RECENT_ENDPOINT = "order/recent";


        //CAN BE USED FOR SELECTING METHOD AND ENDPOINT FOR Deposite fund to bank
        public const string DEPOSIT_FUNDS_TO_BANK_METHOD = "POST";
        public const string DEPOSIT_FUNDS_TO_BANK_ENDPOINT = "deposit/add";

        //CAN BE USED FOR SELECTING METHOD AND ENDPOINT FOR MICRO Deposite fund to bank
        public const string MICRODEPOSIT_FUNDS_TO_BANK_METHOD = "POST";
        public const string MICRODEPOSIT_FUNDS_TO_BANK_ENDPOINT = "deposit/micro";

        //CAN BE USED FOR SELECTING METHOD AND ENDPOINT FOR VIEW Deposite fund 
        public const string VIEW_DEPOSIT_FUNDS_METHOD = "POST";
        public const string VIEW_DEPOSIT_FUNDS_ENDPOINT = "deposit/show";

        //CAN BE USED FOR SELECTING METHOD AND ENDPOINT FOR WIRE
        public const string WIRE_DEPOSIT_FUNDS_METHOD = "POST";
        public const string WIRE_DEPOSIT_FUNDS_ENDPOINT = "wireout/add";

        //CAN BE USED FOR SELECTING METHOD AND ENDPOINT FOR VIEW WIRE 
        public const string WIRE_VIEW_FUNDS_METHOD = "POST";
        public const string WIRE_VIEW_FUNDS_ENDPOINT = "wireout/show";
        
        //CAN BE USED FOR SELECTING METHOD AND ENDPOINT FOR WITHDARW FUNDS
        public const string WITHDRAW_FUNDS_METHOD = "POST";
        public const string WITHDRAW_FUNDS_ENDPOINT = "withdraw/add";

        //CAN BE USED FOR SELECTING METHOD AND ENDPOINT FOR VIEW FUNDS
        public const string VIEW_WITHDRAW_FUNDS_METHOD = "POST";
        public const string VIEW_WITHDRAW_FUNDS_ENDPOINT = "withdraw/show";

        //CAN BE USED FOR SELECTING METHOD AND ENDPOINT FOR INCOMING WIRE NOTICES
        public const string INCOMING_WIRE_FUNDS_METHOD = "POST";
        public const string INCOMING_WIRE_FUNDS_ENDPOINT = "wirein/add";

        //CAN BE USED FOR SELECTING METHOD AND ENDPOINT FOR VIEW INCOMING WIRE NOTICES
        public const string VIEW_INCOMING_WIRE_FUNDS_METHOD = "POST";
        public const string VIEW_INCOMING_WIRE_FUNDS_ENDPOINT = "wirein/show";

        //CAN BE USED FOR SELECTING METHOD AND ENDPOINT FOR ADD CARDS
        public const string ADD_CARDS_METHOD = "POST";
        public const string ADD_CARDS_ENDPOINT = "card/add";

        //CAN BE USED FOR SELECTING METHOD AND ENDPOINT FOR EDIT CARDS
        public const string EDIT_CARDS_METHOD = "POST";
        public const string EDIT_CARDS_ENDPOINT = "card/edit";


        //CAN BE USED FOR SELECTING METHOD AND ENDPOINT FOR SHOW CARDS
        public const string SHOW_CARDS_METHOD = "POST";
        public const string SHOW_CARDS_ENDPOINT = "card/show";

        //CAN BE USED FOR SELECTING METHOD AND ENDPOINT FOR MASS PAY
        public const string Add_MASS_PAY_REQUEST_METHOD = "POST";
        public const string Add_MASS_PAY_REQUEST_ENDPOINT = "masspay/add";

        //CAN BE USED FOR SELECTING METHOD AND ENDPOINT FOR SHOW CARDS
        public const string Add_MASS_PAY_REQUEST_BYCARDS_METHOD = "POST";
        public const string Add_MASS_PAY_REQUEST_BYCARDS_ENDPOINT = "masspay/add";

        //CAN BE USED FOR SELECTING METHOD AND ENDPOINT FOR SHOW MASSPAY
        public const string SHOW_MASS_PAY_REQUEST_METHOD = "POST";
        public const string SHOW_MASS_PAY_REQUEST_ENDPOINT = "masspay/show";

        //CAN BE USED FOR SELECTING METHOD AND ENDPOINT FOR CANCLE MASSPAY
        public const string CANCEL_MASS_PAY_REQUEST_METHOD = "POST";
        public const string CANCEL_MASS_PAY_REQUEST_ENDPOINT = "masspay/cancel";
        






        

        private string URL_ACCOUNT;
        private string URL_VALIDATE_ACCOUNT;
        private string URL_ACCOUNT_CREATE;
        private string URL_TEAM;
        private string URL_TEAM_CREATE;
        private string URL_TEAM_DESTROY;
        private string URL_TEAM_ADD_MEMBER;
        private string URL_TEAM_REMOVE_MEMBER;
        private string URL_SIGNATURE_REQUEST;
        private string URL_SIGNATURE_REQUEST_LIST;
        private string URL_SIGNATURE_REQUEST_SEND;
        private string URL_TEMPLATE;
        private string URL_TEMPLATE_LIST;
        private string URL_TEMPLATE_ADD_USER;
        private string URL_TEMPLATE_REMOVE_USER;
        private string URL_TEMPLATE_DELETE;
        private string URL_TEMPLATE_CREATE_EMBEDDED_DRAFT; // Embedded Templates
        private string URL_TEMPLATE_SIGNATURE_REQUEST;
        private string URL_SIGNATURE_REQUEST_CANCEL;
        private string URL_SIGNATURE_REQUEST_REMIND;
        private string URL_SIGNATURE_REQUEST_FINAL_COPY;
        private string URL_SIGNATURE_REQUEST_FILES;
        private string URL_SIGNATURE_REQUEST_EMBEDDED;
        private string URL_SIGNATURE_REQUEST_EMBEDDED_TEMPLATE;
        private string URL_EMBEDDED_SIGN_URL;
        private string URL_EMBEDDED_EDIT_URL; // Embedded Templates
        private string URL_UNCLAIMED_DRAFT_CREATE;
        private string URL_UNCLAIMED_DRAFT_CREATE_EMBEDDED;
        private string URL_UNCLAIMED_DRAFT_CREATE_EMBEDDED_WITH_TEMPLATE;

        private string URL_PARAM_FILE_TYPE = "file_type";

        public const string FINAL_COPY_FILE_NAME = "final-copy";
        public const string FINAL_COPY_FILE_EXT = "pdf";

        public const string FILES_FILE_NAME = "files";
        public const string FILES_FILE_EXT = "pdf";

        public const string OAUTH_CODE = "code";
        public const string OAUTH_STATE = "state";
        public const string OAUTH_GRANT_TYPE = "grant_type";
        public const string OAUTH_REFRESH_TOKEN = "refresh_token";
        public const string OAUTH_GRANT_TYPE_AUTHORIZE_CODE = "authorization_code";
        public const string OAUTH_GRANT_TYPE_REFRESH_TOKEN = "refresh_token";

        public const string CLIENT_SECRET = "client_secret";
        public const string CLIENT_ID = "client_id";
        public static class Globals
        {
           // parameterless constructor required for static class
            static Globals()
            {
                CLIENT_ID = "836db45feb835d2cd5d2";
                CLIENT_SECRET = "ca1c5db06d50d047ac294f4acb31cf0958bcfdf6";
                API_TEST_VALUE = "https://sandbox.synapsepay.com/api/v2/";
                              
            } // default value

            // public get, and private set for strict access control
            public static string CLIENT_ID { get; private set; }
            public static string CLIENT_SECRET { get; private set; }
            public static string API_TEST_VALUE { get; private set; }

            // Clientid and client secret can be changed can be changed only via this method
            public static void SetGlobalInt(string client_Id, string Client_secret)
            {
                CLIENT_ID = client_Id;
                CLIENT_SECRET = Client_secret;
            }
        }
        //To call URL, method and contentType;
        public class Endpoint
        {
            public string Method { get; set; }
            public string ExtendedUrl { get; set; }

        }
        
    }
}
