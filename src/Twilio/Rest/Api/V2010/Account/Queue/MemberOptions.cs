/// This code was generated by
/// \ / _    _  _|   _  _
///  | (_)\/(_)(_|\/| |(/_  v1.0.0
///       /       /

using System;
using System.Collections.Generic;
using Twilio.Base;
using Twilio.Converters;

namespace Twilio.Rest.Api.V2010.Account.Queue 
{

    /// <summary>
    /// Fetch a specific members of the queue
    /// </summary>
    public class FetchMemberOptions : IOptions<MemberResource> 
    {
        /// <summary>
        /// The account_sid
        /// </summary>
        public string PathAccountSid { get; set; }
        /// <summary>
        /// The Queue in which to find the members
        /// </summary>
        public string PathQueueSid { get; }
        /// <summary>
        /// The call_sid
        /// </summary>
        public string PathCallSid { get; }

        /// <summary>
        /// Construct a new FetchMemberOptions
        /// </summary>
        /// <param name="pathQueueSid"> The Queue in which to find the members </param>
        /// <param name="pathCallSid"> The call_sid </param>
        public FetchMemberOptions(string pathQueueSid, string pathCallSid)
        {
            PathQueueSid = pathQueueSid;
            PathCallSid = pathCallSid;
        }

        /// <summary>
        /// Generate the necessary parameters
        /// </summary>
        public List<KeyValuePair<string, string>> GetParams()
        {
            var p = new List<KeyValuePair<string, string>>();
            return p;
        }
    }

    /// <summary>
    /// Dequeue a member from a queue and have the member's call begin executing the TwiML document at that URL
    /// </summary>
    public class UpdateMemberOptions : IOptions<MemberResource> 
    {
        /// <summary>
        /// The account_sid
        /// </summary>
        public string PathAccountSid { get; set; }
        /// <summary>
        /// The Queue in which to find the members
        /// </summary>
        public string PathQueueSid { get; }
        /// <summary>
        /// The call_sid
        /// </summary>
        public string PathCallSid { get; }
        /// <summary>
        /// The url
        /// </summary>
        public Uri Url { get; }
        /// <summary>
        /// The method
        /// </summary>
        public Twilio.Http.HttpMethod Method { get; }

        /// <summary>
        /// Construct a new UpdateMemberOptions
        /// </summary>
        /// <param name="pathQueueSid"> The Queue in which to find the members </param>
        /// <param name="pathCallSid"> The call_sid </param>
        /// <param name="url"> The url </param>
        /// <param name="method"> The method </param>
        public UpdateMemberOptions(string pathQueueSid, string pathCallSid, Uri url, Twilio.Http.HttpMethod method)
        {
            PathQueueSid = pathQueueSid;
            PathCallSid = pathCallSid;
            Url = url;
            Method = method;
        }

        /// <summary>
        /// Generate the necessary parameters
        /// </summary>
        public List<KeyValuePair<string, string>> GetParams()
        {
            var p = new List<KeyValuePair<string, string>>();
            if (Url != null)
            {
                p.Add(new KeyValuePair<string, string>("Url", Url.AbsoluteUri.TrimEnd('/')));
            }

            if (Method != null)
            {
                p.Add(new KeyValuePair<string, string>("Method", Method.ToString()));
            }

            return p;
        }
    }

    /// <summary>
    /// Retrieve a list of members in the queue
    /// </summary>
    public class ReadMemberOptions : ReadOptions<MemberResource> 
    {
        /// <summary>
        /// The account_sid
        /// </summary>
        public string PathAccountSid { get; set; }
        /// <summary>
        /// The Queue in which to find members
        /// </summary>
        public string PathQueueSid { get; }

        /// <summary>
        /// Construct a new ReadMemberOptions
        /// </summary>
        /// <param name="pathQueueSid"> The Queue in which to find members </param>
        public ReadMemberOptions(string pathQueueSid)
        {
            PathQueueSid = pathQueueSid;
        }

        /// <summary>
        /// Generate the necessary parameters
        /// </summary>
        public override List<KeyValuePair<string, string>> GetParams()
        {
            var p = new List<KeyValuePair<string, string>>();
            if (PageSize != null)
            {
                p.Add(new KeyValuePair<string, string>("PageSize", PageSize.ToString()));
            }

            return p;
        }
    }

}