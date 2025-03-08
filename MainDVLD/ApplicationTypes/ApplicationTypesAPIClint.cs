using MainDVLD.ApplicationTypes.DTOs;
using MainDVLD.Globals;
using MainDVLD.HttpConnection;
using MainDVLD.Users.DTOs;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http.Json;
using System.Text;
using System.Threading.Tasks;

namespace MainDVLD.ApplicationTypes
{
    public class ApplicationTypesAPIClint
    {
        private static readonly HttpClient _staticHttpClient = HttpClientSingleton.Instance;
        private static string _endPoint = "ApplicationTypes/";
        public  async Task<ApiResult<List<ApplicationTypesDTO>>> GetAllApplicationTypes()
        {
            var apiResult = new ApiResult<List<ApplicationTypesDTO>>();
            try
            {
                var response = await _staticHttpClient.GetAsync(_endPoint + "All");

                if (response.IsSuccessStatusCode)
                {
                    apiResult.IsSuccess = true;
                    apiResult.Status = ApiResponseStatus.Success;
                    var ApplicationTypes = await _staticHttpClient.GetFromJsonAsync<List<ApplicationTypesDTO>>(_endPoint + "All");
                    apiResult.Result = ApplicationTypes;
                }
                else
                {
                    apiResult.IsSuccess = false;
                    apiResult.Status = ApiResponseStatus.NotFound;
                    // if there is any message in the body 
                    apiResult.ErrorMessage = await response.Content.ReadAsStringAsync();
                }

            }
            catch (Exception ex)
            {
                //Logger loger = new Logger(LoggingMethod.EventLogger);
                //loger.Log($"User Error:{ex.Message}");

            }



            return apiResult;



        }

        public async Task<ApiResult<ApplicationTypesDTO>> FindApplicationTypeByID(int ApplicationTypeId)
        {
            var apiResult = new ApiResult<ApplicationTypesDTO>();

            try
            {
                var response = await _staticHttpClient.GetAsync(_endPoint + $"FindByID/{ApplicationTypeId}");

                if (response.IsSuccessStatusCode)
                {
                    apiResult.IsSuccess = true;
                    apiResult.Status = ApiResponseStatus.Success;
                    var ApplicationType = await response.Content.ReadFromJsonAsync<ApplicationTypesDTO>();
                    apiResult.Result = ApplicationType;
                }

                else
                {
                    apiResult.IsSuccess = false;
                    apiResult.Status = response.StatusCode switch
                    {
                        System.Net.HttpStatusCode.BadRequest => ApiResponseStatus.BadRequest,
                        System.Net.HttpStatusCode.NotFound => ApiResponseStatus.NotFound,
                        _ => ApiResponseStatus.ServerError,
                    };
                    // if there any message in the body will be stored in ErrorMessage
                    apiResult.ErrorMessage = await response.Content.ReadAsStringAsync();
                }


            }
            catch (Exception ex)
            {
                //Logger loger = new Logger(LoggingMethod.EventLogger);
                //loger.Log($"User Error:{ex.Message}");
            }
            return apiResult;
        }

        public async Task<ApiResult<ApplicationTypesDTO>> UpdateApplicationTypeInfo(int id, ApplicationTypesDTO UpdateApplicationType)
        {


            var apiResult = new ApiResult<ApplicationTypesDTO>();
            try
            {
                var response = await _staticHttpClient.PutAsJsonAsync(_endPoint + $"Update/{id}", UpdateApplicationType);

                if (response.IsSuccessStatusCode)
                {
                    apiResult.IsSuccess = true;
                    apiResult.Status = ApiResponseStatus.Success;
                    apiResult.Result = await response.Content.ReadFromJsonAsync<ApplicationTypesDTO>();

                }
                else
                {
                    apiResult.IsSuccess = false;
                    apiResult.Status = response.StatusCode switch
                    {
                        System.Net.HttpStatusCode.NotFound => ApiResponseStatus.NotFound,
                        System.Net.HttpStatusCode.BadRequest => ApiResponseStatus.BadRequest,
                        System.Net.HttpStatusCode.Conflict => ApiResponseStatus.Conflict,
                        _ => ApiResponseStatus.ServerError,

                    };
                    // if there is any error message in the body
                    apiResult.ErrorMessage = await response.Content.ReadAsStringAsync();
                }

            }
            catch (Exception ex)
            {
                //Logger logger = new Logger(LoggingMethod.EventLogger);
                //logger.Log($"User Error: {ex.Message}");

            }
            return apiResult;
        }




    }


}
