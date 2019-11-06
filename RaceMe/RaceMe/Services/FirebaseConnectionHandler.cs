using Firebase.Auth;
using Firebase.Database;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace RaceMe.Services
{
    class FirebaseDataHandler
    {
        //Constants
        private const string API_KEY = "AIzaSyCQQzBssl_mJ4o7XiQbjl-p8AlQK_QD918";
        private const string DBURL = "https://dummyortest.firebaseio.com/";

        //Static variables
        private static FirebaseDataHandler self;

        //Properties
        private FirebaseAuthLink auth;
        private FirebaseClient firebase;

        private FirebaseDataHandler()
        {}
        public static FirebaseDataHandler GetDataHandler()
        {
            if (self == null)
                self = new FirebaseDataHandler();
            return self;
        }
        public async Task<bool> AuthenticateWithEmail(string email, string password)
        {
            try
            {
                FirebaseAuthProvider authProvider = new FirebaseAuthProvider(new FirebaseConfig(API_KEY));
                auth = await authProvider.SignInWithEmailAndPasswordAsync(email, password);

                firebase = new FirebaseClient(DBURL, new FirebaseOptions
                {
                    AuthTokenAsyncFactory = () => Task.FromResult(auth.FirebaseToken)
                });
                return true;
            }
            catch(FirebaseAuthException)
            {
                return false;
            }
        }
    }
}
