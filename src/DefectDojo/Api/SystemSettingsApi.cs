/* 
 * Defect Dojo API
 *
 * To use the API you need be authorized.
 *
 * OpenAPI spec version: v2
 * 
 * Generated by: https://github.com/swagger-api/swagger-codegen.git
 */

using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using RestSharp.Portable;
using DefectDojo.Client;
using DefectDojo.Model;

namespace DefectDojo.Api
{
    /// <summary>
    /// Represents a collection of functions to interact with the API endpoints
    /// </summary>
    public interface ISystemSettingsApi : IApiAccessor
    {
        #region Synchronous Operations
        /// <summary>
        /// 
        /// </summary>
        /// <remarks>
        /// Basic control over System Settings. Use &#39;id&#39; 1 for PUT, PATCH operations
        /// </remarks>
        /// <exception cref="DefectDojo.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="limit">Number of results to return per page. (optional)</param>
        /// <param name="offset">The initial index from which to return the results. (optional)</param>
        /// <returns>InlineResponse20022</returns>
        InlineResponse20022 SystemSettingsList (int? limit = null, int? offset = null);

        /// <summary>
        /// 
        /// </summary>
        /// <remarks>
        /// Basic control over System Settings. Use &#39;id&#39; 1 for PUT, PATCH operations
        /// </remarks>
        /// <exception cref="DefectDojo.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="limit">Number of results to return per page. (optional)</param>
        /// <param name="offset">The initial index from which to return the results. (optional)</param>
        /// <returns>ApiResponse of InlineResponse20022</returns>
        ApiResponse<InlineResponse20022> SystemSettingsListWithHttpInfo (int? limit = null, int? offset = null);
        /// <summary>
        /// 
        /// </summary>
        /// <remarks>
        /// Basic control over System Settings. Use &#39;id&#39; 1 for PUT, PATCH operations
        /// </remarks>
        /// <exception cref="DefectDojo.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">A unique integer value identifying this system_ settings.</param>
        /// <param name="data"></param>
        /// <returns>SystemSettings</returns>
        SystemSettings SystemSettingsPartialUpdate (int? id, SystemSettings data);

        /// <summary>
        /// 
        /// </summary>
        /// <remarks>
        /// Basic control over System Settings. Use &#39;id&#39; 1 for PUT, PATCH operations
        /// </remarks>
        /// <exception cref="DefectDojo.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">A unique integer value identifying this system_ settings.</param>
        /// <param name="data"></param>
        /// <returns>ApiResponse of SystemSettings</returns>
        ApiResponse<SystemSettings> SystemSettingsPartialUpdateWithHttpInfo (int? id, SystemSettings data);
        /// <summary>
        /// 
        /// </summary>
        /// <remarks>
        /// Basic control over System Settings. Use &#39;id&#39; 1 for PUT, PATCH operations
        /// </remarks>
        /// <exception cref="DefectDojo.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">A unique integer value identifying this system_ settings.</param>
        /// <param name="data"></param>
        /// <returns>SystemSettings</returns>
        SystemSettings SystemSettingsUpdate (int? id, SystemSettings data);

        /// <summary>
        /// 
        /// </summary>
        /// <remarks>
        /// Basic control over System Settings. Use &#39;id&#39; 1 for PUT, PATCH operations
        /// </remarks>
        /// <exception cref="DefectDojo.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">A unique integer value identifying this system_ settings.</param>
        /// <param name="data"></param>
        /// <returns>ApiResponse of SystemSettings</returns>
        ApiResponse<SystemSettings> SystemSettingsUpdateWithHttpInfo (int? id, SystemSettings data);
        #endregion Synchronous Operations
        #region Asynchronous Operations
        /// <summary>
        /// 
        /// </summary>
        /// <remarks>
        /// Basic control over System Settings. Use &#39;id&#39; 1 for PUT, PATCH operations
        /// </remarks>
        /// <exception cref="DefectDojo.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="limit">Number of results to return per page. (optional)</param>
        /// <param name="offset">The initial index from which to return the results. (optional)</param>
        /// <returns>Task of InlineResponse20022</returns>
        System.Threading.Tasks.Task<InlineResponse20022> SystemSettingsListAsync (int? limit = null, int? offset = null);

