using System;
using System.Collections.Generic;
using System.Diagnostics.SymbolStore;
using System.IO;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;
using System.Xml;
using Slave.WebReference;

namespace Slave
{
    class WebserviceContext
    {
        //attribute; connection to webservice, via reference.
        private WebReference.CrackingWS _wsContext;

        public List<ClientUserInfo> GetPasswords()
        {
            _wsContext = new CrackingWS(); // instancialize reference
            // Gets list of passwords from webservice.
            var passwordList = _wsContext.GetPasswords();
            var returnList = new List<ClientUserInfo>();
            // Even though the Userinfo class was identical in Webservice, it couldnt just take it in.
            // so we made a loop, which created a new list of UserInfo, from the information recieved from webservice.
            foreach (var userInfo in passwordList)
            {
                returnList.Add(new ClientUserInfo(userInfo.Username, userInfo.EntryptedPasswordBase64));
            }
            // return list that is now compatible with client.
            return returnList;
        }


        public List<string> GetDictionary()
        {
            _wsContext = new CrackingWS();  // instancialize reference
            // Get list of string, which contains dictionary lines.
            // the SOAP-connection we made, serializes our list to xml, and apparantly it is returned as an array.
            // so we call the .ToList method, to keep it as a list, as the Cracking program written for us, take a List as argument.
            var dictList = _wsContext.GetDictionary().ToList();

            // Return list that is now compatible with methods.
            return dictList;
        }


    }
}
