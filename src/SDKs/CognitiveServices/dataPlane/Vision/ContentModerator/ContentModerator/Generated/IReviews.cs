// <auto-generated>
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.
// </auto-generated>

namespace Microsoft.CognitiveServices.ContentModerator
{
    using Microsoft.Rest;
    using Models;
    using System.Collections;
    using System.Collections.Generic;
    using System.IO;
    using System.Threading;
    using System.Threading.Tasks;

    /// <summary>
    /// Reviews operations.
    /// </summary>
    public partial interface IReviews
    {
        /// <summary>
        /// Returns review details for the review Id passed.
        /// </summary>
        /// <param name='teamName'>
        /// Your Team Name.
        /// </param>
        /// <param name='reviewId'>
        /// Id of the review.
        /// </param>
        /// <param name='customHeaders'>
        /// The headers that will be added to request.
        /// </param>
        /// <param name='cancellationToken'>
        /// The cancellation token.
        /// </param>
        /// <exception cref="APIErrorException">
        /// Thrown when the operation returned an invalid status code
        /// </exception>
        /// <exception cref="Microsoft.Rest.SerializationException">
        /// Thrown when unable to deserialize the response
        /// </exception>
        /// <exception cref="Microsoft.Rest.ValidationException">
        /// Thrown when a required parameter is null
        /// </exception>
        Task<HttpOperationResponse<Review>> GetReviewWithHttpMessagesAsync(string teamName, string reviewId, Dictionary<string, List<string>> customHeaders = null, CancellationToken cancellationToken = default(CancellationToken));
        /// <summary>
        /// Get the Job Details for a Job Id.
        /// </summary>
        /// <param name='teamName'>
        /// Your Team Name.
        /// </param>
        /// <param name='jobId'>
        /// Id of the job.
        /// </param>
        /// <param name='customHeaders'>
        /// The headers that will be added to request.
        /// </param>
        /// <param name='cancellationToken'>
        /// The cancellation token.
        /// </param>
        /// <exception cref="APIErrorException">
        /// Thrown when the operation returned an invalid status code
        /// </exception>
        /// <exception cref="Microsoft.Rest.SerializationException">
        /// Thrown when unable to deserialize the response
        /// </exception>
        /// <exception cref="Microsoft.Rest.ValidationException">
        /// Thrown when a required parameter is null
        /// </exception>
        Task<HttpOperationResponse<Job>> GetJobDetailsWithHttpMessagesAsync(string teamName, string jobId, Dictionary<string, List<string>> customHeaders = null, CancellationToken cancellationToken = default(CancellationToken));
        /// <summary>
        /// The reviews created would show up for Reviewers on your team. As
        /// Reviewers complete reviewing, results of the Review would be POSTED
        /// (i.e. HTTP POST) on the specified CallBackEndpoint.
        ///
        /// &lt;h3&gt;CallBack Schemas &lt;/h3&gt;
        /// &lt;h4&gt;Review Completion CallBack Sample&lt;/h4&gt;
        /// &lt;p&gt;
        /// {&lt;br/&gt;
        /// "ReviewId": "&lt;Review Id&gt;",&lt;br/&gt;
        /// "ModifiedOn": "2016-10-11T22:36:32.9934851Z",&lt;br/&gt;
        /// "ModifiedBy": "&lt;Name of the Reviewer&gt;",&lt;br/&gt;
        /// "CallBackType": "Review",&lt;br/&gt;
        /// "ContentId": "&lt;The ContentId that was specified
        /// input&gt;",&lt;br/&gt;
        /// "Metadata": {&lt;br/&gt;
        /// "adultscore": "0.xxx",&lt;br/&gt;
        /// "a": "False",&lt;br/&gt;
        /// "racyscore": "0.xxx",&lt;br/&gt;
        /// "r": "True"&lt;br/&gt;
        /// },&lt;br/&gt;
        /// "ReviewerResultTags": {&lt;br/&gt;
        /// "a": "False",&lt;br/&gt;
        /// "r": "True"&lt;br/&gt;
        /// }&lt;br/&gt;
        /// }&lt;br/&gt;
        ///
        /// &lt;/p&gt;.
        /// </summary>
        /// <param name='urlContentType'>
        /// The content type.
        /// </param>
        /// <param name='teamName'>
        /// Your team name.
        /// </param>
        /// <param name='createReviewBody'>
        /// Body for create reviews API
        /// </param>
        /// <param name='subTeam'>
        /// SubTeam of your team, you want to assign the created review to.
        /// </param>
        /// <param name='customHeaders'>
        /// The headers that will be added to request.
        /// </param>
        /// <param name='cancellationToken'>
        /// The cancellation token.
        /// </param>
        /// <exception cref="APIErrorException">
        /// Thrown when the operation returned an invalid status code
        /// </exception>
        /// <exception cref="Microsoft.Rest.SerializationException">
        /// Thrown when unable to deserialize the response
        /// </exception>
        /// <exception cref="Microsoft.Rest.ValidationException">
        /// Thrown when a required parameter is null
        /// </exception>
        Task<HttpOperationResponse<IList<string>>> CreateReviewsWithHttpMessagesAsync(string urlContentType, string teamName, IList<CreateReviewBodyItem> createReviewBody, string subTeam = default(string), Dictionary<string, List<string>> customHeaders = null, CancellationToken cancellationToken = default(CancellationToken));
        /// <summary>
        /// A job Id will be returned for the content posted on this endpoint.
        ///
        /// Once the content is evaluated against the Workflow provided the
        /// review will be created or ignored based on the workflow expression.
        ///
        /// &lt;h3&gt;CallBack Schemas &lt;/h3&gt;
        ///
        /// &lt;p&gt;
        /// &lt;h4&gt;Job Completion CallBack Sample&lt;/h4&gt;&lt;br/&gt;
        ///
        /// {&lt;br/&gt;
        /// "JobId": "&lt;Job Id&gt;,&lt;br/&gt;
        /// "ReviewId": "&lt;Review Id, if the Job resulted in a Review to be
        /// created&gt;",&lt;br/&gt;
        /// "WorkFlowId": "default",&lt;br/&gt;
        /// "Status": "&lt;This will be one of Complete, InProgress,
        /// Error&gt;",&lt;br/&gt;
        /// "ContentType": "Image",&lt;br/&gt;
        /// "ContentId": "&lt;This is the ContentId that was specified on
        /// input&gt;",&lt;br/&gt;
        /// "CallBackType": "Job",&lt;br/&gt;
        /// "Metadata": {&lt;br/&gt;
        /// "adultscore": "0.xxx",&lt;br/&gt;
        /// "a": "False",&lt;br/&gt;
        /// "racyscore": "0.xxx",&lt;br/&gt;
        /// "r": "True"&lt;br/&gt;
        /// }&lt;br/&gt;
        /// }&lt;br/&gt;
        ///
        /// &lt;/p&gt;
        /// &lt;p&gt;
        /// &lt;h4&gt;Review Completion CallBack Sample&lt;/h4&gt;&lt;br/&gt;
        ///
        /// {
        /// "ReviewId": "&lt;Review Id&gt;",&lt;br/&gt;
        /// "ModifiedOn": "2016-10-11T22:36:32.9934851Z",&lt;br/&gt;
        /// "ModifiedBy": "&lt;Name of the Reviewer&gt;",&lt;br/&gt;
        /// "CallBackType": "Review",&lt;br/&gt;
        /// "ContentId": "&lt;The ContentId that was specified
        /// input&gt;",&lt;br/&gt;
        /// "Metadata": {&lt;br/&gt;
        /// "adultscore": "0.xxx",
        /// "a": "False",&lt;br/&gt;
        /// "racyscore": "0.xxx",&lt;br/&gt;
        /// "r": "True"&lt;br/&gt;
        /// },&lt;br/&gt;
        /// "ReviewerResultTags": {&lt;br/&gt;
        /// "a": "False",&lt;br/&gt;
        /// "r": "True"&lt;br/&gt;
        /// }&lt;br/&gt;
        /// }&lt;br/&gt;
        ///
        /// &lt;/p&gt;.
        /// </summary>
        /// <param name='teamName'>
        /// Your team name.
        /// </param>
        /// <param name='contentType'>
        /// Image, Text or Video. Possible values include: 'Image', 'Text',
        /// 'Video'
        /// </param>
        /// <param name='contentId'>
        /// Id/Name to identify the content submitted.
        /// </param>
        /// <param name='workflowName'>
        /// Workflow Name that you want to invoke.
        /// </param>
        /// <param name='jobContentType'>
        /// The content type. Possible values include: 'application/json',
        /// 'image/jpeg'
        /// </param>
        /// <param name='content'>
        /// Content to evaluate.
        /// </param>
        /// <param name='callBackEndpoint'>
        /// Callback endpoint for posting the create job result.
        /// </param>
        /// <param name='customHeaders'>
        /// The headers that will be added to request.
        /// </param>
        /// <param name='cancellationToken'>
        /// The cancellation token.
        /// </param>
        /// <exception cref="APIErrorException">
        /// Thrown when the operation returned an invalid status code
        /// </exception>
        /// <exception cref="Microsoft.Rest.SerializationException">
        /// Thrown when unable to deserialize the response
        /// </exception>
        /// <exception cref="Microsoft.Rest.ValidationException">
        /// Thrown when a required parameter is null
        /// </exception>
        Task<HttpOperationResponse<JobId>> CreateJobWithHttpMessagesAsync(string teamName, string contentType, string contentId, string workflowName, string jobContentType, Content content, string callBackEndpoint = default(string), Dictionary<string, List<string>> customHeaders = null, CancellationToken cancellationToken = default(CancellationToken));
        /// <summary>
        /// The reviews created would show up for Reviewers on your team. As
        /// Reviewers complete reviewing, results of the Review would be POSTED
        /// (i.e. HTTP POST) on the specified CallBackEndpoint.
        ///
        /// &lt;h3&gt;CallBack Schemas &lt;/h3&gt;
        /// &lt;h4&gt;Review Completion CallBack Sample&lt;/h4&gt;
        /// &lt;p&gt;
        /// {&lt;br/&gt;
        /// "ReviewId": "&lt;Review Id&gt;",&lt;br/&gt;
        /// "ModifiedOn": "2016-10-11T22:36:32.9934851Z",&lt;br/&gt;
        /// "ModifiedBy": "&lt;Name of the Reviewer&gt;",&lt;br/&gt;
        /// "CallBackType": "Review",&lt;br/&gt;
        /// "ContentId": "&lt;The ContentId that was specified
        /// input&gt;",&lt;br/&gt;
        /// "Metadata": {&lt;br/&gt;
        /// "adultscore": "0.xxx",&lt;br/&gt;
        /// "a": "False",&lt;br/&gt;
        /// "racyscore": "0.xxx",&lt;br/&gt;
        /// "r": "True"&lt;br/&gt;
        /// },&lt;br/&gt;
        /// "ReviewerResultTags": {&lt;br/&gt;
        /// "a": "False",&lt;br/&gt;
        /// "r": "True"&lt;br/&gt;
        /// }&lt;br/&gt;
        /// }&lt;br/&gt;
        ///
        /// &lt;/p&gt;.
        /// </summary>
        /// <param name='teamName'>
        /// Your team name.
        /// </param>
        /// <param name='reviewId'>
        /// Id of the review.
        /// </param>
        /// <param name='timescale'>
        /// Timescale of the video you are adding frames to.
        /// </param>
        /// <param name='customHeaders'>
        /// The headers that will be added to request.
        /// </param>
        /// <param name='cancellationToken'>
        /// The cancellation token.
        /// </param>
        /// <exception cref="APIErrorException">
        /// Thrown when the operation returned an invalid status code
        /// </exception>
        /// <exception cref="Microsoft.Rest.ValidationException">
        /// Thrown when a required parameter is null
        /// </exception>
        Task<HttpOperationResponse> AddVideoFrameWithHttpMessagesAsync(string teamName, string reviewId, int? timescale = default(int?), Dictionary<string, List<string>> customHeaders = null, CancellationToken cancellationToken = default(CancellationToken));
        /// <summary>
        /// The reviews created would show up for Reviewers on your team. As
        /// Reviewers complete reviewing, results of the Review would be POSTED
        /// (i.e. HTTP POST) on the specified CallBackEndpoint.
        ///
        /// &lt;h3&gt;CallBack Schemas &lt;/h3&gt;
        /// &lt;h4&gt;Review Completion CallBack Sample&lt;/h4&gt;
        /// &lt;p&gt;
        /// {&lt;br/&gt;
        /// "ReviewId": "&lt;Review Id&gt;",&lt;br/&gt;
        /// "ModifiedOn": "2016-10-11T22:36:32.9934851Z",&lt;br/&gt;
        /// "ModifiedBy": "&lt;Name of the Reviewer&gt;",&lt;br/&gt;
        /// "CallBackType": "Review",&lt;br/&gt;
        /// "ContentId": "&lt;The ContentId that was specified
        /// input&gt;",&lt;br/&gt;
        /// "Metadata": {&lt;br/&gt;
        /// "adultscore": "0.xxx",&lt;br/&gt;
        /// "a": "False",&lt;br/&gt;
        /// "racyscore": "0.xxx",&lt;br/&gt;
        /// "r": "True"&lt;br/&gt;
        /// },&lt;br/&gt;
        /// "ReviewerResultTags": {&lt;br/&gt;
        /// "a": "False",&lt;br/&gt;
        /// "r": "True"&lt;br/&gt;
        /// }&lt;br/&gt;
        /// }&lt;br/&gt;
        ///
        /// &lt;/p&gt;.
        /// </summary>
        /// <param name='teamName'>
        /// Your team name.
        /// </param>
        /// <param name='reviewId'>
        /// Id of the review.
        /// </param>
        /// <param name='startSeed'>
        /// Time stamp of the frame from where you want to start fetching the
        /// frames.
        /// </param>
        /// <param name='noOfRecords'>
        /// Number of frames to fetch.
        /// </param>
        /// <param name='filter'>
        /// Get frames filtered by tags.
        /// </param>
        /// <param name='customHeaders'>
        /// The headers that will be added to request.
        /// </param>
        /// <param name='cancellationToken'>
        /// The cancellation token.
        /// </param>
        /// <exception cref="APIErrorException">
        /// Thrown when the operation returned an invalid status code
        /// </exception>
        /// <exception cref="Microsoft.Rest.SerializationException">
        /// Thrown when unable to deserialize the response
        /// </exception>
        /// <exception cref="Microsoft.Rest.ValidationException">
        /// Thrown when a required parameter is null
        /// </exception>
        Task<HttpOperationResponse<Frames>> GetVideoFramesWithHttpMessagesAsync(string teamName, string reviewId, int? startSeed = default(int?), int? noOfRecords = default(int?), string filter = default(string), Dictionary<string, List<string>> customHeaders = null, CancellationToken cancellationToken = default(CancellationToken));
        /// <summary>
        /// Publish video review to make it available for review.
        /// </summary>
        /// <param name='teamName'>
        /// Your team name.
        /// </param>
        /// <param name='reviewId'>
        /// Id of the review.
        /// </param>
        /// <param name='customHeaders'>
        /// The headers that will be added to request.
        /// </param>
        /// <param name='cancellationToken'>
        /// The cancellation token.
        /// </param>
        /// <exception cref="APIErrorException">
        /// Thrown when the operation returned an invalid status code
        /// </exception>
        /// <exception cref="Microsoft.Rest.ValidationException">
        /// Thrown when a required parameter is null
        /// </exception>
        Task<HttpOperationResponse> PublishVideoReviewWithHttpMessagesAsync(string teamName, string reviewId, Dictionary<string, List<string>> customHeaders = null, CancellationToken cancellationToken = default(CancellationToken));
        /// <summary>
        /// This API adds a transcript screen text result file for a video
        /// review. Transcript screen text result file is a result of Screen
        /// Text API . In order to generate transcript screen text result file
        /// , a transcript file has to be screened for profanity using Screen
        /// Text API.
        /// </summary>
        /// <param name='contentType'>
        /// The content type.
        /// </param>
        /// <param name='teamName'>
        /// Your team name.
        /// </param>
        /// <param name='reviewId'>
        /// Id of the review.
        /// </param>
        /// <param name='transcriptModerationBody'>
        /// Body for add video transcript moderation result API
        /// </param>
        /// <param name='customHeaders'>
        /// The headers that will be added to request.
        /// </param>
        /// <param name='cancellationToken'>
        /// The cancellation token.
        /// </param>
        /// <exception cref="APIErrorException">
        /// Thrown when the operation returned an invalid status code
        /// </exception>
        /// <exception cref="Microsoft.Rest.ValidationException">
        /// Thrown when a required parameter is null
        /// </exception>
        Task<HttpOperationResponse> AddVideoTranscriptModerationResultWithHttpMessagesAsync(string contentType, string teamName, string reviewId, IList<TranscriptModerationBodyItem> transcriptModerationBody, Dictionary<string, List<string>> customHeaders = null, CancellationToken cancellationToken = default(CancellationToken));
        /// <summary>
        /// This API adds a transcript file (text version of all the words
        /// spoken in a video) to a video review. The file should be a valid
        /// WebVTT format.
        /// </summary>
        /// <param name='teamName'>
        /// Your team name.
        /// </param>
        /// <param name='reviewId'>
        /// Id of the review.
        /// </param>
        /// <param name='vTTfile'>
        /// Transcript file of the video.
        /// </param>
        /// <param name='customHeaders'>
        /// The headers that will be added to request.
        /// </param>
        /// <param name='cancellationToken'>
        /// The cancellation token.
        /// </param>
        /// <exception cref="APIErrorException">
        /// Thrown when the operation returned an invalid status code
        /// </exception>
        /// <exception cref="Microsoft.Rest.ValidationException">
        /// Thrown when a required parameter is null
        /// </exception>
        Task<HttpOperationResponse> AddVideoTranscriptWithHttpMessagesAsync(string teamName, string reviewId, Stream vTTfile, Dictionary<string, List<string>> customHeaders = null, CancellationToken cancellationToken = default(CancellationToken));
        /// <summary>
        /// The reviews created would show up for Reviewers on your team. As
        /// Reviewers complete reviewing, results of the Review would be POSTED
        /// (i.e. HTTP POST) on the specified CallBackEndpoint.
        ///
        /// &lt;h3&gt;CallBack Schemas &lt;/h3&gt;
        /// &lt;h4&gt;Review Completion CallBack Sample&lt;/h4&gt;
        /// &lt;p&gt;
        /// {&lt;br/&gt;
        /// "ReviewId": "&lt;Review Id&gt;",&lt;br/&gt;
        /// "ModifiedOn": "2016-10-11T22:36:32.9934851Z",&lt;br/&gt;
        /// "ModifiedBy": "&lt;Name of the Reviewer&gt;",&lt;br/&gt;
        /// "CallBackType": "Review",&lt;br/&gt;
        /// "ContentId": "&lt;The ContentId that was specified
        /// input&gt;",&lt;br/&gt;
        /// "Metadata": {&lt;br/&gt;
        /// "adultscore": "0.xxx",&lt;br/&gt;
        /// "a": "False",&lt;br/&gt;
        /// "racyscore": "0.xxx",&lt;br/&gt;
        /// "r": "True"&lt;br/&gt;
        /// },&lt;br/&gt;
        /// "ReviewerResultTags": {&lt;br/&gt;
        /// "a": "False",&lt;br/&gt;
        /// "r": "True"&lt;br/&gt;
        /// }&lt;br/&gt;
        /// }&lt;br/&gt;
        ///
        /// &lt;/p&gt;.
        /// </summary>
        /// <param name='contentType'>
        /// The content type.
        /// </param>
        /// <param name='teamName'>
        /// Your team name.
        /// </param>
        /// <param name='createVideoReviewsBody'>
        /// Body for create reviews API
        /// </param>
        /// <param name='subTeam'>
        /// SubTeam of your team, you want to assign the created review to.
        /// </param>
        /// <param name='customHeaders'>
        /// The headers that will be added to request.
        /// </param>
        /// <param name='cancellationToken'>
        /// The cancellation token.
        /// </param>
        /// <exception cref="APIErrorException">
        /// Thrown when the operation returned an invalid status code
        /// </exception>
        /// <exception cref="Microsoft.Rest.SerializationException">
        /// Thrown when unable to deserialize the response
        /// </exception>
        /// <exception cref="Microsoft.Rest.ValidationException">
        /// Thrown when a required parameter is null
        /// </exception>
        Task<HttpOperationResponse<IList<string>>> CreateVideoReviewsWithHttpMessagesAsync(string contentType, string teamName, IList<CreateVideoReviewsBodyItem> createVideoReviewsBody, string subTeam = default(string), Dictionary<string, List<string>> customHeaders = null, CancellationToken cancellationToken = default(CancellationToken));
        /// <summary>
        /// Use this method to add frames for a video review.Timescale: This
        /// parameter is a factor which is used to convert the timestamp on a
        /// frame into milliseconds. Timescale is provided in the output of the
        /// Content Moderator video media processor on the Azure Media Services
        /// platform.Timescale in the Video Moderation output is Ticks/Second.
        /// </summary>
        /// <param name='contentType'>
        /// The content type.
        /// </param>
        /// <param name='teamName'>
        /// Your team name.
        /// </param>
        /// <param name='reviewId'>
        /// Id of the review.
        /// </param>
        /// <param name='videoFrameBody'>
        /// Body for add video frames API
        /// </param>
        /// <param name='timescale'>
        /// Timescale of the video.
        /// </param>
        /// <param name='customHeaders'>
        /// The headers that will be added to request.
        /// </param>
        /// <param name='cancellationToken'>
        /// The cancellation token.
        /// </param>
        /// <exception cref="APIErrorException">
        /// Thrown when the operation returned an invalid status code
        /// </exception>
        /// <exception cref="Microsoft.Rest.ValidationException">
        /// Thrown when a required parameter is null
        /// </exception>
        Task<HttpOperationResponse> AddVideoFrameUrlWithHttpMessagesAsync(string contentType, string teamName, string reviewId, IList<VideoFrameBodyItem> videoFrameBody, int? timescale = default(int?), Dictionary<string, List<string>> customHeaders = null, CancellationToken cancellationToken = default(CancellationToken));
        /// <summary>
        /// Use this method to add frames for a video review.Timescale: This
        /// parameter is a factor which is used to convert the timestamp on a
        /// frame into milliseconds. Timescale is provided in the output of the
        /// Content Moderator video media processor on the Azure Media Services
        /// platform.Timescale in the Video Moderation output is Ticks/Second.
        /// </summary>
        /// <param name='contentType'>
        /// The content type.
        /// </param>
        /// <param name='teamName'>
        /// Your team name.
        /// </param>
        /// <param name='reviewId'>
        /// Id of the review.
        /// </param>
        /// <param name='frameImageZip'>
        /// Zip file containing frame images.
        /// </param>
        /// <param name='frameMetadata'>
        /// Metadata of the frame.
        /// </param>
        /// <param name='timescale'>
        /// Timescale of the video .
        /// </param>
        /// <param name='customHeaders'>
        /// The headers that will be added to request.
        /// </param>
        /// <param name='cancellationToken'>
        /// The cancellation token.
        /// </param>
        /// <exception cref="APIErrorException">
        /// Thrown when the operation returned an invalid status code
        /// </exception>
        /// <exception cref="Microsoft.Rest.ValidationException">
        /// Thrown when a required parameter is null
        /// </exception>
        Task<HttpOperationResponse> AddVideoFrameStreamWithHttpMessagesAsync(string contentType, string teamName, string reviewId, Stream frameImageZip, string frameMetadata, int? timescale = default(int?), Dictionary<string, List<string>> customHeaders = null, CancellationToken cancellationToken = default(CancellationToken));
    }
}