        /// <summary>
        /// 
        /// </summary>
        /// <remarks>
        /// Basic control over System Settings. Use &#39;id&#39; 1 for PUT, PATCH operations
        /// </remarks>
        /// <exception cref="DefectDojo.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="limit">Number of results to return per page. (optional)</param>
        /// <param name="offset">The initial index from which to return the results. (optional)</param>
        /// <returns>Task of ApiResponse (InlineResponse20022)</returns>
        System.Threading.Tasks.Task<ApiResponse<InlineResponse20022>> SystemSettingsListAsyncWithHttpInfo (int? limit = null, int? offset = null);
        /// <summary>
        /// 
        /// </summary>
        /// <remarks>
        /// Basic control over System Settings. Use &#39;id&#39; 1 for PUT, PATCH operations
        /// </remarks>
        /// <exception cref="DefectDojo.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">A unique integer value identifying this system_ settings.</param>
        /// <param name="data"></param>
        /// <returns>Task of SystemSettings</returns>
        System.Threading.Tasks.Task<SystemSettings> SystemSettingsPartialUpdateAsync (int? id, SystemSettings data);

        /// <summary>
        /// 
        /// </summary>
        /// <remarks>
        /// Basic control over System Settings. Use &#39;id&#39; 1 for PUT, PATCH operations
        /// </remarks>
        /// <exception cref="DefectDojo.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">A unique integer value identifying this system_ settings.</param>
        /// <param name="data"></param>
        /// <returns>Task of ApiResponse (SystemSettings)</returns>
        System.Threading.Tasks.Task<ApiResponse<SystemSettings>> SystemSettingsPartialUpdateAsyncWithHttpInfo (int? id, SystemSettings data);
        /// <summary>
        /// 
        /// </summary>
        /// <remarks>
        /// Basic control over System Settings. Use &#39;id&#39; 1 for PUT, PATCH operations
        /// </remarks>
        /// <exception cref="DefectDojo.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">A unique integer value identifying this system_ settings.</param>
        /// <param name="data"></param>
        /// <returns>Task of SystemSettings</returns>
        System.Threading.Tasks.Task<SystemSettings> SystemSettingsUpdateAsync (int? id, SystemSettings data);

        /// <summary>
        /// 
        /// </summary>
        /// <remarks>
        /// Basic control over System Settings. Use &#39;id&#39; 1 for PUT, PATCH operations
        /// </remarks>
        /// <exception cref="DefectDojo.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">A unique integer value identifying this system_ settings.</param>
        /// <param name="data"></param>
        /// <returns>Task of ApiResponse (SystemSettings)</returns>
        System.Threading.Tasks.Task<ApiResponse<SystemSettings>> SystemSettingsUpdateAsyncWithHttpInfo (int? id, SystemSettings data);
        #endregion Asynchronous Operations
    }

    /// <summary>
    /// Represents a collection of functions to interact with the API endpoints
    /// </summary>
    public partial class SystemSettingsApi : ISystemSettingsApi
    {
        private DefectDojo.Client.ExceptionFactory _exceptionFactory = (name, response) => null;

