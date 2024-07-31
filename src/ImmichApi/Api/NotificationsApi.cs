/*
 * Immich
 *
 * Immich API
 *
 * The version of the OpenAPI document: 1.110.0
 * Generated by: https://github.com/openapitools/openapi-generator.git
 */


using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Net;
using System.Net.Mime;
using ImmichApi.Client;
using ImmichApi.Model;

namespace ImmichApi.Api
{

    /// <summary>
    /// Represents a collection of functions to interact with the API endpoints
    /// </summary>
    public interface INotificationsApiSync : IApiAccessor
    {
        #region Synchronous Operations
        /// <summary>
        /// 
        /// </summary>
        /// <exception cref="ImmichApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="systemConfigSmtpDto"></param>
        /// <param name="operationIndex">Index associated with the operation.</param>
        /// <returns></returns>
        void SendTestEmail(SystemConfigSmtpDto systemConfigSmtpDto, int operationIndex = 0);

        /// <summary>
        /// 
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="ImmichApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="systemConfigSmtpDto"></param>
        /// <param name="operationIndex">Index associated with the operation.</param>
        /// <returns>ApiResponse of Object(void)</returns>
        ApiResponse<Object> SendTestEmailWithHttpInfo(SystemConfigSmtpDto systemConfigSmtpDto, int operationIndex = 0);
        #endregion Synchronous Operations
    }

    /// <summary>
    /// Represents a collection of functions to interact with the API endpoints
    /// </summary>
    public interface INotificationsApiAsync : IApiAccessor
    {
        #region Asynchronous Operations
        /// <summary>
        /// 
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="ImmichApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="systemConfigSmtpDto"></param>
        /// <param name="operationIndex">Index associated with the operation.</param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <returns>Task of void</returns>
        System.Threading.Tasks.Task SendTestEmailAsync(SystemConfigSmtpDto systemConfigSmtpDto, int operationIndex = 0, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken));

