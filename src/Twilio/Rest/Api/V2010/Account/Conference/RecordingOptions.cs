/// This code was generated by
/// \ / _    _  _|   _  _
///  | (_)\/(_)(_|\/| |(/_  v1.0.0
///       /       /

using System;
using System.Collections.Generic;
using Twilio.Base;
using Twilio.Converters;

namespace Twilio.Rest.Api.V2010.Account.Conference 
{

    /// <summary>
    /// Changes the status of the recording to paused, stopped, or in-progress. Note: To use `Twilio.CURRENT`, pass it as
    /// recording sid.
    /// </summary>
    public class UpdateRecordingOptions : IOptions<RecordingResource> 
    {
        /// <summary>
        /// The SID of the Account that created the resource(s) to update
        /// </summary>
        public string PathAccountSid { get; set; }
        /// <summary>
        /// Update by unique Conference SID for the recording
        /// </summary>
        public string PathConferenceSid { get; }
        /// <summary>
        /// The unique string that identifies this resource
        /// </summary>
        public string PathSid { get; }
        /// <summary>
        /// The new status of the resource
        /// </summary>
        public RecordingResource.StatusEnum Status { get; }
        /// <summary>
        /// Whether to record during a pause
        /// </summary>
        public string PauseBehavior { get; set; }

        /// <summary>
        /// Construct a new UpdateRecordingOptions
        /// </summary>
        /// <param name="pathConferenceSid"> Update by unique Conference SID for the recording </param>
        /// <param name="pathSid"> The unique string that identifies this resource </param>
        /// <param name="status"> The new status of the resource </param>
        public UpdateRecordingOptions(string pathConferenceSid, string pathSid, RecordingResource.StatusEnum status)
        {
            PathConferenceSid = pathConferenceSid;
            PathSid = pathSid;
            Status = status;
        }

        /// <summary>
        /// Generate the necessary parameters
        /// </summary>
        public List<KeyValuePair<string, string>> GetParams()
        {
            var p = new List<KeyValuePair<string, string>>();
            if (Status != null)
            {
                p.Add(new KeyValuePair<string, string>("Status", Status.ToString()));
            }

            if (PauseBehavior != null)
            {
                p.Add(new KeyValuePair<string, string>("PauseBehavior", PauseBehavior));
            }

            return p;
        }
    }

    /// <summary>
    /// Fetch an instance of a recording for a call
    /// </summary>
    public class FetchRecordingOptions : IOptions<RecordingResource> 
    {
        /// <summary>
        /// The SID of the Account that created the resource(s) to fetch
        /// </summary>
        public string PathAccountSid { get; set; }
        /// <summary>
        /// Fetch by unique Conference SID for the recording
        /// </summary>
        public string PathConferenceSid { get; }
        /// <summary>
        /// The unique string that identifies this resource
        /// </summary>
        public string PathSid { get; }

        /// <summary>
        /// Construct a new FetchRecordingOptions
        /// </summary>
        /// <param name="pathConferenceSid"> Fetch by unique Conference SID for the recording </param>
        /// <param name="pathSid"> The unique string that identifies this resource </param>
        public FetchRecordingOptions(string pathConferenceSid, string pathSid)
        {
            PathConferenceSid = pathConferenceSid;
            PathSid = pathSid;
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
    /// Delete a recording from your account
    /// </summary>
    public class DeleteRecordingOptions : IOptions<RecordingResource> 
    {
        /// <summary>
        /// The SID of the Account that created the resource(s) to delete
        /// </summary>
        public string PathAccountSid { get; set; }
        /// <summary>
        /// Delete by the recording's conference SID
        /// </summary>
        public string PathConferenceSid { get; }
        /// <summary>
        /// The unique string that identifies this resource
        /// </summary>
        public string PathSid { get; }

        /// <summary>
        /// Construct a new DeleteRecordingOptions
        /// </summary>
        /// <param name="pathConferenceSid"> Delete by the recording's conference SID </param>
        /// <param name="pathSid"> The unique string that identifies this resource </param>
        public DeleteRecordingOptions(string pathConferenceSid, string pathSid)
        {
            PathConferenceSid = pathConferenceSid;
            PathSid = pathSid;
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
    /// Retrieve a list of recordings belonging to the call used to make the request
    /// </summary>
    public class ReadRecordingOptions : ReadOptions<RecordingResource> 
    {
        /// <summary>
        /// The SID of the Account that created the resource(s) to read
        /// </summary>
        public string PathAccountSid { get; set; }
        /// <summary>
        /// Read by unique Conference SID for the recording
        /// </summary>
        public string PathConferenceSid { get; }
        /// <summary>
        /// The `date_created` value, specified as `YYYY-MM-DD`, of the resources to read
        /// </summary>
        public DateTime? DateCreatedBefore { get; set; }
        /// <summary>
        /// The `date_created` value, specified as `YYYY-MM-DD`, of the resources to read
        /// </summary>
        public DateTime? DateCreated { get; set; }
        /// <summary>
        /// The `date_created` value, specified as `YYYY-MM-DD`, of the resources to read
        /// </summary>
        public DateTime? DateCreatedAfter { get; set; }

        /// <summary>
        /// Construct a new ReadRecordingOptions
        /// </summary>
        /// <param name="pathConferenceSid"> Read by unique Conference SID for the recording </param>
        public ReadRecordingOptions(string pathConferenceSid)
        {
            PathConferenceSid = pathConferenceSid;
        }

        /// <summary>
        /// Generate the necessary parameters
        /// </summary>
        public override List<KeyValuePair<string, string>> GetParams()
        {
            var p = new List<KeyValuePair<string, string>>();
            if (DateCreated != null)
            {
                p.Add(new KeyValuePair<string, string>("DateCreated", DateCreated.Value.ToString("yyyy-MM-dd")));
            }
            else
            {
                if (DateCreatedBefore != null)
                {
                    p.Add(new KeyValuePair<string, string>("DateCreated<", DateCreatedBefore.Value.ToString("yyyy-MM-dd")));
                }

                if (DateCreatedAfter != null)
                {
                    p.Add(new KeyValuePair<string, string>("DateCreated>", DateCreatedAfter.Value.ToString("yyyy-MM-dd")));
                }
            }

            if (PageSize != null)
            {
                p.Add(new KeyValuePair<string, string>("PageSize", PageSize.ToString()));
            }

            return p;
        }
    }

}