        /// <summary>
        /// Initializes a new instance of the <see cref="SystemSettingsApi"/> class.
        /// </summary>
        /// <returns></returns>
        public SystemSettingsApi(String basePath)
        {
            this.Configuration = new DefectDojo.Client.Configuration { BasePath = basePath };

            ExceptionFactory = DefectDojo.Client.Configuration.DefaultExceptionFactory;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="SystemSettingsApi"/> class
        /// using Configuration object
        /// </summary>
        /// <param name="configuration">An instance of Configuration</param>
        /// <returns></returns>
        public SystemSettingsApi(DefectDojo.Client.Configuration configuration = null)
        {
            if (configuration == null) // use the default one in Configuration
                this.Configuration = DefectDojo.Client.Configuration.Default;
            else
                this.Configuration = configuration;

            ExceptionFactory = DefectDojo.Client.Configuration.DefaultExceptionFactory;
        }

        /// <summary>
        /// Gets the base path of the API client.
        /// </summary>
        /// <value>The base path</value>
        public String GetBasePath()
        {
            return this.Configuration.ApiClient.RestClient.BaseUrl.ToString();
        }

        /// <summary>
        /// Sets the base path of the API client.
        /// </summary>
        /// <value>The base path</value>
        [Obsolete("SetBasePath is deprecated, please do 'Configuration.ApiClient = new ApiClient(\"http://new-path\")' instead.")]
        public void SetBasePath(String basePath)
        {
            // do nothing
        }

        /// <summary>
        /// Gets or sets the configuration object
        /// </summary>
        /// <value>An instance of the Configuration</value>
        public DefectDojo.Client.Configuration Configuration {get; set;}

        /// <summary>
        /// Provides a factory method hook for the creation of exceptions.
        /// </summary>
        public DefectDojo.Client.ExceptionFactory ExceptionFactory
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
        /// Gets the default header.
        /// </summary>
        /// <returns>Dictionary of HTTP header</returns>
        [Obsolete("DefaultHeader is deprecated, please use Configuration.DefaultHeader instead.")]
        public IDictionary<String, String> DefaultHeader()
        {
            return new ReadOnlyDictionary<string, string>(this.Configuration.DefaultHeader);
        }

        /// <summary>
        /// Add default header.
        /// </summary>
        /// <param name="key">Header field name.</param>
        /// <param name="value">Header field value.</param>
        /// <returns></returns>
        [Obsolete("AddDefaultHeader is deprecated, please use Configuration.AddDefaultHeader instead.")]
        public void AddDefaultHeader(string key, string value)
        {
            this.Configuration.AddDefaultHeader(key, value);
        }

        /// <summary>
        ///  Basic control over System Settings. Use &#39;id&#39; 1 for PUT, PATCH operations
        /// </summary>
        /// <exception cref="DefectDojo.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="limit">Number of results to return per page. (optional)</param>
        /// <param name="offset">The initial index from which to return the results. (optional)</param>
        /// <returns>InlineResponse20022</returns>
        public InlineResponse20022 SystemSettingsList (int? limit = null, int? offset = null)
        {
             ApiResponse<InlineResponse20022> localVarResponse = SystemSettingsListWithHttpInfo(limit, offset);
             return localVarResponse.Data;
        }

        /// <summary>
        ///  Basic control over System Settings. Use &#39;id&#39; 1 for PUT, PATCH operations
        /// </summary>
        /// <exception cref="DefectDojo.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="limit">Number of results to return per page. (optional)</param>
        /// <param name="offset">The initial index from which to return the results. (optional)</param>
        /// <returns>ApiResponse of InlineResponse20022</returns>
        public ApiResponse< InlineResponse20022 > SystemSettingsListWithHttpInfo (int? limit = null, int? offset = null)
        {

            var localVarPath = "./system_settings/";
            var localVarPathParams = new Dictionary<String, String>();
            var localVarQueryParams = new List<KeyValuePair<String, String>>();
            var localVarHeaderParams = new Dictionary<String, String>(this.Configuration.DefaultHeader);
            var localVarFormParams = new Dictionary<String, String>();
            var localVarFileParams = new Dictionary<String, FileParameter>();
            Object localVarPostBody = null;

            // to determine the Content-Type header
            String[] localVarHttpContentTypes = new String[] {
                "application/json"
            };
            String localVarHttpContentType = this.Configuration.ApiClient.SelectHeaderContentType(localVarHttpContentTypes);

            // to determine the Accept header
            String[] localVarHttpHeaderAccepts = new String[] {
                "application/json"
            };
            String localVarHttpHeaderAccept = this.Configuration.ApiClient.SelectHeaderAccept(localVarHttpHeaderAccepts);
            if (localVarHttpHeaderAccept != null)
                localVarHeaderParams.Add("Accept", localVarHttpHeaderAccept);

            if (limit != null) localVarQueryParams.AddRange(this.Configuration.ApiClient.ParameterToKeyValuePairs("", "limit", limit)); // query parameter
            if (offset != null) localVarQueryParams.AddRange(this.Configuration.ApiClient.ParameterToKeyValuePairs("", "offset", offset)); // query parameter

            // authentication (api_key) required
            if (!String.IsNullOrEmpty(this.Configuration.GetApiKeyWithPrefix("Authorization")))
            {
                localVarHeaderParams["Authorization"] = this.Configuration.GetApiKeyWithPrefix("Authorization");
            }

            // make the HTTP request
            IRestResponse localVarResponse = (IRestResponse) this.Configuration.ApiClient.CallApi(localVarPath,
                Method.GET, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams,
                localVarPathParams, localVarHttpContentType);

            int localVarStatusCode = (int) localVarResponse.StatusCode;

            if (ExceptionFactory != null)
            {
                Exception exception = ExceptionFactory("SystemSettingsList", localVarResponse);
                if (exception != null) throw exception;
            }

            return new ApiResponse<InlineResponse20022>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Key, x => x.Value.ToString()),
                (InlineResponse20022) this.Configuration.ApiClient.Deserialize(localVarResponse, typeof(InlineResponse20022)));
        }