        /// <summary>
        /// 
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="ImmichApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="systemConfigSmtpDto"></param>
        /// <param name="operationIndex">Index associated with the operation.</param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <returns>Task of ApiResponse</returns>
        System.Threading.Tasks.Task<ApiResponse<Object>> SendTestEmailWithHttpInfoAsync(SystemConfigSmtpDto systemConfigSmtpDto, int operationIndex = 0, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken));
        #endregion Asynchronous Operations
    }

    /// <summary>
    /// Represents a collection of functions to interact with the API endpoints
    /// </summary>
    public interface INotificationsApi : INotificationsApiSync, INotificationsApiAsync
    {

    }

    /// <summary>
    /// Represents a collection of functions to interact with the API endpoints
    /// </summary>
    public partial class NotificationsApi : INotificationsApi
    {
        private ImmichApi.Client.ExceptionFactory _exceptionFactory = (name, response) => null;

        /// <summary>
        /// Initializes a new instance of the <see cref="NotificationsApi"/> class.
        /// </summary>
        /// <returns></returns>
        public NotificationsApi() : this((string)null)
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="NotificationsApi"/> class.
        /// </summary>
        /// <returns></returns>
        public NotificationsApi(string basePath)
        {
            this.Configuration = ImmichApi.Client.Configuration.MergeConfigurations(
                ImmichApi.Client.GlobalConfiguration.Instance,
                new ImmichApi.Client.Configuration { BasePath = basePath }
            );
            this.Client = new ImmichApi.Client.ApiClient(this.Configuration.BasePath);
            this.AsynchronousClient = new ImmichApi.Client.ApiClient(this.Configuration.BasePath);
            this.ExceptionFactory = ImmichApi.Client.Configuration.DefaultExceptionFactory;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="NotificationsApi"/> class
        /// using Configuration object
        /// </summary>
        /// <param name="configuration">An instance of Configuration</param>
        /// <returns></returns>
        public NotificationsApi(ImmichApi.Client.Configuration configuration)
        {
            if (configuration == null) throw new ArgumentNullException("configuration");

            this.Configuration = ImmichApi.Client.Configuration.MergeConfigurations(
                ImmichApi.Client.GlobalConfiguration.Instance,
                configuration
            );
            this.Client = new ImmichApi.Client.ApiClient(this.Configuration.BasePath);
            this.AsynchronousClient = new ImmichApi.Client.ApiClient(this.Configuration.BasePath);
            ExceptionFactory = ImmichApi.Client.Configuration.DefaultExceptionFactory;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="NotificationsApi"/> class
        /// using a Configuration object and client instance.
        /// </summary>
        /// <param name="client">The client interface for synchronous API access.</param>
        /// <param name="asyncClient">The client interface for asynchronous API access.</param>
        /// <param name="configuration">The configuration object.</param>
        public NotificationsApi(ImmichApi.Client.ISynchronousClient client, ImmichApi.Client.IAsynchronousClient asyncClient, ImmichApi.Client.IReadableConfiguration configuration)
        {
            if (client == null) throw new ArgumentNullException("client");
            if (asyncClient == null) throw new ArgumentNullException("asyncClient");
            if (configuration == null) throw new ArgumentNullException("configuration");

            this.Client = client;
            this.AsynchronousClient = asyncClient;
            this.Configuration = configuration;
            this.ExceptionFactory = ImmichApi.Client.Configuration.DefaultExceptionFactory;
        }

        /// <summary>
        /// The client for accessing this underlying API asynchronously.
        /// </summary>
        public ImmichApi.Client.IAsynchronousClient AsynchronousClient { get; set; }

        /// <summary>
        /// The client for accessing this underlying API synchronously.
        /// </summary>
        public ImmichApi.Client.ISynchronousClient Client { get; set; }

        /// <summary>
        /// Gets the base path of the API client.
        /// </summary>
        /// <value>The base path</value>
        public string GetBasePath()
        {
            return this.Configuration.BasePath;
        }

        /// <summary>
        /// Gets or sets the configuration object
        /// </summary>
        /// <value>An instance of the Configuration</value>
        public ImmichApi.Client.IReadableConfiguration Configuration { get; set; }

        /// <summary>
        /// Provides a factory method hook for the creation of exceptions.
        /// </summary>
        public ImmichApi.Client.ExceptionFactory ExceptionFactory
        {
            get
            {
                if (_exceptionFactory != null && _exceptionFactory.GetInvocationList().Length > 1)
                {
                    throw new InvalidOperationException("Multicast delegate for ExceptionFactory is unsupported.");
                }
                return _exceptionFactory;
            }
            set { _exceptionFactory = value; }
        }

        /// <summary>
        ///  
        /// </summary>
        /// <exception cref="ImmichApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="systemConfigSmtpDto"></param>
        /// <param name="operationIndex">Index associated with the operation.</param>
        /// <returns></returns>
        public void SendTestEmail(SystemConfigSmtpDto systemConfigSmtpDto, int operationIndex = 0)
        {
            SendTestEmailWithHttpInfo(systemConfigSmtpDto);
        }

        /// <summary>
        ///  
        /// </summary>
        /// <exception cref="ImmichApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="systemConfigSmtpDto"></param>
        /// <param name="operationIndex">Index associated with the operation.</param>
        /// <returns>ApiResponse of Object(void)</returns>
        public ImmichApi.Client.ApiResponse<Object> SendTestEmailWithHttpInfo(SystemConfigSmtpDto systemConfigSmtpDto, int operationIndex = 0)
        {
            // verify the required parameter 'systemConfigSmtpDto' is set
            if (systemConfigSmtpDto == null)
            {
                throw new ImmichApi.Client.ApiException(400, "Missing required parameter 'systemConfigSmtpDto' when calling NotificationsApi->SendTestEmail");
            }

            ImmichApi.Client.RequestOptions localVarRequestOptions = new ImmichApi.Client.RequestOptions();

            string[] _contentTypes = new string[] {
                "application/json"
            };

            // to determine the Accept header
            string[] _accepts = new string[] {
            };

            var localVarContentType = ImmichApi.Client.ClientUtils.SelectHeaderContentType(_contentTypes);
            if (localVarContentType != null)
            {
                localVarRequestOptions.HeaderParameters.Add("Content-Type", localVarContentType);
            }

            var localVarAccept = ImmichApi.Client.ClientUtils.SelectHeaderAccept(_accepts);
            if (localVarAccept != null)
            {
                localVarRequestOptions.HeaderParameters.Add("Accept", localVarAccept);
            }

            localVarRequestOptions.Data = systemConfigSmtpDto;

            localVarRequestOptions.Operation = "NotificationsApi.SendTestEmail";
            localVarRequestOptions.OperationIndex = operationIndex;

            // authentication (cookie) required
            // cookie parameter support
            if (!string.IsNullOrEmpty(this.Configuration.GetApiKeyWithPrefix("immich_access_token")))
            {
                localVarRequestOptions.Cookies.Add(new Cookie("immich_access_token", this.Configuration.GetApiKeyWithPrefix("immich_access_token")));
            }
            // authentication (api_key) required
            if (!string.IsNullOrEmpty(this.Configuration.GetApiKeyWithPrefix("x-api-key")))
            {
                localVarRequestOptions.HeaderParameters.Add("x-api-key", this.Configuration.GetApiKeyWithPrefix("x-api-key"));
            }
            // authentication (bearer) required
            // bearer authentication required
            if (!string.IsNullOrEmpty(this.Configuration.AccessToken) && !localVarRequestOptions.HeaderParameters.ContainsKey("Authorization"))
            {
                localVarRequestOptions.HeaderParameters.Add("Authorization", "Bearer " + this.Configuration.AccessToken);
            }

            // make the HTTP request
            var localVarResponse = this.Client.Post<Object>("/notifications/test-email", localVarRequestOptions, this.Configuration);
            if (this.ExceptionFactory != null)
            {
                Exception _exception = this.ExceptionFactory("SendTestEmail", localVarResponse);
                if (_exception != null)
                {
                    throw _exception;
                }
            }

            return localVarResponse;
        }

        /// <summary>
        ///  
        /// </summary>
        /// <exception cref="ImmichApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="systemConfigSmtpDto"></param>
        /// <param name="operationIndex">Index associated with the operation.</param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <returns>Task of void</returns>
        public async System.Threading.Tasks.Task SendTestEmailAsync(SystemConfigSmtpDto systemConfigSmtpDto, int operationIndex = 0, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken))
        {
            await SendTestEmailWithHttpInfoAsync(systemConfigSmtpDto, operationIndex, cancellationToken).ConfigureAwait(false);
        }

        /// <summary>
        ///  
        /// </summary>
        /// <exception cref="ImmichApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="systemConfigSmtpDto"></param>
        /// <param name="operationIndex">Index associated with the operation.</param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <returns>Task of ApiResponse</returns>
        public async System.Threading.Tasks.Task<ImmichApi.Client.ApiResponse<Object>> SendTestEmailWithHttpInfoAsync(SystemConfigSmtpDto systemConfigSmtpDto, int operationIndex = 0, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken))
        {
            // verify the required parameter 'systemConfigSmtpDto' is set
            if (systemConfigSmtpDto == null)
            {
                throw new ImmichApi.Client.ApiException(400, "Missing required parameter 'systemConfigSmtpDto' when calling NotificationsApi->SendTestEmail");
            }


            ImmichApi.Client.RequestOptions localVarRequestOptions = new ImmichApi.Client.RequestOptions();

            string[] _contentTypes = new string[] {
                "application/json"
            };

            // to determine the Accept header
            string[] _accepts = new string[] {
            };

            var localVarContentType = ImmichApi.Client.ClientUtils.SelectHeaderContentType(_contentTypes);
            if (localVarContentType != null)
            {
                localVarRequestOptions.HeaderParameters.Add("Content-Type", localVarContentType);
            }

            var localVarAccept = ImmichApi.Client.ClientUtils.SelectHeaderAccept(_accepts);
            if (localVarAccept != null)
            {
                localVarRequestOptions.HeaderParameters.Add("Accept", localVarAccept);
            }

            localVarRequestOptions.Data = systemConfigSmtpDto;

            localVarRequestOptions.Operation = "NotificationsApi.SendTestEmail";
            localVarRequestOptions.OperationIndex = operationIndex;

            // authentication (cookie) required
            // cookie parameter support
            if (!string.IsNullOrEmpty(this.Configuration.GetApiKeyWithPrefix("immich_access_token")))
            {
                localVarRequestOptions.Cookies.Add(new Cookie("immich_access_token", this.Configuration.GetApiKeyWithPrefix("immich_access_token")));
            }
            // authentication (api_key) required
            if (!string.IsNullOrEmpty(this.Configuration.GetApiKeyWithPrefix("x-api-key")))
            {
                localVarRequestOptions.HeaderParameters.Add("x-api-key", this.Configuration.GetApiKeyWithPrefix("x-api-key"));
            }
            // authentication (bearer) required
            // bearer authentication required
            if (!string.IsNullOrEmpty(this.Configuration.AccessToken) && !localVarRequestOptions.HeaderParameters.ContainsKey("Authorization"))
            {
                localVarRequestOptions.HeaderParameters.Add("Authorization", "Bearer " + this.Configuration.AccessToken);
            }

            // make the HTTP request
            var localVarResponse = await this.AsynchronousClient.PostAsync<Object>("/notifications/test-email", localVarRequestOptions, this.Configuration, cancellationToken).ConfigureAwait(false);

            if (this.ExceptionFactory != null)
            {
                Exception _exception = this.ExceptionFactory("SendTestEmail", localVarResponse);
                if (_exception != null)
                {
                    throw _exception;
                }
            }

            return localVarResponse;
        }

    }
}