        /// <summary>
        ///  Basic control over System Settings. Use &#39;id&#39; 1 for PUT, PATCH operations
        /// </summary>
        /// <exception cref="DefectDojo.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="limit">Number of results to return per page. (optional)</param>
        /// <param name="offset">The initial index from which to return the results. (optional)</param>
        /// <returns>Task of InlineResponse20022</returns>
        public async System.Threading.Tasks.Task<InlineResponse20022> SystemSettingsListAsync (int? limit = null, int? offset = null)
        {
             ApiResponse<InlineResponse20022> localVarResponse = await SystemSettingsListAsyncWithHttpInfo(limit, offset);
             return localVarResponse.Data;

        }

        /// <summary>
        ///  Basic control over System Settings. Use &#39;id&#39; 1 for PUT, PATCH operations
        /// </summary>
        /// <exception cref="DefectDojo.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="limit">Number of results to return per page. (optional)</param>
        /// <param name="offset">The initial index from which to return the results. (optional)</param>
        /// <returns>Task of ApiResponse (InlineResponse20022)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<InlineResponse20022>> SystemSettingsListAsyncWithHttpInfo (int? limit = null, int? offset = null)
        {

            var localVarPath = "./system_settings/";
            var localVarPathParams = new Dictionary<String, String>();
            var localVarQueryParams = new List<KeyValuePair<String, String>>();
            var localVarHeaderParams = new Dictionary<String, String>(this.Configuration.DefaultHeader);
            var localVarFormParams = new Dictionary<String, String>();
            var localVarFileParams = new Dictionary<String, FileParameter>();
            Object localVarPostBody = null;

            // to determine the Content-Type header
            String[] localVarHttpContentTypes = new String[] {
                "application/json"
            };
            String localVarHttpContentType = this.Configuration.ApiClient.SelectHeaderContentType(localVarHttpContentTypes);

            // to determine the Accept header
            String[] localVarHttpHeaderAccepts = new String[] {
                "application/json"
            };
            String localVarHttpHeaderAccept = this.Configuration.ApiClient.SelectHeaderAccept(localVarHttpHeaderAccepts);
            if (localVarHttpHeaderAccept != null)
                localVarHeaderParams.Add("Accept", localVarHttpHeaderAccept);

            if (limit != null) localVarQueryParams.AddRange(this.Configuration.ApiClient.ParameterToKeyValuePairs("", "limit", limit)); // query parameter
            if (offset != null) localVarQueryParams.AddRange(this.Configuration.ApiClient.ParameterToKeyValuePairs("", "offset", offset)); // query parameter

            // authentication (api_key) required
            if (!String.IsNullOrEmpty(this.Configuration.GetApiKeyWithPrefix("Authorization")))
            {
                localVarHeaderParams["Authorization"] = this.Configuration.GetApiKeyWithPrefix("Authorization");
            }

            // make the HTTP request
            IRestResponse localVarResponse = (IRestResponse) await this.Configuration.ApiClient.CallApiAsync(localVarPath,
                Method.GET, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams,
                localVarPathParams, localVarHttpContentType);

            int localVarStatusCode = (int) localVarResponse.StatusCode;

            if (ExceptionFactory != null)
            {
                Exception exception = ExceptionFactory("SystemSettingsList", localVarResponse);
                if (exception != null) throw exception;
            }

            return new ApiResponse<InlineResponse20022>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Key, x => x.Value.ToString()),
                (InlineResponse20022) this.Configuration.ApiClient.Deserialize(localVarResponse, typeof(InlineResponse20022)));
        }

        /// <summary>
        ///  Basic control over System Settings. Use &#39;id&#39; 1 for PUT, PATCH operations
        /// </summary>
        /// <exception cref="DefectDojo.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">A unique integer value identifying this system_ settings.</param>
        /// <param name="data"></param>
        /// <returns>SystemSettings</returns>
        public SystemSettings SystemSettingsPartialUpdate (int? id, SystemSettings data)
        {
             ApiResponse<SystemSettings> localVarResponse = SystemSettingsPartialUpdateWithHttpInfo(id, data);
             return localVarResponse.Data;
        }

        /// <summary>
        ///  Basic control over System Settings. Use &#39;id&#39; 1 for PUT, PATCH operations
        /// </summary>
        /// <exception cref="DefectDojo.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">A unique integer value identifying this system_ settings.</param>
        /// <param name="data"></param>
        /// <returns>ApiResponse of SystemSettings</returns>
        public ApiResponse< SystemSettings > SystemSettingsPartialUpdateWithHttpInfo (int? id, SystemSettings data)
        {
            // verify the required parameter 'id' is set
            if (id == null)
                throw new ApiException(400, "Missing required parameter 'id' when calling SystemSettingsApi->SystemSettingsPartialUpdate");
            // verify the required parameter 'data' is set
            if (data == null)
                throw new ApiException(400, "Missing required parameter 'data' when calling SystemSettingsApi->SystemSettingsPartialUpdate");

            var localVarPath = "./system_settings/{id}/";
            var localVarPathParams = new Dictionary<String, String>();
            var localVarQueryParams = new List<KeyValuePair<String, String>>();
            var localVarHeaderParams = new Dictionary<String, String>(this.Configuration.DefaultHeader);
            var localVarFormParams = new Dictionary<String, String>();
            var localVarFileParams = new Dictionary<String, FileParameter>();
            Object localVarPostBody = null;

            // to determine the Content-Type header
            String[] localVarHttpContentTypes = new String[] {
                "application/json"
            };
            String localVarHttpContentType = this.Configuration.ApiClient.SelectHeaderContentType(localVarHttpContentTypes);

            // to determine the Accept header
            String[] localVarHttpHeaderAccepts = new String[] {
                "application/json"
            };
            String localVarHttpHeaderAccept = this.Configuration.ApiClient.SelectHeaderAccept(localVarHttpHeaderAccepts);
            if (localVarHttpHeaderAccept != null)
                localVarHeaderParams.Add("Accept", localVarHttpHeaderAccept);

            if (id != null) localVarPathParams.Add("id", this.Configuration.ApiClient.ParameterToString(id)); // path parameter
            if (data != null && data.GetType() != typeof(byte[]))
            {
                localVarPostBody = this.Configuration.ApiClient.Serialize(data); // http body (model) parameter
            }
            else
            {
                localVarPostBody = data; // byte array
            }

            // authentication (api_key) required
            if (!String.IsNullOrEmpty(this.Configuration.GetApiKeyWithPrefix("Authorization")))
            {
                localVarHeaderParams["Authorization"] = this.Configuration.GetApiKeyWithPrefix("Authorization");
            }

            // make the HTTP request
            IRestResponse localVarResponse = (IRestResponse) this.Configuration.ApiClient.CallApi(localVarPath,
                Method.PATCH, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams,
                localVarPathParams, localVarHttpContentType);

            int localVarStatusCode = (int) localVarResponse.StatusCode;

            if (ExceptionFactory != null)
            {
                Exception exception = ExceptionFactory("SystemSettingsPartialUpdate", localVarResponse);
                if (exception != null) throw exception;
            }

            return new ApiResponse<SystemSettings>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Key, x => x.Value.ToString()),
                (SystemSettings) this.Configuration.ApiClient.Deserialize(localVarResponse, typeof(SystemSettings)));
        }

        /// <summary>
        ///  Basic control over System Settings. Use &#39;id&#39; 1 for PUT, PATCH operations
        /// </summary>
        /// <exception cref="DefectDojo.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">A unique integer value identifying this system_ settings.</param>
        /// <param name="data"></param>
        /// <returns>Task of SystemSettings</returns>
        public async System.Threading.Tasks.Task<SystemSettings> SystemSettingsPartialUpdateAsync (int? id, SystemSettings data)
        {
             ApiResponse<SystemSettings> localVarResponse = await SystemSettingsPartialUpdateAsyncWithHttpInfo(id, data);
             return localVarResponse.Data;

        }

        /// <summary>
        ///  Basic control over System Settings. Use &#39;id&#39; 1 for PUT, PATCH operations
        /// </summary>
        /// <exception cref="DefectDojo.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">A unique integer value identifying this system_ settings.</param>
        /// <param name="data"></param>
        /// <returns>Task of ApiResponse (SystemSettings)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<SystemSettings>> SystemSettingsPartialUpdateAsyncWithHttpInfo (int? id, SystemSettings data)
        {
            // verify the required parameter 'id' is set
            if (id == null)
                throw new ApiException(400, "Missing required parameter 'id' when calling SystemSettingsApi->SystemSettingsPartialUpdate");
            // verify the required parameter 'data' is set
            if (data == null)
                throw new ApiException(400, "Missing required parameter 'data' when calling SystemSettingsApi->SystemSettingsPartialUpdate");

            var localVarPath = "./system_settings/{id}/";
            var localVarPathParams = new Dictionary<String, String>();
            var localVarQueryParams = new List<KeyValuePair<String, String>>();
            var localVarHeaderParams = new Dictionary<String, String>(this.Configuration.DefaultHeader);
            var localVarFormParams = new Dictionary<String, String>();
            var localVarFileParams = new Dictionary<String, FileParameter>();
            Object localVarPostBody = null;

            // to determine the Content-Type header
            String[] localVarHttpContentTypes = new String[] {
                "application/json"
            };
            String localVarHttpContentType = this.Configuration.ApiClient.SelectHeaderContentType(localVarHttpContentTypes);

            // to determine the Accept header
            String[] localVarHttpHeaderAccepts = new String[] {
                "application/json"
            };
            String localVarHttpHeaderAccept = this.Configuration.ApiClient.SelectHeaderAccept(localVarHttpHeaderAccepts);
            if (localVarHttpHeaderAccept != null)
                localVarHeaderParams.Add("Accept", localVarHttpHeaderAccept);

            if (id != null) localVarPathParams.Add("id", this.Configuration.ApiClient.ParameterToString(id)); // path parameter
            if (data != null && data.GetType() != typeof(byte[]))
            {
                localVarPostBody = this.Configuration.ApiClient.Serialize(data); // http body (model) parameter
            }
            else
            {
                localVarPostBody = data; // byte array
            }

            // authentication (api_key) required
            if (!String.IsNullOrEmpty(this.Configuration.GetApiKeyWithPrefix("Authorization")))
            {
                localVarHeaderParams["Authorization"] = this.Configuration.GetApiKeyWithPrefix("Authorization");
            }

            // make the HTTP request
            IRestResponse localVarResponse = (IRestResponse) await this.Configuration.ApiClient.CallApiAsync(localVarPath,
                Method.PATCH, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams,
                localVarPathParams, localVarHttpContentType);

            int localVarStatusCode = (int) localVarResponse.StatusCode;

            if (ExceptionFactory != null)
            {
                Exception exception = ExceptionFactory("SystemSettingsPartialUpdate", localVarResponse);
                if (exception != null) throw exception;
            }

            return new ApiResponse<SystemSettings>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Key, x => x.Value.ToString()),
                (SystemSettings) this.Configuration.ApiClient.Deserialize(localVarResponse, typeof(SystemSettings)));
        }

        /// <summary>
        ///  Basic control over System Settings. Use &#39;id&#39; 1 for PUT, PATCH operations
        /// </summary>
        /// <exception cref="DefectDojo.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">A unique integer value identifying this system_ settings.</param>
        /// <param name="data"></param>
        /// <returns>SystemSettings</returns>
        public SystemSettings SystemSettingsUpdate (int? id, SystemSettings data)
        {
             ApiResponse<SystemSettings> localVarResponse = SystemSettingsUpdateWithHttpInfo(id, data);
             return localVarResponse.Data;
        }

        /// <summary>
        ///  Basic control over System Settings. Use &#39;id&#39; 1 for PUT, PATCH operations
        /// </summary>
        /// <exception cref="DefectDojo.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">A unique integer value identifying this system_ settings.</param>
        /// <param name="data"></param>
        /// <returns>ApiResponse of SystemSettings</returns>
        public ApiResponse< SystemSettings > SystemSettingsUpdateWithHttpInfo (int? id, SystemSettings data)
        {
            // verify the required parameter 'id' is set
            if (id == null)
                throw new ApiException(400, "Missing required parameter 'id' when calling SystemSettingsApi->SystemSettingsUpdate");
            // verify the required parameter 'data' is set
            if (data == null)
                throw new ApiException(400, "Missing required parameter 'data' when calling SystemSettingsApi->SystemSettingsUpdate");

            var localVarPath = "./system_settings/{id}/";
            var localVarPathParams = new Dictionary<String, String>();
            var localVarQueryParams = new List<KeyValuePair<String, String>>();
            var localVarHeaderParams = new Dictionary<String, String>(this.Configuration.DefaultHeader);
            var localVarFormParams = new Dictionary<String, String>();
            var localVarFileParams = new Dictionary<String, FileParameter>();
            Object localVarPostBody = null;

            // to determine the Content-Type header
            String[] localVarHttpContentTypes = new String[] {
                "application/json"
            };
            String localVarHttpContentType = this.Configuration.ApiClient.SelectHeaderContentType(localVarHttpContentTypes);

            // to determine the Accept header
            String[] localVarHttpHeaderAccepts = new String[] {
                "application/json"
            };
            String localVarHttpHeaderAccept = this.Configuration.ApiClient.SelectHeaderAccept(localVarHttpHeaderAccepts);
            if (localVarHttpHeaderAccept != null)
                localVarHeaderParams.Add("Accept", localVarHttpHeaderAccept);

            if (id != null) localVarPathParams.Add("id", this.Configuration.ApiClient.ParameterToString(id)); // path parameter
            if (data != null && data.GetType() != typeof(byte[]))
            {
                localVarPostBody = this.Configuration.ApiClient.Serialize(data); // http body (model) parameter
            }
            else
            {
                localVarPostBody = data; // byte array
            }

            // authentication (api_key) required
            if (!String.IsNullOrEmpty(this.Configuration.GetApiKeyWithPrefix("Authorization")))
            {
                localVarHeaderParams["Authorization"] = this.Configuration.GetApiKeyWithPrefix("Authorization");
            }

            // make the HTTP request
            IRestResponse localVarResponse = (IRestResponse) this.Configuration.ApiClient.CallApi(localVarPath,
                Method.PUT, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams,
                localVarPathParams, localVarHttpContentType);

            int localVarStatusCode = (int) localVarResponse.StatusCode;

            if (ExceptionFactory != null)
            {
                Exception exception = ExceptionFactory("SystemSettingsUpdate", localVarResponse);
                if (exception != null) throw exception;
            }

            return new ApiResponse<SystemSettings>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Key, x => x.Value.ToString()),
                (SystemSettings) this.Configuration.ApiClient.Deserialize(localVarResponse, typeof(SystemSettings)));
        }

        /// <summary>
        ///  Basic control over System Settings. Use &#39;id&#39; 1 for PUT, PATCH operations
        /// </summary>
        /// <exception cref="DefectDojo.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">A unique integer value identifying this system_ settings.</param>
        /// <param name="data"></param>
        /// <returns>Task of SystemSettings</returns>
        public async System.Threading.Tasks.Task<SystemSettings> SystemSettingsUpdateAsync (int? id, SystemSettings data)
        {
             ApiResponse<SystemSettings> localVarResponse = await SystemSettingsUpdateAsyncWithHttpInfo(id, data);
             return localVarResponse.Data;

        }

        /// <summary>
        ///  Basic control over System Settings. Use &#39;id&#39; 1 for PUT, PATCH operations
        /// </summary>
        /// <exception cref="DefectDojo.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">A unique integer value identifying this system_ settings.</param>
        /// <param name="data"></param>
        /// <returns>Task of ApiResponse (SystemSettings)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<SystemSettings>> SystemSettingsUpdateAsyncWithHttpInfo (int? id, SystemSettings data)
        {
            // verify the required parameter 'id' is set
            if (id == null)
                throw new ApiException(400, "Missing required parameter 'id' when calling SystemSettingsApi->SystemSettingsUpdate");
            // verify the required parameter 'data' is set
            if (data == null)
                throw new ApiException(400, "Missing required parameter 'data' when calling SystemSettingsApi->SystemSettingsUpdate");

            var localVarPath = "./system_settings/{id}/";
            var localVarPathParams = new Dictionary<String, String>();
            var localVarQueryParams = new List<KeyValuePair<String, String>>();
            var localVarHeaderParams = new Dictionary<String, String>(this.Configuration.DefaultHeader);
            var localVarFormParams = new Dictionary<String, String>();
            var localVarFileParams = new Dictionary<String, FileParameter>();
            Object localVarPostBody = null;

            // to determine the Content-Type header
            String[] localVarHttpContentTypes = new String[] {
                "application/json"
            };
            String localVarHttpContentType = this.Configuration.ApiClient.SelectHeaderContentType(localVarHttpContentTypes);

            // to determine the Accept header
            String[] localVarHttpHeaderAccepts = new String[] {
                "application/json"
            };
            String localVarHttpHeaderAccept = this.Configuration.ApiClient.SelectHeaderAccept(localVarHttpHeaderAccepts);
            if (localVarHttpHeaderAccept != null)
                localVarHeaderParams.Add("Accept", localVarHttpHeaderAccept);

            if (id != null) localVarPathParams.Add("id", this.Configuration.ApiClient.ParameterToString(id)); // path parameter
            if (data != null && data.GetType() != typeof(byte[]))
            {
                localVarPostBody = this.Configuration.ApiClient.Serialize(data); // http body (model) parameter
            }
            else
            {
                localVarPostBody = data; // byte array
            }

            // authentication (api_key) required
            if (!String.IsNullOrEmpty(this.Configuration.GetApiKeyWithPrefix("Authorization")))
            {
                localVarHeaderParams["Authorization"] = this.Configuration.GetApiKeyWithPrefix("Authorization");
            }

            // make the HTTP request
            IRestResponse localVarResponse = (IRestResponse) await this.Configuration.ApiClient.CallApiAsync(localVarPath,
                Method.PUT, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams,
                localVarPathParams, localVarHttpContentType);

            int localVarStatusCode = (int) localVarResponse.StatusCode;

            if (ExceptionFactory != null)
            {
                Exception exception = ExceptionFactory("SystemSettingsUpdate", localVarResponse);
                if (exception != null) throw exception;
            }

            return new ApiResponse<SystemSettings>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Key, x => x.Value.ToString()),
                (SystemSettings) this.Configuration.ApiClient.Deserialize(localVarResponse, typeof(SystemSettings)));
        }

    }
}
